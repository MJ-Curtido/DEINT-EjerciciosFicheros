// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;

//C:\Users\Dam\Downloads\prueba\texto1.txt

String ruta1 = "";
String ruta2 = "";
String texto = "";
String frase = "";
String[] lineas;

/*
Console.WriteLine("-------1-------");
Console.WriteLine("Introduzca una ruta");
ruta1 = Console.ReadLine();

Console.WriteLine("Introduzca otra ruta");
ruta2 = Console.ReadLine();

texto = File.ReadAllText(ruta1);
File.WriteAllText(ruta2, texto);

Console.WriteLine("Operación realizada.");


Console.WriteLine("\n\n-------2-------");
Console.WriteLine("Introduzca una ruta");
ruta1 = Console.ReadLine();

Console.WriteLine("Introduzca una frase");
frase = Console.ReadLine();

lineas = File.ReadAllLines(ruta1);
for (int i = 0; i < lineas.Length; i++)
{
	if (lineas[i].Contains(frase))
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

Console.WriteLine("Operación realizada.");


Console.WriteLine("\n\n-------4-------");
String rutaNotas = "C:\\Users\\Dam\\Downloads\\prueba\\rutaNotas.txt";
String rutaSolucion = "C:\\Users\\Dam\\Downloads\\prueba\\rutaSolucion.txt";
String[] celdas;
String nomAlumno = "";
Double sumaNotas = 0.0;
int cont = 0;
Double maxNota = 0.0;

lineas = File.ReadAllLines(rutaNotas);
for (int i = 0; i < lineas.Length; i++)
{
	celdas = lineas[i].Split("-");

	sumaNotas += Double.Parse(celdas[1]);
	cont++;

	if (Double.Parse(celdas[2]) > maxNota)
	{
		maxNota = Double.Parse(celdas[2]);
		nomAlumno = celdas[0];
	}
}

texto = $"Nota media de matemáticas: {Math.Round(sumaNotas / cont * 100) / 100}\nAlumno con más nota: {nomAlumno} -> {maxNota}";

File.WriteAllText(rutaSolucion, texto);

Console.WriteLine("Operación realizada.");
*/


