using Arreglos.Logica;
using System.Runtime.InteropServices.Marshalling;

Console.WriteLine("Areglo");

MiArreglo oMiArreglo = new MiArreglo(100);

try
{
    for (int i = 0; i < oMiArreglo.N; i++)
    {
        oMiArreglo.Agregar(i * 6);


catch (Exception ex)
{

	Console.WriteLine($"Error: {ex.Message}");
}



/*oMiArreglo.Llenar(1, 100);

Console.WriteLine("Arreglo desordenado:");
Console.WriteLine(oMiArreglo); // llama automáticamente a ToString()

Console.WriteLine("\n Arreglo ordenado de forma asendente");
oMiArreglo.Ordenar();
Console.WriteLine(oMiArreglo);

Console.WriteLine("\n Arreglo ordenado de forma desendente");
oMiArreglo.Ordenar(false);
*/
Console. ReadKey();