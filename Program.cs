using Projeto.Series.Classes;
using System;

namespace Projeto.Series
{
    internal class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();

        private static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while(opcaoUsuario.ToUpper() != "X")
            {
                switch(opcaoUsuario)
                {
                    case "1":
                        ListaSerie();
                        break;
                    case "2":
                        InserirSerie();
                        break;
                    case "3":
                        AtualizarSerie();
                        break;
                    case "4":
                        ExcluirSerie();
                        break;
                    case "5":
                        VisualizarLista();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    default:
                        System.Console.WriteLine("Digite uma opção válida");
                        break;
                }

                opcaoUsuario = ObterOpcaoUsuario();
            }

        }

        private static void ListaSerie()
        {
           System.Console.WriteLine("Série(s):");

           var lista = repositorio.Lista();

           if(lista.Count == 0)
           {
             System.Console.WriteLine("Nenhuma lista cadastrada! :(");
             return;
           }
           foreach (var serie in lista)
           {
                var excluido = serie.RetornaExcluir();
                if(!excluido)
                    System.Console.WriteLine($"Id: {serie.RetornaId()} | Série: {serie.RetornaTitulo()}");
           }
        }
        private static void InserirSerie()
        {
            System.Console.WriteLine("Inserir Nova Série");
            PerguntaDadosSerie Dados = new PerguntaDadosSerie();
            var novaSerie = Dados.JuntaDadosSerie();
            repositorio.Inserir(novaSerie);
        }
        private static void AtualizarSerie()
        {
           ListaSerie();
           System.Console.WriteLine("Digite o ID da série:");
           var idSerie = int.Parse(Console.ReadLine());
           PerguntaDadosSerie Dados = new PerguntaDadosSerie();
            var atualizaSerie = Dados.JuntaDadosSerie(idSerie);
            repositorio.Atualizar(idSerie, atualizaSerie);

        }
        private static void ExcluirSerie()
        {
            ListaSerie();
            System.Console.WriteLine("Digite o ID da série:");
            var idSerie = int.Parse(Console.ReadLine());  

            System.Console.WriteLine("Deseja realmente excluir essa série? [S] - Sim; [N] - Não");
            var decisao = Console.ReadLine().ToUpper();
            if(decisao == "S")
                repositorio.Excluir(idSerie);
            else
            {
                return;
            }
        }
        private static void VisualizarLista()
        {
            ListaSerie();
            System.Console.WriteLine("Digite o ID da série:");
            var idSerie = int.Parse(Console.ReadLine());  

            var serie = repositorio.RetornaPorId(idSerie);
            System.Console.WriteLine(serie);
        }
        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Projeto Séries ao sua disposição! :D");
            Console.WriteLine("Informe a opção desejada:");

            Console.WriteLine("1 - Listar Série");
            Console.WriteLine("2 - Inserir Nova Série");
            Console.WriteLine("3 - Atualizar Série");
            Console.WriteLine("4 - Excluir Série");
            Console.WriteLine("5 - Visualizar Série");
            Console.WriteLine("C - Limpar Tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            System.Console.WriteLine();
            return opcaoUsuario;
        }
    }
}