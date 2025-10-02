// See https://aka.ms/new-console-template for more information

using Tarea2;

Console.WriteLine(" ____  __ ____  __    __   ___   ______  ____   ___  ___ \r\n || )) || || )) ||    ||  // \\\\  | || | ||     //   // \\\\\r\n ||=)  || ||=)  ||    || ((   ))   ||   ||==  ((    ||=||\r\n ||_)) || ||_)) ||__| ||  \\\\_//    ||   ||___  \\\\__ || ||\r\n                                                         \n");
Console.WriteLine("Libros disponibles: \n");

List<Libro> libros = new List<Libro>
{
    new Libro("Cien años de soledad", "Gabriel García Márquez", -1967),
    new Libro("El código Da Vinci", "Dan Brown", 2003),
    new Libro("Don Quijote de la Mancha", "Miguel de Cervantes", 1605),
    new Libro("Orgullo y prejuicio", "Jane Austen", 1813),
    new Libro("1984", "George Orwell", 1949)
};

foreach (Libro libro in libros)
{
    libro.MostrarInformacion();
    Console.WriteLine("--");
}
