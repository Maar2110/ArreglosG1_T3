using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Recursividad.logica
{
    public class MiArreglo
    {
        //Atributos o campos
        private int _tope;
        private int[] _arreglo;

        //Constructor
        public MiArreglo(int n)
        {
            N = n;
            _arreglo = new int[N];
            _tope = 0;
        }
        //Propiedades
        public int N { get; }
        public bool EstaLleno => _tope == N;
        public bool EstaVacio => _tope == 0;

        //Métodos
        //Método Llenar
        public void Llenar(int minimo, int maximo)
        {
            Random oRandom = new Random();

            for (int i = 0; i < N; i++)
            {
                _arreglo[i] = oRandom.Next(minimo, maximo);

            }
            _tope = N;

        }

        
    }
}