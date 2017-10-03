using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Tests
{
    [TestClass]
    public class CustomListTests
    {

        //ADDING
        
        [TestMethod]
        public void Add()
        {
            //Arrange
            int expected = 16;
            CustomList<int> list = new CustomList<int>();

            //Act
            list.Add(expected);
            // int actual = list.ElementAt(0);
            int actual = list[0];

            //Assert
            Assert.AreEqual(expected, actual); 
        }

        [TestMethod]
        public void AddTwoNumbers() //Passes but loses first index[0]
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int firstNum = 16;
            int secondNum = 8;

            //Act
            list.Add(firstNum);
            list.Add(secondNum);


            //Assert
            Assert.AreEqual(secondNum, list.ElementAt(1));
        }

        //[TestMethod]
        //public void AddMoreNumbers()
        //{
        //    //Arrange 
        //    CustomList<int> list = new CustomList<int>();
        //    int num = 16;
        //    int num1 = 8;
        //    int num2 = -4;
        //    int num3 = 24;
        //    int num4 = 32;
        //    int num5 = 40;
        //    int num6 = 48;
        //    int num7 = 1;
        //    int num8 = 2;
        //    int num9 = 3;
        //    int num10 = 6;
        //    int num11 = 12;
        //    int num12 = 18;
        //    int num13 = 24;
        //    int num14 = 30;
        //    int num15 = 36;
        //    int num16 = 42;

        //    //Act
        //    list.Add(num);
        //    list.Add(num1);
        //    list.Add(num2);
        //    list.Add(num3);
        //    list.Add(num4);
        //    list.Add(num5);
        //    list.Add(num6);
        //    list.Add(num7);
        //    list.Add(num8);
        //    list.Add(num9);
        //    list.Add(num10);
        //    list.Add(num11);
        //    list.Add(num12);
        //    list.Add(num13);
        //    list.Add(num14);
        //    list.Add(num15);
        //    list.Add(num16);

        //    //Assert
        //    Assert.AreEqual(num16, list.ElementAt(16));
        //}

        //[TestMethod]
        //public void AddStringItem()
        //{
        //    //Arrange
        //    CustomList<string> stringList = new CustomList<string>();
        //    string index0 = "Why";

        //    //Act
        //    stringList.Add(index0);

        //    //Assert
        //    Assert.AreEqual(index0, stringList.ElementAt(0)); // indexing issue

        //}


        //[TestMethod]
        //public void IncreaseCapacity()
        //{
        //    //Arrange
        //    CustomList<int> list = new CustomList<int>();
        //    //CustomList<int> list = new CustomList<int>() { 1, 2, 3 }; adds these 3 items to list
        //    int value = 8;
        //    int value1 = 10;
        //    int value2 = 15;
        //    int value3 = 12;
        //    int value4 = 39; //new count = 5, need to increase capacity - it will be 8
        //    int expected = 8;

        //    //Act
        //    list.Add(value);
        //list.Add(value1);
        //    list.Add(value2);
        //    list.Add(value3);
        //    list.Add(value4);

        //    //Assert
        //    Assert.AreEqual(expected, list.capacity); 
        //}

        ////REMOVING

        //[TestMethod]
        //public void RemoveOneNumber() //remove
        //{
        //    //Arrange
        //    CustomList<int> list = new CustomList<int>();
        //    int value = 8;
        //    int value1 = 10;
        //    int value2 = 15;
        //    int value3 = 12;
        //    int value4 = 39;

        //    //Act
        //    list.Add(value);
        //    list.Add(value1);
        //    list.Add(value2);
        //    list.Add(value3);
        //    list.Add(value4);
        //    list.Remove(value); 

        //    //Assert
        //    Assert.AreEqual(value1, list.ElementAt(0)); 
        //}

        //[TestMethod]
        //public void RemoveMultiple()
        //{
        //    //Arrange
        //    CustomList<int> list = new CustomList<int>();
        //    int num = 4;
        //    int num1 = 9;
        //    int num2 = 13;
        //    int num3 = 22;
        //    int num4 = 35;
        //    int num5 = 57;

        //    //Act
        //    list.Add(num);
        //    list.Add(num1);
        //    list.Add(num2);
        //    list.Add(num3);
        //    list.Add(num4);
        //    list.Add(num5);
        //    list.Remove(num); 
        //    list.Remove(num3); 


        //    //Assert
        //    Assert.AreEqual(num5, list.ElementAt(3)); 
        //}

        //[TestMethod]
        //public void RemoveStringItem()
        //{
        //    //Arrange
        //    CustomList<string> stringList = new CustomList<string>();
        //    string index0 = "Why";
        //    string index1 = "are";
        //    string index2 = "you";
        //    string index3 = "doing";
        //    string index4 = "this";
        //    string index5 = "?";
        //    stringList.Add(index0);
        //    stringList.Add(index1);
        //    stringList.Add(index2);
        //    stringList.Add(index3);
        //    stringList.Add(index4);
        //    stringList.Add(index5);

        //    //Act
        //    stringList.Remove(index3); //remove method issue

        //    //Assert
        //    Assert.AreEqual(index4, stringList.ElementAt(3)); //indexing issue

        //}

        ////OVERRIDE .TOSTRING

        ////[TestMethod]
        ////public void OverrideToString() // TODO: need arguments/parameters
        ////{
        ////    //Arrange
        ////    CustomList<string> createString = new CustomList<string>();
        ////    string start = "Hello, it's ";
        ////    int time = 12;
        ////    string end = "o'clock.";
        ////    string expected = start + " " + time + " " + end + ".";

        ////    //Act
        ////    string actual = createString.ToString(start, time, end); 

        ////    //Assert
        ////    Assert.AreEqual(expected, actual);
        ////}

        ////[TestMethod]
        ////public void checkString()
        ////{
        ////    //Arrange
        ////    CustomList<string> createString = new CustomList<string>();
        ////    string start = "Hello, it's ";
        ////    int time = 12;
        ////    string end = "o'clock.";
        ////    string expected = start + " " + time + " " + end + ".";

        ////    //Act
        ////    string actual = createString.ToString(start, time, end); // StringOverride issue

        ////    //Assert
        ////    Assert.AreNotEqual(time, actual[1]);
        ////}


    }
}

