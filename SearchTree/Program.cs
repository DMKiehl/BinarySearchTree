using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            SearchTree search = new SearchTree();
            search.Add(100);
            search.Add(105);
            search.Add(85);
            search.Add(75);
            search.Add(110);
            search.Add(101);
            search.Add(99);

            bool result = search.Search(60);
            if(result == true)
            {

                Console.WriteLine("Number has been found");
                Console.ReadLine();
            }
                
            else
            {
                Console.WriteLine("Number has not been found");
                Console.ReadLine();
            }
        }
    }
}
