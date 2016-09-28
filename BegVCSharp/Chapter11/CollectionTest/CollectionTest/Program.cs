using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList1 = new ArrayList(2);
            ArrayList arrayList2 = new ArrayList();
            string[] array = new string[1];
            arrayList1.Add("first");
            arrayList1.Add(" ");
            arrayList1.Add(" ");
            arrayList1.AddRange(array);
            arrayList2.Add(1);
            Console.WriteLine(arrayList1.Count);
            Console.WriteLine(arrayList2.Count);
            Console.ReadKey();
        }
    }
}
