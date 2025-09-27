using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    internal class Libro
    {
        //Atributos
        public string Titulo;
        public string Autor;
        public int Ano;
        

        //Constructor
        public Libro(string titulo, string autor, int ano)
        {
            Titulo = titulo;
            Autor = autor;
            Ano = Math.Abs(ano);
        }

        //Método
        public void MostrarInformacion()
        {
            Console.WriteLine($"{Titulo}");
            Console.WriteLine($"Autor: {Autor}");
            Console.WriteLine($"Año: {Ano}");
        }
    }
}
