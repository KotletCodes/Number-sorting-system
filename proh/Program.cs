using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("enter amt of nums");
            int amt = Convert.ToInt32(Console.ReadLine());
            int[] list = new int[amt];
            for (int i = 0; i < amt; i++)
            {
                Console.WriteLine("enter");
                    
                list[i] = Convert.ToInt32(Console.ReadLine());

            
            
            
            }
            bool found = false;
            int temp = 0;
            while (found == false)
            {
                for (int i = 1; i < list.Length; i++)
                {
                    if (list[i ] < list[i - 1])
                    {
                        temp = list[i];
                        list[i] = list[i - 1];
                        list[i - 1] = temp;
                        
                    
                    
                    }
                    
                   



                }
                count++;
                if (count == amt -1)
                {
                    found = true;

                }

                










            }
            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine("\n");
                Console.WriteLine(list[i]);
            
            }
            Console.ReadKey();

        }
    }
}
