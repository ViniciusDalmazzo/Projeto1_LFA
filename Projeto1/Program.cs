using System;
using System.Collections.Generic;

namespace Projeto1
{
    class Program
    {
        static void Main(string[] args)
        {
            Principal Principal = new Principal();
            int opcao = 0;

            #region Alfabeto

            Console.Clear();

            Console.WriteLine("Digite a quantidade de letras do alfabeto: ");

            var RetornoUsuario = Console.ReadLine();
            int.TryParse(RetornoUsuario, out int QtdAlfabeto);

            for (int i = 1; i <= QtdAlfabeto; i++)
            {
                Console.WriteLine($"Digite a {i}° letra do alfabeto: ");

                RetornoUsuario = Console.ReadLine();

                Principal.Alfabeto.Add(RetornoUsuario);
            }

            #endregion

            #region Regras de produção

            Console.WriteLine("Digite a quantidade de regras de produção: ");
            RetornoUsuario = Console.ReadLine();
            int.TryParse(RetornoUsuario, out int QtdRegras);

            for (int i = 1; i <= QtdRegras; i++)
            {
                Console.WriteLine($"Digite a {i}° regra de produção separada por vírgula: ");

                RetornoUsuario = Console.ReadLine();

                var regras = RetornoUsuario.Split(',');

                for (int j = 1; j < regras.Length; j++)
                {
                    if (j > 1)
                        i++;

                    Principal.RegrasDeProducao.Add(new RegraDeProducao(i, regras[0] == " " ? string.Empty : regras[0], regras[j] == " " ? string.Empty : regras[j]));
                }                
            }
            
            #endregion

            #region Variáveis

            Console.Clear();

            Console.WriteLine("Digite a quantidade de variáveis: ");

            RetornoUsuario = Console.ReadLine();
            int.TryParse(RetornoUsuario, out int QtdVariaveis);

            for (int i = 1; i <= QtdVariaveis; i++)
            {
                Console.WriteLine($"Digite a {i}° variável: ");

                RetornoUsuario = Console.ReadLine();
                
                Principal.Variaveis.Add(RetornoUsuario);
            }
            
            #endregion
            
            #region Letra inicial

            Console.Clear();

            Console.WriteLine("Digite a letra inicial: ");

            RetornoUsuario = Console.ReadLine();

            Principal.Inicial = RetornoUsuario;

            #endregion

            do
            {
                Console.Clear();

                Console.WriteLine("PROJETO 1 - LFA");
                Console.WriteLine("1 - Gerar sequência a partir das informações.");
                Console.WriteLine("2 - Gerar linguagem a partir das informações.");
                Console.WriteLine("Digite uma opção");

                int.TryParse(Console.ReadLine(), out opcao);

            } while (opcao != 1 && opcao != 2);

            #region Gerar sequência a partir de informações
            if (opcao == 1)
            {
                #region Letra inicial

                Console.Clear();

                Console.WriteLine("Digite a resposta: ");

                RetornoUsuario = Console.ReadLine();

                Principal.Resposta = RetornoUsuario;

                #endregion

                Console.Clear();

                Console.WriteLine("Validando informações..");

                Principal.Validacoes(false);

                if (!string.IsNullOrEmpty(Principal.Erro))
                {
                    Console.WriteLine(Principal.Erro);
                    Console.ReadLine();
                    return;
                }

                Console.WriteLine("Gerando sequência a partir das informações..");

                List<int> sequenciaGerada = Principal.GerarSequenciaAPartirDaLinguagem();

                Console.WriteLine($"Sequência gerada com sucesso. Resultado: {string.Join(", ", sequenciaGerada)}");
            }
            #endregion

            #region Gerar palavra a partir de informações
            else if (opcao == 2)
            {
                #region Sequencia

                Console.Clear();

                Console.WriteLine("Digite a quantidade de números da sequência: ");

                RetornoUsuario = Console.ReadLine();
                int.TryParse(RetornoUsuario, out int QtdSequencia);

                for (int i = 1; i <= QtdSequencia; i++)
                {
                    Console.WriteLine($"Digite o {i}° número da sequência: ");

                    RetornoUsuario = Console.ReadLine();

                    int.TryParse(RetornoUsuario, out int Sequencia);

                    Principal.Sequencia.Add(Sequencia);
                }

                #endregion

                Console.Clear();

                Console.WriteLine("Validando informações..");

                Principal.Validacoes(true);

                if (!string.IsNullOrEmpty(Principal.Erro))
                {
                    Console.WriteLine(Principal.Erro);
                    Console.ReadLine();
                    return;
                }

                Console.WriteLine("Gerando palavra a partir das informações..");

                Principal.GerarPalavraAPartirDaSequencia();

                if (!string.IsNullOrEmpty(Principal.Erro))
                {
                    Console.WriteLine(Principal.Erro);
                    Console.ReadLine();
                    return;
                }

                Console.WriteLine($"Palavra gerada com sucesso. Resultado: {Principal.Resposta}");
            }
            #endregion
            
            Console.ReadLine();

        }
    }
}
