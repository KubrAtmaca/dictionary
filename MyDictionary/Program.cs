using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ekleyeceğiniz ürün miktarını yazınız");

            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ekleyeceğiniz ürünün seri numarasını ve ismini giriniz:");
            
            MyDictionary<int, string> myDictionary = new MyDictionary<int,string>();

            for (int i = 1; i <= x; i++)
            {
                int y = Convert.ToInt32(Console.ReadLine());
                string z = Console.ReadLine();
                myDictionary.Add(y, z);
                Console.WriteLine("{0} nolu {1} ürünü eklendi.",y,z);
                Console.WriteLine();
                if (i<x)
                {
                    Console.WriteLine("{0}. ürünü giriniz", i + 1);
                }
                
            }
        }
    }
}
