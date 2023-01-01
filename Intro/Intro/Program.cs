// See https://aka.ms/new-console-template for more information
string cadena;

Console.WriteLine("Hello, World!");
Console.WriteLine("{0} {1}", "¡Hola", "mundo!");
string nombre = "Eliab";
cadena = String.Format("Nombre = {0}.\nHora actual = {1:hh}:{1:mm}", nombre, DateTime.Now);

Console.WriteLine(cadena);

Console.ReadKey();