using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sandbox;

namespace CustomListTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_AddingOneValueToEmptyCustomList_AddedValueGoesToIndexZero()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 10;
            int expected = 10;
            int actual;

            // act
            testList.Add(itemToAdd);
            actual = testList[0];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddingOneValueToEmptyCustomList_CountOfCustomListIncrements()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 10;
            int expected = 1;
            int actual;

            // act
            testList.Add(itemToAdd);
            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_AddingToACustomListThatHasMultipleValues_CountOfCustomListIncrements()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 10;
            int itemToAddTwo = 15;
            int expected = 2;
            int actual;

            // act
            testList.Add(itemToAdd);
            testList.Add(itemToAddTwo);
            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_AddingMoreItemsThanCapacityOfTheCustomList_CapacityOfTheCustomListIncrementsByFour()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 10;
            int itemToAddTwo = 15;
            int itemToAddThree = 11;
            int itemToAddFour = 5;
            int itemToAddFive = 18;
            int expected = 8;
            int actual;

            // act
            testList.Add(itemToAdd);
            testList.Add(itemToAddTwo);
            testList.Add(itemToAddThree);
            testList.Add(itemToAddFour);
            testList.Add(itemToAddFive);
            actual = testList.Capacity;

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_AddingFiveItemsThanCapacityOfTheCustomList_CheckCapacity()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 10;
            int itemToAddTwo = 15;
            int itemToAddThree = 11;
            int itemToAddFour = 5;
            int itemToAddFive = 18;
            int expected = 8;
            int actual;

            // act
            testList.Add(itemToAdd);
            testList.Add(itemToAddTwo);
            testList.Add(itemToAddThree);
            testList.Add(itemToAddFour);
            testList.Add(itemToAddFive);
            actual = testList.Capacity;

            // assert
            Assert.AreEqual(expected, actual);
        }

        // what happens if you add multiple things (or add to a CustomList that already has some values)?
        // what happens to the last-added item?
        // what happens to the Count?

        // what happens if you add more items than the initial Capacity of the CustomList?
        [TestMethod]
        public void Remove_RemovingDuplicateValuesFromCustomList_ValueOfTwoIndexStaysTheSame()
        {
            // arrange
            CustomList<string> testList = new CustomList<string>(); // Creating a list that holds strings

            string expected = "Earth";
            string actual;

            // act
            testList.Add("Sun");		// Adding the value "Sun"
            testList.Add("Moon");		// Adding the value "Moon"
            testList.Add("Earth");		// Adding the value "Earth"
            testList.Add("Moon");       // Adding the value "Moon" for the second time

            // Currently our list holds the values: "Sun", "Moon", "Earth", "Moon"
            // Currently our list has a count of: 4

            testList.Remove("Moon");    // Calling the Remove method to remove the first "Moon" in the list

            // Assuming the remove method worked we expect:
            // Our list to now hold the values: "Sun", "Earth", "Moon"
            // Our list to now have a count of: 3

            actual = testList[2]; // Grabbing the value at index 2, which now should be "Moon"

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_RemovingTenValueFromCustomList_CountBecomesOne()
        {
            
            CustomList<string> testList = new CustomList<string>(); 

            int expected = 1;
            int actual;

            // act
            testList.Add("0");
            testList.Add("1");
            testList.Add("2");
            testList.Add("3");		
            testList.Add("4");		
            testList.Add("5");		
            testList.Add("6");		
            testList.Add("7");		
            testList.Add("8");		
            testList.Add("9");		
            testList.Add("10");


            testList.Remove("0");
            testList.Remove("2");
            testList.Remove("3");
            testList.Remove("4");
            testList.Remove("5");
            testList.Remove("6");
            testList.Remove("7");
            testList.Remove("8");
            testList.Remove("9");
            testList.Remove("10");

            actual = testList.Count; 

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_RemovingAllValuesFromCustomList_CustomListCountGoesToZero()
        {
            
            CustomList<string> testList = new CustomList<string>(); 

            int expected = 0;
            int actual;

            // act
            testList.Add("Sun");		
            testList.Add("Moon");		
            testList.Add("Earth");		
            testList.Add("Moon");                      

            testList.Remove("Sun");    
            testList.Remove("Moon");    
            testList.Remove("Earth");    
            testList.Remove("Moon");    
          
            actual = testList.Count; 

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_RemovingAllValuesFromCustomListExceptOne_CountBecomesOne()
        {
            
            CustomList<string> testList = new CustomList<string>(); 

            int expected = 1;
            int actual;

            // act
            testList.Add("Sun");		
            testList.Add("Moon");		
            testList.Add("Earth");		
            testList.Add("Moon");                      

            testList.Remove("Moon");    
            testList.Remove("Earth");
            testList.Remove("Moon");

            actual = testList.Count; 

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_RemovingTwoValuesFromCustomList_CountBecomesTwo()
        {
            
            CustomList<string> testList = new CustomList<string>(); 

            int expected = 2;
            int actual;

            // act
            testList.Add("Sun");		
            testList.Add("Moon");		
            testList.Add("Earth");		
            testList.Add("Moon");                      

            testList.Remove("Sun");    
            testList.Remove("Moon");    
          
            actual = testList.Count; 

            // assert
            Assert.AreEqual(expected, actual);
        }

    }
}
