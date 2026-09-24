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
            _arreglo = new int[n];
            _tope = 0;
        }
        //propiedades 
        public int N { get; }

        public bool EstaLleno => _tope == N;
        public bool EstaVacio => _tope == 0;

        //metodos
        public void Llenar()
        {
            Llenar(1, 100);
        }

        //Llenar
        public void Llenar(int minimo, int maximo) {

            Random random = new Random();
            for (int i = 0; i < N; i++)
            {
                _arreglo[i] = random.Next(minimo, maximo);
            }
            _tope = N;

        }
        //Metodo Ordenar
        public void Ordenar()
        {
            Ordenar(true);

        }
        public void Ordenar(bool asendente)
        {
            for (int i = 0; i < _tope; i++)
            {
                for (int j = i + 1; j < _tope; j++)
                {
                    if (asendente)
                    {
                        if (_arreglo[i] < _arreglo[j])
                        {
                            Cambiar(ref _arreglo[i], ref _arreglo[j]);
                        }
                    }
                }
            }
        }

        //Metodo Cambiar

        public void Cambiar(ref int a, ref int b)
        {
            int auxiliar = a;
            a = b;
            b = auxiliar;
        }

        // metodo push o agregar 
        public void Agregar(int numero)
        {
            if (EstaLleno)
            {
                throw new InvalidOperationException("El arreglo esta lleno");
            }
            _arreglo[_tope] = numero;
            _tope++;
        }

        //metodo mostrar 

        public void insertar(int numero, int posicion)
        {
            if (EstaLleno)
            {
                throw new Exception("El arreglo esta lleno");
            }
           if(posicion<0)
            {
                posicion = 0;
            }
           if (posicion > _tope)
            {
                posicion = _tope;
            }
            for (int i = _tope; i > posicion; i--)
            {
                _arreglo[i] = _arreglo[i - 1];
            }
            _arreglo[posicion] = numero;
            _tope++;
        }

        //metodo eliminar
        public void Eliminar(int posicion)
        {
            if (EstaVacio)
            {
                throw new Exception("el arreglo esta vacio");
            }
            if (posicion < 0)
            {
                posicion = 0;
            }
            if (posicion > _tope)
            {
                posicion = _tope;
            }
            for(int i = posicion; i < _tope - 1; i++)
            {
                _arreglo[i] = _arreglo[i + 1];
            }
            _tope--;
        }

        //Metodo toString
        public override string ToString() 
        {
            if (  EstaVacio)
            {
                Console.WriteLine("El arreglo esta vacio");
            }
            int contador=0;
            string salida = string.Empty;
            for(int i = 0; i < _tope; i++)
            {
                salida += $"{_arreglo[i]}\t";

                if (contador > 9)
                {
                    contador = 0;   
                    salida += "\n"; 
                }
            }

            return salida;
        }

    }
}
