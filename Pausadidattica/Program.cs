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
            int[] arr = new int[100];
            int b, nel, e;
            int dim = 0;
            nel = 0;
            int scelta = 0;

            //Struttura menù
            do
            {
                //stampa delle opzioni
                Console.Clear(); 
                Console.WriteLine("1 - Aggiungi elemento");
                Console.WriteLine("2 - Stampa elementi caricati");
                Console.WriteLine("0 - uscità");
                //scelta delle opzioni 
                scelta = int.Parse(Console.ReadLine());
                //esecuzione opzioni 
                switch (scelta)
                {
                    case 1:
                        Console.WriteLine($"Inserisci l'elemento ");
                        int ele = int.Parse(Console.ReadLine());
                        AddArray(arr, ele, ref dim);
                        if( AddArray(arr, ele, ref dim) == true )
                        {
                            Console.WriteLine("Eleneto inseriro correttamente");
                        }
                        else
                        {
                            Console.WriteLine("Array pieno");
                        }
                        break;

                    case 2:
                        for (int i = 0; i < dim; i++)
                        {
                            Console.WriteLine(arr[i]);
                        }
                        Console.ReadLine();
                        break;
                }
                Console.ReadLine();
            }
            while (scelta != 0);
            
            Console.WriteLine("Elementi da caricare");
            nel = int.Parse(Console.ReadLine());
        }

        //Aggiungere in coda un elemento all'array (interi)
        static bool AddArray(int[] a, int e,ref int index)
        {
            //Controllo se abbiamo raggiunto la dimensione massima
            bool inserito = true;
            if (index < a.Length)
            {
                //Aggiunta di un elemento
                a[index] = e;
                //incrementare l'indice 
                index++;
            }
            else
                inserito = false;

            return inserito;
        }

        //Visualizzazione dell'array che restituisca la stringa in HTML
        public static void Funzione2(string[] args)
        {
            
        }

        //Ricerca un numero all'interno dell'array, la funzione deve restituire la posizione dell'elemento se lo trova, -1 se non lo trova;
        public static int FunzioneRicerca(int[] a, int chiave)
        {
            int occorrenze = 0;
            for (int i = 0; i < 100; i++)
                if (a[i] == chiave)
                    occorrenze++;
            return occorrenze;
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
