using Arreglos.Logica;
using System.Runtime.InteropServices.Marshalling;

Console.WriteLine("Areglo");



MiArreglo oMiArreglo = new MiArreglo(100);

oMiArreglo.Llenar(1, 100);

Console.WriteLine("Arreglo de sordenado:");
Console.WriteLine(oMiArreglo); // llama automáticamente a ToString()

Console.WriteLine("\n Arreglo ordenado ");
oMiArreglo.Ordenar();
Console.WriteLine(oMiArreglo);


Console. ReadKey();