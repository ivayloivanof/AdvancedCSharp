#region Includes
using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using Test;

#endregion

///////////////////////////////////////////////////////////////////////////////
// Copyright 2015 (c) by Test All Rights Reserved.
//  
// Project:      
// Module:       SelectionSortTest.cs
// Description:  Tests for the Selection Sort class in the test assembly.
//  
// Date:       Author:           Comments:
// 18.7.2015 г. 22:05  Ivaylo Ivanov     Module created.
///////////////////////////////////////////////////////////////////////////////
namespace TestTest
{

    /// <summary>
    /// Tests for the Selection Sort Class
    /// Documentation: 
    /// </summary>
    [TestFixture, Description("Tests for Selection Sort")]
    public class SelectionSortTest
    {
        #region Class Variables
        private SelectionSort _selectionSort;
        #endregion

        #region Setup/Teardown

        /// <summary>
        /// Code that is run once for a suite of tests
        /// </summary>
        [TestFixtureSetUp]
        public void TestFixtureSetup()
        {

        }

        /// <summary>
        /// Code that is run once after a suite of tests has finished executing
        /// </summary>
        [TestFixtureTearDown]
        public void TestFixtureTearDown()
        {

        }

        /// <summary>
        /// Code that is run before each test
        /// </summary>
        [SetUp]
        public void Initialize()
        {
            //New instance of Selection Sort
            _selectionSort = new SelectionSort();
        }

        /// <summary>
        /// Code that is run after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
            //TODO:  Put dispose in here for _selectionSort or delete this line
        }
        #endregion

        #region Property Tests

        #region GeneratedProperties

        // No public properties were found. No tests are generated for non-public scoped properties.

        #endregion // End of GeneratedProperties

        #endregion

        #region Method Tests

        #region GeneratedMethods

        /// <summary>
        /// Main Method Test
        /// Documentation   :  
        /// Method Signature:  void Main()
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void MainTest()
        {
            DateTime methodStartTime = DateTime.Now;
            
            //Parameters

            SelectionSort.Main();

            TimeSpan methodDuration = DateTime.Now.Subtract(methodStartTime);
            Console.WriteLine(String.Format("Test.SelectionSort.Main Time Elapsed: {0}", methodDuration));
        }

        #endregion // End of GeneratedMethods

        #endregion

    }
}
