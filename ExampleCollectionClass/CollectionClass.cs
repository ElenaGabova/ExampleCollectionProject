using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleCollectionClass
{
    /* Обобщенный класс, который может хранить объекты любого типа.
     * В классе реализованы:
     * 1. метод для добавления данных в список
     * 2. метод удаления из список
     * 3. метод получения элемента из списка по индексу 
     * 4. метод, возвращающий длину списка.
     * */
    class CollectionClass<Type>
    {
        public List<Type> Collection { get; set; } = new List<Type>();

        public int Count()
        {
            return Collection.Count;
        }

        public CollectionClass(params Type[] elements)
        {
            foreach (var element in elements)
                Collection.Add(element);
        }

        public void AddElement(Type element)
        {
            Collection.Add(element);
        }

        public void DeleteElement(Type element)
        {
            Collection.Remove(element);
        }

        public override string ToString()
        {
            string result = "";
            foreach (var element in Collection) { 
                    result += element.ToString() + ", ";
            }
            return result;
        }

        public Type this[int index]
        {
            get
            {
                return Collection[index];
            }
            set
            {
                Collection[index] = value;
            }
        }
    }
}
