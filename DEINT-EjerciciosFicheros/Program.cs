// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;

String ruta1 = "C:\\Users\\Dam\\Downloads\\texto1.txt";
String ruta2 = "C:\\Users\\Dam\\Downloads\\texto2.txt";
String texto = "";
String frase = "";
String[] lineas;

Console.WriteLine("-------1-------");
Console.WriteLine("Introduzca una ruta");
ruta1 = Console.ReadLine();

Console.WriteLine("Introduzca otra ruta");
ruta2 = Console.ReadLine();

texto = File.ReadAllText(ruta1);
File.WriteAllText(ruta2, texto);


Console.WriteLine("\n\n-------2-------");
Console.WriteLine("Introduzca una ruta");
ruta1 = Console.ReadLine();

Console.WriteLine("Introduzca una frase");
frase = Console.ReadLine();

lineas = File.ReadAllLines(ruta1);
for (int i = 0; i < lineas.Length; i++)
{
	if (Regex.IsMatch(lineas[i], @"^(.*\s" + frase + @"\s.*)$ || ^(" + frase + @"\s.*)$ || ^(.*\s" + frase + @")$ || ^(\s*" + frase + @"\s*)$"))
	{
		Console.WriteLine((i + 1) + ". " + lineas[i]);
	}
}


Console.WriteLine("\n\n-------3-------");
Console.WriteLine("Introduzca una ruta");
ruta1 = Console.ReadLine();

Console.WriteLine("Introduzca otra ruta");
ruta2 = Console.ReadLine();

File.Copy(ruta1, ruta2, true);