using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using BestRestaurant.Models;
using System;

namespace BestRestaurant.Tests
{
    [TestClass]
    public class RestaurantTests : IDisposable
    {

        public void Dispose()
        {
            Restaurant.ClearAll();
        }

        [TestMethod]
        public void RestaurantConstructor_CreatesInstanceOfRestaurant_Restaurant()
        {
            Restaurant newRestaurant = new Restaurant("test");
            Assert.AreEqual(typeof(Restaurant), newRestaurant.GetType());
        }

        [TestMethod]
        public void GetDescription_ReturnsDescription_String()
        {
            //Arrange
            string description = "Applebee";

            //Act
            Restaurant newRestaurant = new Restaurant(description);
            string result = newRestaurant.Description;

            //Assert
            Assert.AreEqual(description, result);
        }

        [TestMethod]
        public void SetDescription_SetDescription_String()
        {
            //Arrange
            string description = "Applebee";
            Restaurant newRestaurant = new Restaurant(description);

            //Act
            string updatedDescription = "KFC";
            newRestaurant.Description = updatedDescription;
            string result = newRestaurant.Description;

            //Assert
            Assert.AreEqual(updatedDescription, result);
        }

        [TestMethod]
        public void GetAll_ReturnsEmptyList_RestaurantList()
        {
            // Arrange
            List<Restaurant> newList = new List<Restaurant> { };

            // Act
            List<Restaurant> result = Restaurant.GetAll();

            // Assert
            CollectionAssert.AreEqual(newList, result);
        }

        [TestMethod]
        public void GetAll_ReturnsRestaurants_RestaurantList()
        {
            //Arrange
            string description01 = "Applebee";
            string description02 = "KFC";
            Restaurant newRestaurant1 = new Restaurant(description01);
            Restaurant newRestaurant2 = new Restaurant(description02);
            List<Restaurant> newList = new List<Restaurant> { newRestaurant1, newRestaurant2 };

            //Act
            List<Restaurant> result = Restaurant.GetAll();

            //Assert
            CollectionAssert.AreEqual(newList, result);
        }
    }
}