using System;

namespace Exercise11
{
    /// <summary>
    /// Define TreeMultiSet<T> class, which allows to keep a set of elements,
    /// in increasing order and to have duplicates of the elements.
    /// Implement operations adding of element, finding the number of occurrences,
    /// deletion, iterator, min / max element finding, min / max deletion.
    /// </summary>
    class TestProgram
    {
        static void Main(string[] args)
        {
            //Add new items to the set
            TreeMultySet<string> treeSet = new TreeMultySet<string>();
            treeSet.Add("House");
            treeSet.Add("House");
            treeSet.Add("Bee");
            treeSet.Add("House");
            treeSet.Add("Apple");
            treeSet.Add("House");
            treeSet.Add("Bee");
            treeSet.Add("House");
            treeSet.Add("House");
            treeSet.Add("Horse");
            treeSet.Add("Horse");
            treeSet.Add("Car");
            treeSet.PrintTree();
            //Delete items 
            treeSet.Delete("Bee");
            treeSet.Add("Obama");
            treeSet.PrintTree();
            //Delete first and last item in this sorted set
            treeSet.DeleteMin();
            treeSet.DeleteMax();
            treeSet.PrintTree();

        }
    }
}
