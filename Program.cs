using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAppend
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> chain = new List<string>();

            var block = new Dictionary<string, string>();
            block.Add("Olive", "kem");
            block.Add("Kemei", "skinny");
            block.Add("Tim","Corey");

            foreach (var item in block)
            {
                Console.WriteLine(item.Key+ ":" + item.Value);
            }
            

            
            
            Console.ReadKey();
        }
    }
}
