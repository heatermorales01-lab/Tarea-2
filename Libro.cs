using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tarea2
{
    internal class Libro
    {
        //Atributos
        public string Titulo;
        public string Autor;
        private int Ano;

        //Encapsulamiento

        //setters y getters
        public int getAno()
        {
            return Ano;
        }

        public void setAno(int ano)
        {
            if (ano > 0)
                Ano = ano;
            else
                Ano = Math.Abs(ano);
        }

        //Constructor
        public Libro(string titulo, string autor, int ano)
        {
            Titulo = titulo;
            Autor = autor;
            setAno(ano);
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
