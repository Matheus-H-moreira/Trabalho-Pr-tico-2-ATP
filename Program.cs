﻿class Program
{
    static int ingressoComumInicial = 30, ingressoComum = 30, ingressoPrioritarioInicial = 10, ingressoPrioritario = 10, ingressoVIPInicial = 10, ingressoVIP = 10, iComum = 0, iPrioritario = 0, iVIP = 0, espectadoresPresentes = 0;
    static string[] vetorNomesComum = new string[50];
    static int[] vetorIdadesComum = new int[50];
    static int[] vetorNumIngressosComum = new int[50];
    static string[] vetorNomesPrioritario = new string[50];
    static int[] vetorIdadesPrioritario = new int[50];
    static int[] vetorNumIngressosPrioritario = new int[50];
    static string[] vetorNomesVIP = new string[50];
    static int[] vetorIdadesVIP = new int[50];
    static int[] vetorNumIngressosVIP = new int[50];
    static void configVetores()
    {
        for (int i = 0; i < vetorNomesComum.Length; i++)
        {
            vetorNomesComum[i] = "";
        }

        for (int i = 0; i < vetorIdadesComum.Length; i++)
        {
            vetorIdadesComum[i] = 0;
        }

        for (int i = 0; i < vetorNumIngressosComum.Length; i++)
        {
            vetorNumIngressosComum[i] = 0;
        }

        for (int i = 0; i < vetorNomesPrioritario.Length; i++)
        {
            vetorNomesPrioritario[i] = "";
        }

        for (int i = 0; i < vetorIdadesPrioritario.Length; i++)
        {
            vetorIdadesPrioritario[i] = 0;
        }

        for (int i = 0; i < vetorNumIngressosPrioritario.Length; i++)
        {
            vetorNumIngressosPrioritario[i] = 0;
        }

        for (int i = 0; i < vetorNomesVIP.Length; i++)
        {
            vetorNomesVIP[i] = "";
        }

        for (int i = 0; i < vetorIdadesVIP.Length; i++)
        {
            vetorIdadesVIP[i] = 0;
        }

        for (int i = 0; i < vetorNumIngressosVIP.Length; i++)
        {
            vetorNumIngressosVIP[i] = 0;
        }
    }
    static void escolha()
    {
        bool continuar = true;

        while (continuar == true)
        {
            Console.Clear();
            System.Console.WriteLine("------------------------------------------");
            System.Console.WriteLine("1. Registrar entrada de um espectador: ");
            System.Console.WriteLine("2. Registrar saída de um espectador: ");
            System.Console.WriteLine("3. Consultar ingressos disponíveis: ");
            System.Console.WriteLine("4. Exibir resumo do evento: ");
            System.Console.WriteLine("5. Listar todos os espectadores presentes:");
            System.Console.WriteLine("6. Sair");
            System.Console.WriteLine("------------------------------------------");
            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    entradaEspectador();
                    break;

                case 2:
                    saidaEspectador();
                    break;

                case 3:
                    consultarIngressos();
                    break;
                case 4:
                    exibirResumo();
                    break;
                case 5:
                    listarEspectador();
                    break;
                case 6:
                    while (true)
                    {
                        System.Console.WriteLine("Deseja sair [S/N]");
                        char opcao = char.Parse(Console.ReadLine());

                        if (opcao == 'S' || opcao == 's')
                        {
                            System.Console.WriteLine("Fechando programa");
                            System.Console.WriteLine("[Aperte enter]");
                            Console.ReadLine();
                            continuar = false;
                            return;
                        }
                        else if (opcao == 'N' || opcao == 'n')
                        {
                            Console.Clear();
                            System.Console.WriteLine("Voltando para menu");
                            System.Console.WriteLine("[Aperte enter]");
                            Console.ReadLine();
                            break;
                        }
                        else
                        {
                            System.Console.WriteLine("Opção não encontrada");
                        }
                    }
                    break;
            }
        }
    }
    static void entradaEspectador()
    {
        Console.Clear();

        int idade, numIngresso;
        string nome;
        bool verdadeiro = true;

        while (verdadeiro == true)
        {
            System.Console.WriteLine("----------------------------");
            System.Console.WriteLine("Escolha o tipo do ingresso: ");
            System.Console.WriteLine("1. Ingresso Comum");
            System.Console.WriteLine("2. Ingresso Prioritário: ");
            System.Console.WriteLine("3. Ingresso VIP");
            System.Console.WriteLine("4. Sair");
            System.Console.WriteLine("----------------------------");
            int tipoIngresso = int.Parse(Console.ReadLine());

            switch (tipoIngresso)
            {
                case 1:
                    if (ingressoComum <= 0)
                    {
                        Console.WriteLine("Não há ingressos disponíveis para essa categoria.");
                        Console.ReadLine();
                        break;
                    }

                    Console.Clear();
                    System.Console.WriteLine("----------------------------");
                    System.Console.Write("Nome: ");
                    nome = Console.ReadLine();
                    vetorNomesComum[iComum] = nome;
                    System.Console.Write("Idade: ");
                    idade = int.Parse(Console.ReadLine());
                    vetorIdadesComum[iComum] = idade;
                    do
                    {
                        System.Console.Write("Número do ingresso[4 digitos]: ");
                        numIngresso = int.Parse(Console.ReadLine());

                        if (numIngresso.ToString().Length != 4)
                        {
                            System.Console.WriteLine("Código inexistente");
                        }

                    } while (numIngresso.ToString().Length != 4);
                    vetorNumIngressosComum[iComum] = numIngresso;

                    ingressoComum--;
                    verdadeiro = false;
                    iComum++;
                    espectadoresPresentes++;
                    break;

                case 2:
                    if (ingressoPrioritario <= 0)
                    {
                        Console.WriteLine("Não há ingressos disponíveis para essa categoria.");
                        Console.ReadLine();
                        break;
                    }

                    Console.Clear();
                    System.Console.WriteLine("----------------------------");
                    System.Console.Write("Nome: ");
                    nome = Console.ReadLine();
                    vetorNomesPrioritario[iPrioritario] = nome;
                    System.Console.Write("Idade: ");
                    idade = int.Parse(Console.ReadLine());
                    vetorIdadesPrioritario[iPrioritario] = idade;
                    do
                    {
                        System.Console.Write("Número do ingresso[4 digitos]: ");
                        numIngresso = int.Parse(Console.ReadLine());

                        if (numIngresso.ToString().Length != 4)
                        {
                            System.Console.WriteLine("Código inexistente");
                        }

                    } while (numIngresso.ToString().Length != 4);
                    vetorNumIngressosPrioritario[iPrioritario] = numIngresso;

                    ingressoPrioritario--;
                    verdadeiro = false;
                    iPrioritario++;
                    espectadoresPresentes++;
                    break;

                case 3:
                    if (ingressoVIP <= 0)
                    {
                        Console.WriteLine("Não há ingressos disponíveis para essa categoria.");
                        Console.ReadLine();
                        break;
                    }

                    Console.Clear();
                    System.Console.WriteLine("----------------------------");
                    System.Console.Write("Nome: ");
                    nome = Console.ReadLine();
                    vetorNomesVIP[iVIP] = nome;
                    System.Console.Write("Idade: ");
                    idade = int.Parse(Console.ReadLine());
                    vetorIdadesVIP[iVIP] = idade;
                    do
                    {
                        System.Console.Write("Número do ingresso[4 digitos]: ");
                        numIngresso = int.Parse(Console.ReadLine());

                        if (numIngresso.ToString().Length != 4)
                        {
                            System.Console.WriteLine("Código inexistente");
                        }

                    } while (numIngresso.ToString().Length != 4);
                    vetorNumIngressosVIP[iVIP] = numIngresso;

                    ingressoVIP--;
                    verdadeiro = false;
                    iVIP++;
                    espectadoresPresentes++;
                    break;

                case 4:
                    Console.Clear();
                    System.Console.WriteLine("-------------------------------");
                    System.Console.WriteLine("Voltando [Aperte enter]");
                    System.Console.WriteLine("-------------------------------");
                    Console.ReadLine();

                    verdadeiro = false;
                    break;

                default:
                    Console.Clear();
                    System.Console.WriteLine("----------------------------");
                    System.Console.WriteLine("Opção escolhida inexistente ");
                    System.Console.WriteLine("Voltando para o menu [Aperte enter]");
                    Console.ReadLine();
                    break;
            }
        }
    }
    static void saidaEspectador()
    {
        Console.Clear();

        int numIngresso, tipoIngresso, posicaoVetor = 0;
        bool verdadeiro = true, achado = false;

        while (verdadeiro == true)
        {
            System.Console.WriteLine("----------------------------");
            do
            {
                System.Console.Write("Número do ingresso[4 digitos]: ");
                numIngresso = int.Parse(Console.ReadLine());

                if (numIngresso.ToString().Length != 4)
                {
                    System.Console.WriteLine("Código inexistente");
                }

            } while (numIngresso.ToString().Length != 4);
            System.Console.WriteLine("Tipo do ingresso: ");
            System.Console.WriteLine("1. Ingresso Comum");
            System.Console.WriteLine("2. Ingresso Prioritário");
            System.Console.WriteLine("3. Ingresso VIP");
            System.Console.WriteLine("4. Sair");
            System.Console.WriteLine("----------------------------");
            tipoIngresso = int.Parse(Console.ReadLine());
            switch (tipoIngresso)
            {
                case 1:
                    Console.Clear();

                    for (int i = 0; i < vetorNumIngressosComum.Length; i++)
                    {
                        if (vetorNumIngressosComum[i] == numIngresso)
                        {
                            posicaoVetor = i;

                            numIngresso = 0;

                            verdadeiro = false;

                            achado = true;
                        }
                    }

                    if (achado == true)
                    {
                        System.Console.WriteLine("Espectador removido com sucesso");
                        System.Console.WriteLine("Voltando para o menu[Aperte enter]");
                        Console.ReadLine();
                        vetorNumIngressosComum[posicaoVetor] = 0;
                        vetorIdadesComum[posicaoVetor] = 0;
                        vetorNomesComum[posicaoVetor] = "";

                        ingressoComum++;
                        espectadoresPresentes--;
                    }
                    else
                    {
                        System.Console.WriteLine("Número do ingresso não encontrado nessa categoria de ingressos");
                        System.Console.WriteLine("Voltando para o menu [Aperte enter]");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }
                    break;

                case 2:
                    Console.Clear();

                    for (int i = 0; i < vetorNumIngressosPrioritario.Length; i++)
                    {
                        if (vetorNumIngressosPrioritario[i] == numIngresso)
                        {
                            posicaoVetor = i;

                            numIngresso = 0;

                            verdadeiro = false;

                            achado = true;
                        }
                    }

                    if (achado == true)
                    {
                        System.Console.WriteLine("Espectador removido com sucesso");
                        System.Console.WriteLine("Voltando para o menu[Aperte enter]");
                        Console.ReadLine();
                        vetorNumIngressosPrioritario[posicaoVetor] = 0;
                        vetorIdadesPrioritario[posicaoVetor] = 0;
                        vetorNomesPrioritario[posicaoVetor] = "";

                        ingressoPrioritario++;
                        espectadoresPresentes--;
                    }
                    else
                    {
                        System.Console.WriteLine("Número do ingresso não encontrado nessa categoria de ingressos");
                        System.Console.WriteLine("Voltando para o menu [Aperte enter]");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }
                    break;

                case 3:
                    Console.Clear();

                    for (int i = 0; i < vetorNumIngressosVIP.Length; i++)
                    {
                        if (vetorNumIngressosVIP[i] == numIngresso)
                        {
                            posicaoVetor = i;

                            numIngresso = 0;

                            verdadeiro = false;

                            achado = true;
                        }
                    }

                    if (achado == true)
                    {
                        System.Console.WriteLine("Espectador removido com sucesso");
                        System.Console.WriteLine("Voltando para o menu[Aperte enter]");
                        Console.ReadLine();
                        vetorNumIngressosVIP[posicaoVetor] = 0;
                        vetorIdadesVIP[posicaoVetor] = 0;
                        vetorNomesVIP[posicaoVetor] = "";

                        ingressoVIP++;
                        espectadoresPresentes--;
                    }
                    else
                    {
                        System.Console.WriteLine("Número do ingresso não encontrado nessa categoria de ingressos");
                        System.Console.WriteLine("Voltando para o menu [Aperte enter]");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }
                    break;

                case 4:
                    Console.Clear();
                    System.Console.WriteLine("-------------------------------");
                    System.Console.WriteLine("Voltando [Aperte enter]");
                    System.Console.WriteLine("-------------------------------");
                    Console.ReadLine();

                    verdadeiro = false;
                    break;

                default:
                    Console.Clear();
                    System.Console.WriteLine("----------------------------");
                    System.Console.WriteLine("Opção escolhida inexistente ");
                    System.Console.WriteLine("Voltando para o menu [Aperte enter]");
                    Console.ReadLine();
                    break;
            }
        }
    }
    static void consultarIngressos()
    {
        bool verdadeiro = true;

        while (verdadeiro == true)
        {
            Console.Clear();
            System.Console.WriteLine("----------------------------");
            System.Console.WriteLine("1. Ingresso Comum");
            System.Console.WriteLine("2. Ingresso Prioritário");
            System.Console.WriteLine("3. Ingresso VIP");
            System.Console.WriteLine("4. Sair");
            System.Console.WriteLine("----------------------------");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.Clear();
                    System.Console.WriteLine("-------------------------------");
                    System.Console.WriteLine($"Ingressos totais: {ingressoComumInicial} | Ingressos disponíveis: {ingressoComum}");
                    System.Console.WriteLine("Voltar [Aperte enter]");
                    System.Console.WriteLine("-------------------------------");
                    Console.ReadLine();
                    break;

                case 2:
                    Console.Clear();
                    System.Console.WriteLine("-------------------------------");
                    System.Console.WriteLine($" Ingressos totais: {ingressoPrioritarioInicial} | Ingressos disponíveis: {ingressoPrioritario}");
                    System.Console.WriteLine("Voltar [Aperte enter]");
                    System.Console.WriteLine("-------------------------------");
                    Console.ReadLine();
                    break;

                case 3:
                    Console.Clear();
                    System.Console.WriteLine("-------------------------------");
                    System.Console.WriteLine($"Ingressos totais: {ingressoVIPInicial} | Ingressos disponíveis: {ingressoVIP}");
                    System.Console.WriteLine("Voltar [Aperte enter]");
                    System.Console.WriteLine("-------------------------------");
                    Console.ReadLine();
                    break;

                case 4:
                    Console.Clear();
                    System.Console.WriteLine("-------------------------------");
                    System.Console.WriteLine("Voltando [Aperte enter]");
                    System.Console.WriteLine("-------------------------------");
                    Console.ReadLine();

                    verdadeiro = false;
                    break;
            }
        }
    }
    static void exibirResumo()
    {

        double percentualComum = 0, percentualPrioritario = 0, percentualVIP = 0;
        bool verdadeiro = true;

        if (espectadoresPresentes > 0)
        {
            percentualComum = (iComum * 100) / espectadoresPresentes;
            percentualPrioritario = (iPrioritario * 100) / espectadoresPresentes;
            percentualVIP = (iVIP * 100) / espectadoresPresentes;
        }

        while (verdadeiro == true)
        {
            Console.Clear();
            System.Console.WriteLine("-----------------------------------------");
            System.Console.WriteLine($"Número total de espectadores presentes: {espectadoresPresentes}");
            System.Console.WriteLine("Tipo ingresso: ");
            System.Console.WriteLine("1. Ingresso Comum");
            System.Console.WriteLine("2. Ingresso Prioritário");
            System.Console.WriteLine("3. Ingresso VIP");
            System.Console.WriteLine("4. Sair");
            System.Console.WriteLine("-----------------------------------------");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.Clear();
                    System.Console.WriteLine("-----------------------------------------");
                    System.Console.WriteLine($"Quantidade de pessoas presentes nessa categoria: {ingressoComum}");
                    System.Console.WriteLine($"Percentual de pessoas nessa categoria: {percentualComum}");
                    System.Console.WriteLine("Voltar para menu [aperte enter]");
                    System.Console.WriteLine("-----------------------------------------");
                    Console.ReadLine();

                    break;

                case 2:
                    Console.Clear();
                    System.Console.WriteLine("-----------------------------------------");
                    System.Console.WriteLine($"Quantidade de pessoas presentes nessa categoria: {ingressoPrioritario}");
                    System.Console.WriteLine($"Percentual de pessoas nessa categoria: {percentualPrioritario}");
                    System.Console.WriteLine("Voltar para menu [aperte enter]");
                    System.Console.WriteLine("-----------------------------------------");
                    Console.ReadLine();

                    break;

                case 3:
                    Console.Clear();
                    System.Console.WriteLine("-----------------------------------------");
                    System.Console.WriteLine($"Quantidade de pessoas presentes nessa categoria: {ingressoVIP}");
                    System.Console.WriteLine($"Percentual de pessoas nessa categoria: {percentualVIP}");
                    System.Console.WriteLine("Voltar para menu [aperte enter]");
                    System.Console.WriteLine("-----------------------------------------");
                    Console.ReadLine();

                    break;

                case 4:
                    Console.Clear();
                    System.Console.WriteLine("-------------------------------");
                    System.Console.WriteLine("Voltando [Aperte enter]");
                    System.Console.WriteLine("-------------------------------");
                    Console.ReadLine();

                    verdadeiro = false;
                    break;
            }
        }
    }
    static void listarEspectador()
    {
        while (true)
        {
            Console.Clear();
            System.Console.WriteLine("------------------------------------------");
            System.Console.WriteLine("Deseja listar o espectador de qual seção: ");
            System.Console.WriteLine("1. Ingresso Comum");
            System.Console.WriteLine("2. Ingresso Prioritário");
            System.Console.WriteLine("3. Ingresso VIP");
            System.Console.WriteLine("4. Sair");
            System.Console.WriteLine("------------------------------------------");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.Clear();
                    for (int i = 0; i < vetorNomesComum.Length; i++)
                    {
                        if (vetorIdadesComum[i] != 0)
                        {
                            System.Console.Write($"{i + 1}º espectador: \n Nome: {vetorNomesComum[i]}, Idade: {vetorIdadesComum[i]}, Número do ingresso: {vetorNumIngressosComum[i]} \n");
                        }
                    }
                    System.Console.WriteLine("[Aperte enter]");
                    Console.ReadLine();
                    break;

                case 2:
                    Console.Clear();
                    for (int i = 0; i < vetorNomesPrioritario.Length; i++)
                    {
                        if (vetorIdadesPrioritario[i] != 0)
                        {
                            System.Console.Write($"{i + 1}º espectador: \n Nome: {vetorNomesPrioritario[i]}, Idade: {vetorIdadesPrioritario[i]}, Número do ingresso: {vetorNumIngressosPrioritario[i]} \n");
                        }
                    }
                    System.Console.WriteLine("[Aperte enter]");
                    Console.ReadLine();
                    break;

                case 3:
                    Console.Clear();
                    for (int i = 0; i < vetorNomesVIP.Length; i++)
                    {
                        if (vetorIdadesVIP[i] != 0)
                        {
                            System.Console.Write($"{i + 1}º espectador: \n Nome: {vetorNomesVIP[i]}, Idade: {vetorIdadesVIP[i]}, Número do ingresso: {vetorNumIngressosVIP[i]} \n");
                        }
                    }
                    System.Console.WriteLine("[Aperte enter]");
                    Console.ReadLine();
                    break;

                case 4:
                    Console.Clear();
                    System.Console.WriteLine("Voltando [Aperte enter]");
                    return;
            }
        }
    }
    static void Main()
    {
        configVetores();
        escolha();
    }
}