using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise23;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise23.Tests
{
    [TestClass()]
    public class GenericListTests
    {
        [TestMethod(), Description("Create new array list, add elements to the list using AddElement(), compare with expected array list")]
        public void AddElementTest()
        {
            //Arrange
            int[] expectedResult = new int[7] { 14, 17, 2, 5, 1, 98, 0 };
            GenericList<int> intergerArray = new GenericList<int>(7);
            //Act
            intergerArray.AddElement(14);
            intergerArray.AddElement(17);
            intergerArray.AddElement(2);
            intergerArray.AddElement(5);
            intergerArray.AddElement(1);
            intergerArray.AddElement(98);
            //Assert
            CollectionAssert.AreEqual(expectedResult, intergerArray.ElementList);
        }

        [TestMethod(), Description("Create new array list, add elements to the list using AddElement(), remove element at index 3, compare with expected array list")]
        public void DeleteElementTest()
        {
            //Arrange
            int[] expectedResult = new int[7] { 14, 17, 2, 1, 98, 0, 0 };
            GenericList<int> intergerArray = new GenericList<int>(7);
            //Act
            intergerArray.AddElement(14);
            intergerArray.AddElement(17);
            intergerArray.AddElement(2);
            intergerArray.AddElement(5);
            intergerArray.AddElement(1);
            intergerArray.AddElement(98);
            intergerArray.DeleteElement(3);
            // Assert
            CollectionAssert.AreEqual(expectedResult, intergerArray.ElementList);
        }

        [TestMethod(), Description("Create new array list, insert new elements to the list at index 3, compare with expected array list")]
        public void InsertElementAtGivenIndexTest()
        {
            //Arrange
            int[] expectedResult = new int[7] { 14, 17, 2, 99, 5, 1, 98 };
            GenericList<int> intergerArray = new GenericList<int>(7);            
            intergerArray.AddElement(14);
            intergerArray.AddElement(17);
            intergerArray.AddElement(2);
            intergerArray.AddElement(5);
            intergerArray.AddElement(1);
            intergerArray.AddElement(98);
            //Act
            intergerArray.InsertElementAtGivenIndex(99, 3);
            // Assert
            CollectionAssert.AreEqual(expectedResult, intergerArray.ElementList);
        }

        [TestMethod(), Description("Create new array list, search and return element at index 3, compare with expected result")]
        public void GetElementByIndexTest()
        {
            //Arrange            
            GenericList<int> intergerArray = new GenericList<int>(7) ;
            intergerArray.AddElement(14);
            intergerArray.AddElement(17);
            intergerArray.AddElement(2);
            intergerArray.AddElement(5);
            intergerArray.AddElement(1);
            intergerArray.AddElement(98);
            //Act
            int result = intergerArray.GetElementByIndex(3);
            // Assert
            Assert.AreEqual(5, result);
        }
    }
}