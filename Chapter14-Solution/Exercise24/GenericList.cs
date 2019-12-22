using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// Implement auto-resizing functionality of the array from the previous task, when by adding an element, it reaches the capacity of the array.
/// </summary>
namespace Exercise24
{
    public class GenericList<T>
    {
        private const int _defaultCapacity = 4;
        private T[] elementList; 
        
        public T[] ElementList
        {
            get { return elementList; }
            set { elementList = value; }
        }
        public T[] ElementListTemp { get; set; }
        public int Capacity { get; set; } 
        public int Count { get; set; }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="capacity"></param>
        public GenericList(int capacity)
        {
            if(capacity < _defaultCapacity)
            {
                Capacity = _defaultCapacity;
            }
            else
            {
                Capacity = capacity;
            }            
            elementList = new T[Capacity];
            Count = 0;
        }
        /// <summary>
        /// Default List of array
        /// </summary>
        public GenericList()
        {
            elementList = new T[_defaultCapacity];
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
            if (this.Count >= this.Capacity)
            {
                ElementListTemp = ElementList;
                ElementList = new T[Capacity + 1];
                for (int i = 0; i < Capacity; i++)
                {
                    ElementList[i] = ElementListTemp[i];
                }
                ElementList[Capacity] = element;
            }
            else
            {
                ElementList[Count] = element;
            }

                Count++;
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
        /// <summary>
        /// Insert an Element at Given Index
        /// </summary>
        /// <param name="element"></param>
        /// <param name="index"></param>
        public void InsertElementAtGivenIndex(T element, int index)
        {
            if(Count >= Capacity)
            {
                ElementListTemp = ElementList;
                ElementList = new T[Capacity + 1];
                for(int i =0;i<index;i++)
                {
                    ElementList[i] = ElementListTemp[i];
                }
                ElementList[index] = element;
                for(int i = index+1;i<(Capacity+1);i++)
                {
                    ElementList[i] = ElementListTemp[i - 1];
                }
            }
            else
            {
                for(int i = (Capacity-1); i>index;i--)
                {
                    elementList[i] = elementList[i - 1];
                }
                elementList[index] = element;
            }
        }
        public void ClearList()
        {
            elementList = new T[Capacity];
        }
    }
}
