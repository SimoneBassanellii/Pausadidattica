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
            int nel, h;
            int dim = 0;
            nel = 0;
            int scelta = 0;
            h = 0;

            //Struttura menù
            do
            {
                //stampa delle opzioni
                Console.Clear();
                Console.WriteLine("1 - Aggiungi elemento");
                Console.WriteLine("2 - Stampa elementi caricati");
                Console.WriteLine("3 - Visualizzazione array in HTML");
                Console.WriteLine("4 - Cancellamento elemento array");
                Console.WriteLine("5 - Inserimento di un valore in una posizione dell'array");
                Console.WriteLine("0 - Uscità");
                //scelta delle opzioni 
                scelta = int.Parse(Console.ReadLine());
                //esecuzione opzioni 
                switch (scelta)
                {
                    case 1:
                        Console.WriteLine($"Inserisci l'elemento ");
                        int ele = int.Parse(Console.ReadLine());
                        AddArray(arr, ele, ref dim);
                        if (AddArray(arr, ele, ref dim) == true)
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

                    case 3:
                        Console.WriteLine("Elemento da cercare: ");
                        int l = int.Parse(Console.ReadLine());
                        if (Funzionericerca(arr, l, h) == true)
                        {
                            Console.WriteLine("Elemento presente, posizione numero: " + h);
                        }
                        else
                        {
                            Console.WriteLine("Elemento non presente nell'array, -1 ");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Elemento da eliminare: ");
                        int c = int.Parse(Console.ReadLine());
                        if (Eleminazionelemento(arr, c) == true)
                        {
                            Console.WriteLine("Valore eliminato");
                        }
                        else
                        {
                            Console.WriteLine("Errore valore non trovato in quanto non presente");
                        }
                        break;

                }
                Console.ReadLine();
            }
            while (scelta != 0);

            Console.WriteLine("Elementi da caricare");
            nel = int.Parse(Console.ReadLine());
        }

        //Aggiungere in coda un elemento all'array (interi)
        static bool AddArray(int[] a, int e, ref int index)
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
        static bool Funzionericerca(int[] a, int l, int h)
        {
            bool selezionato = true;
            //ricerca nell'array 
            for (int i = 0; i < a.Length; i++)
            {

                //Confronto singolo elemento 
                if (l == a[i])
                {
                    h = i;
                    return selezionato;
                }
                else
                {
                    selezionato = false;
                }
            }
            return selezionato;
        }

        //Cancellazione di un elemento dell'array
        static bool Eleminazionelemento(int[] a, int c)
        {
            bool selezionato = true;
            //ricerca nell'array 
            for (int i = 0; i < a.Length; i++)
            {
                if (c == a[i])
                {
                    //Se l'elemento è contenuto nell'array lo vado ad eliminare
                    a[i] = a[i] - c;
                    return selezionato;
                }
                else
                {
                    selezionato = false;
                }
                return selezionato;
            }
        }

        //Inserimento di un valore in una posizione dell'array
        public static void Funzione5(string[] args)
        {

        }
    }
}
