using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int sayi = random.Next(0, 11);
            int sayi1, sayac = 0;
            do
            {
                Console.WriteLine("bir sayı tahmin ediniz: ");
                sayi1 = Convert.ToInt32(Console.ReadLine());
                if (sayi < sayi1)
                {
                    Console.WriteLine("daha alçak");
                }
                else if(sayi > sayi1)
                {
                    Console.WriteLine("daha yüksek");
                }
            sayac++;

            } while (sayi != sayi1);

            Console.WriteLine("{0} . denemede bildiniz",sayac);
            

















        }
    }
}
