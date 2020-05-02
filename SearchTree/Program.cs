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
        }
    }
}
