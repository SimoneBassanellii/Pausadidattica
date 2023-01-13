using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pausadidattica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[100];
            int b, c;
            c = 0;

            Console.WriteLine("Inserire numero di elementi da inserire nell'array");
            b = Convert.ToInt32(Console.ReadLine());
            Funzione1(args, b, c);
            
        }

        //Aggiungere in coda un elemento all'array (interi)
        public static void Funzione1(string[] args, int b, int c )
        {
            for (int i = 0; i < b; i++)
            {
                Console.WriteLine("Inserire l'elemento");
                c = Convert.ToInt32(Console.ReadLine());    
            }
        }

        //Visualizzazione dell'array che restituisca la stringa in HTML
        public static void Funzione2(string[] args)
        {

        }

        //Ricerca un numero all'interno dell'array, la funzione deve restituire la posizione dell'elemento se lo trova, -1 se non lo trova;
        public static void Funzione3(string[] args)
        {

        }

        //Cancellazione di un elemento dell'array
        public static void Funzione4(string[] args)
        {

        }

        //Inserimento di un valore in una posizione dell'array
        public static void Funzione5(string[] args)
        {

        }
    }
}
