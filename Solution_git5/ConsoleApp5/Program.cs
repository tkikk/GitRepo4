using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeri = new int[20] { 72, 43, 55, 61, 73, 5, 43, 32, 43, 55, 11, 54, 65, 43, 73, 67, 5, 5, 73, 43 };
            int[] posizione = new int[numeri.Length];
            int A = 0;
            int ctr = 0;
            int N = 0;
            Console.WriteLine("inserisci un numero");
            A = Convert.ToInt32(Console.ReadLine());
            for (int i=0;i<20;i++)
            {
                if (A== numeri[i])
                {
                    ctr = ctr + 1;
                    posizione[N] = i;
                    N++;
                }

            }
            if (ctr > 0) ;
            {
                Console.WriteLine("il numero è uscito {0} volte", ctr);
                for (N = 0; N < ctr; N++)
                {
                    Console.WriteLine("il numero che hai inserito  è {0} e si trova nelle posizioni {1}", A, posizione[N]);
                }
                
                             
            else
            {
             Console.WriteLine("non è stata trovata alcuna corrispondenza al numero che hai selezionato");
                }
                Console.ReadLine();
                
            }

           