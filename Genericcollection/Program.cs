using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Genericcollection
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
            //GENERIC --SYSTEM.COLLECTION.GENERIC
            List<int> mylists=new List<int>();

            //adding values tolist
            mylists.Add(1);
            mylists.Add(2);
            mylists.Add(3);
            mylists.Add(4);
            //traversing through the list 
            foreach (int i in mylists)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }*/

            //DICTIONARY
            Dictionary<int, string> mydicts=new Dictionary<int, string>();
            //adding values
            mydicts.Add(1, "reji");
            mydicts.Add(2, "wer");
            
            foreach(KeyValue
                Pair<int, string> kvp in mydicts)
            {
                Console.WriteLine(kvp.Key);
                Console.WriteLine(kvp.Value);

            }


    }

    }
}
