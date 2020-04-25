using System;
using System.Collections.Generic;
using System.Linq;

namespace Enunciado01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> ladoDerecho = new List<String>
            {
                "A", "B", "C", "D"
            };
            State estadoInicial = new State(ladoDerecho, new List<String>(), true, 0);
            BFS BreadthFirstSearch = new BFS(); // CREAR LA BÚSQUEDA POR ANCHURA
            State estadoFinal = BreadthFirstSearch.BreadthFirstSearch(estadoInicial);

            // MOSTRAR ESTADO INICIAL
            Console.WriteLine("Estado Inicial");
            Console.WriteLine("Personas Izquierda: ");
            Console.WriteLine("Personas Derecha: ");
            foreach(String str in estadoInicial.LadoDerecha)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine("Minutos: " + estadoInicial.MinutosAcumulados.ToString());
            Console.WriteLine("Farola: DERECHA");
            Console.Write("--------------------------------\n\n");

            // MOSTRAR PASOS (RECORRIDO)
            Console.WriteLine(estadoFinal.ObtenerRecorrido());
        }
    }
}
