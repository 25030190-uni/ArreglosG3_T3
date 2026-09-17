using System;
using System.Collections.Generic;
using System.Text;

namespace Arreglos.Logica
{
    public class MiArreglo
    {
        //Atributos

        private int _tope;
        private int[] _arreglo;

        //constructor 
        public MiArreglo(int n)
        {
            N = n;
            _arreglo=new int[n];
            _tope = 0;
        }
        //propiedades 
        public int N { get; }

        public bool EstaLleno => _tope == N;
        public bool EstaVacio => _tope == 0;

        //metodos
        public void Llenar(int minimo, int maximo) { 
        
            Random random = new Random();
            for(int i =0;i<N;i++)
            {
                _arreglo[i]=random.Next(minimo, maximo);
            }
            _tope = N;

        }

        public override string ToString() 
        {
            if (  EstaVacio)
            {
                Console.WriteLine("El arreglo esta vacio");
            }
            string salida = string.Empty;
            for(int i = 0; i < N; i++)
            {
                salida += $"{_arreglo[i]}\t";
            }

            return salida;
        }

    }
}
