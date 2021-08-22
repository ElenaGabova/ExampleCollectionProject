using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleCollectionClass
{
    class Program
    {
        static void Main(string[] args)
        {
            CollectionClass<int> intCollection = new CollectionClass<int> {
                                                                                Collection = new List<int> { 1, 2, 3, 10 }
                                                                          };

            intCollection.AddElement(4);
            intCollection.DeleteElement(1);

            Console.WriteLine("Количество элементов обобщенного массива: " + intCollection.Count().ToString());
            Console.WriteLine("Элементы обобщенного массива: " + intCollection.ToString());


            CollectionClass<string> stringCollection = new CollectionClass<string>
            {
                Collection = new List<string> { "1", "2", "3", "10", "4 элемент" }
            };

            Console.WriteLine();
            Console.WriteLine("Количество элементов обобщенного массива: " + stringCollection.Count().ToString());
            Console.WriteLine("Элементы обобщенного массива: " + stringCollection.ToString());

            stringCollection.Collection[0] = "1 элемент";
            Console.WriteLine("Элементы обобщенного массива после замены 1 элмента: " + stringCollection.ToString());

            Console.ReadLine();
        }
    }
}
