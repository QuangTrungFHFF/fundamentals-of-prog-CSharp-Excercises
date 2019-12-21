using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// Write a generic class GenericList<T>, which holds a list of elements of type T. 
/// Store the list of elements into an array with a limited capacity that is passed as a parameter of the constructor of the class. 
/// Add methods to add an item, to access an item by index, to remove an item by index, to insert an item at given position, 
/// to clear the list, to search for an item by value and to override the method ToString().
/// </summary>
namespace Exercise23
{
    public class GenericList<T>
    {
        private T[] elementList;        
        public int Capacity { get; set; } 
        public int Count { get; set; }
        public GenericList(int capacity)
        {
            Capacity = capacity;
            elementList = new T[Capacity];
            Count = 0;
        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            foreach(T t in elementList)
            {
                result.Append(t.ToString());
                result.Append(System.Environment.NewLine);
            }
            return result.ToString();
        }
        /// <summary>
        /// Add new element to the this
        /// </summary>
        /// <param name="element"></param>
        public void AddElement(T element)
        {
            if(this.Count>= this.Capacity)
            {
                Console.WriteLine("List capacity reached!");
            }
            else
            {
                elementList[Count] = element;
                Count++;
            }
        }
        /// <summary>
        /// Access an item T by index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public T GetElementByIndex(int index)
        {
            if(index<0||index>(Capacity-1))
            {
                throw new IndexOutOfRangeException("The index value is smaller than 0 or bigger than the list's capacity !");
            }
            if(index >(Count-1))
            {
                return default(T);
            }
            else if (index == (0)&&elementList[0]==null)
            {
                throw new ArgumentNullException("This list contains no item!");
            }
            else
            {
                return elementList[index];
            }            
        }
        public List<int> GetIndexOfElement(T element)
        {
            List<int> indexList = new List<int>();
            for(int i=0; i<Count;i++)
            {
                if(elementList[i].Equals(element) )
                {
                    indexList.Add(i);
                }
            }
            return indexList;
        }
        /// <summary>
        /// Remove an element at given index
        /// </summary>
        /// <param name="index"></param>
        public void DeleteElement(int index)
        {
            if (index < 0 || index > (Capacity - 1))
            {
                Console.WriteLine("The index value is smaller than 0 or bigger than the list's capacity !");
            }
            if(Capacity<2||Count <1)
            {
                elementList = new T[Capacity];
            }
            if (index > (Count - 1))
            {
                Console.WriteLine("There is no items on position {0}", index);
            }
            else if (index == (0) && elementList[0] == null)
            {
                Console.WriteLine("This list contains no item!");
            }
            else
            {
                for(int i = index;i<(Capacity-1);i++)
                {
                    elementList[i] = elementList[i+1];
                }
                elementList[Capacity - 1] = default(T);
                
            }
        }
        public void ClearList()
        {
            elementList = new T[Capacity];
        }
    }
}
