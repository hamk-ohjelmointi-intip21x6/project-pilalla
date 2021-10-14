using System;

namespace Ylityökorvaukset
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ylityökorvaustenmäärä");
            Console.WriteLine("Anna työntekijän ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Ylityökorvaustenmäärä[] määrä = new Ylityökorvaustenmäärä[id];

            for (int i = 0; i < id; i++)
            {
                määrä[i] = new Ylityökorvaustenmäärä();
                Console.WriteLine("ID : {0}", i+1);

                Console.WriteLine("Nimi :");
                määrä[i].Nimi = Console.ReadLine();

                Console.WriteLine("Kuukausi :");
                määrä[i].Kuukausi = Console.ReadLine();

                Console.WriteLine("Vuosi :");
                määrä[i].Vuosi = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ylityökorvaukset :");
                määrä[i].Ylityökorvaukset = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("Työntekijän ID\tNimi\tKuukausi\tVuosi\tYlityökorvaustenmäärä");
            Console.WriteLine("............................................................");

            for (int i = 0; i <id; i++ )
            {
                Console.WriteLine("\t {0}\t{1}\t{2}\t{3}\t{4}", i + 1, määrä[i].Nimi, määrä[i].Kuukausi, määrä[i].Vuosi, määrä[i].Ylityökorvaukset);
            }
            Console.ReadLine();

        }
    }
}
