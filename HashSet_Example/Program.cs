using System;
using System.Collections.Generic;

namespace HashSet_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> myHashSet = new HashSet<string>();
            myHashSet.Add("first element");
            //myHashSet.Add("first element"); --no error but no duplicate elements
            myHashSet.Add("second element");

            HashSet<string> anotherHashSet = new HashSet<string>();
            anotherHashSet.Add("new element from another hash set");
            anotherHashSet.Add("second element");
            // anotherHashSet.Add("new element from another hash Set"); --different string

            //anotherHashSet.UnionWith(myHashSet);
            //anotherHashSet.IntersectWith(myHashSet);

            foreach (var item in anotherHashSet)
            {
                Console.WriteLine(item);
            }
        }
    }
}
