using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace find_index
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string[] Myarray = { "Ali", "Veli", "Ali", "Ahmet", "Mehmet", "Ali", "Zehra", "Fatma", "Ayşe", "Ali" };

            Console.WriteLine("Enter the name you want to search : ");
            string input = Console.ReadLine();

            bool check = false;


            for (int i = 0; i < Myarray.Length; i++)
            {
                if (Myarray[i] == input)
                {
                    Console.WriteLine($"Index No : {i}", i);
                    check = true;
                }
            }
            if (check == false)
            {
                Console.WriteLine("This Name does not exist");
            }

            Console.ReadLine();






        }
    }
}

