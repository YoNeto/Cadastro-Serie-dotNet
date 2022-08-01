using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Series.Classes
{
    public class PerguntaDadosSerie
    {   
        public PerguntaDadosSerie(){}
        static SerieRepositorio repositorio = new SerieRepositorio();
        public Serie JuntaDadosSerie()
        {
            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
            System.Console.WriteLine($"{i}: {Enum.GetName(typeof(Genero), i)}");
            }
            System.Console.WriteLine("Digite o numero correspondente ao gênero da série:");
            int entradaGenero = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o titulo da série:");
            string entradaTitilo = Console.ReadLine();
            System.Console.WriteLine("Digite o ano de lançamento da série:");
            int entradaAno = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite uma descrição para essa série:");
            string entradaDescricao= Console.ReadLine();

            Serie novaSerie = new Serie(id: repositorio.ProximoId(),
                                    Genero:(Genero)entradaGenero,
                                    Titulo: entradaTitilo, 
                                    Descricao: entradaDescricao, 
                                    Ano: entradaAno);
            return novaSerie;
        }
        public Serie JuntaDadosSerie(int id)
        {
            var idSerie = id;
            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
            System.Console.WriteLine($"{i}: {Enum.GetName(typeof(Genero), i)}");
            }
            System.Console.WriteLine("Digite o numero correspondente ao gênero da série:");
            int entradaGenero = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o titulo da série:");
            string entradaTitilo = Console.ReadLine();
            System.Console.WriteLine("Digite o ano de lançamento da série:");
            int entradaAno = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite uma descrição para essa série:");
            string entradaDescricao= Console.ReadLine();

            Serie atualizaSerie = new Serie(id: idSerie,
                                    Genero:(Genero)entradaGenero,
                                    Titulo: entradaTitilo, 
                                    Descricao: entradaDescricao, 
                                    Ano: entradaAno);
            return atualizaSerie;
        }
    }
}