using Arreglos.Logica;
using System.Runtime.InteropServices.Marshalling;

Console.WriteLine("Areglo");

MiArreglo oMiArreglo = new MiArreglo(5);

oMiArreglo.Agregar(5);
oMiArreglo.Agregar(7);
oMiArreglo.Agregar(9);

oMiArreglo.insertar(2, 0);
Console.WriteLine(oMiArreglo);
Console.WriteLine("----------------------------------------------");

oMiArreglo.Eliminar(1);
Console.WriteLine(oMiArreglo);


//try
//{
//    for (int i = 0; i < oMiArreglo.N; i++)
//    {
//        oMiArreglo.Agregar(i * 6);
//    }
//}
//catch (Exception ex)
//{

//	Console.WriteLine($"Error: {ex.Message}");
//}



//oMiArreglo.Llenar(1, 100);

//Console.WriteLine("Arreglo desordenado:");
//Console.WriteLine(oMiArreglo); // llama automáticamente a ToString()

//Console.WriteLine("\n Arreglo ordenado de forma asendente");
//oMiArreglo.Ordenar();
//Console.WriteLine(oMiArreglo);

//Console.WriteLine("\n Arreglo ordenado de forma desendente");
//oMiArreglo.Ordenar(false);

Console.ReadKey();