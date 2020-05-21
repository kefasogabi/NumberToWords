using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension
{
    class Program
    {
        static void Main(string[] args)
        {
            string more = "yes";
            Int64 number;

            try
            {
                while (more == "yes")
                {
                    Console.Write("Please enter a number to convert to words: ");
                    number = Convert.ToInt64(Console.ReadLine());
                    var ext = new Ext();
                    Console.WriteLine(ext.ToWords(number));
                    Console.Write("do you want to convert again? (Yes/No): ");
                    more = Convert.ToString(Console.ReadLine()).ToLower();
                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();

        }
    }
}
