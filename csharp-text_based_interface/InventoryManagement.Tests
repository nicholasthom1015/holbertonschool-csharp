using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using InventoryLibrary;
using Newtonsoft.Json;

namespace InventoryManager.Tests
{
    [TestFixture]
    public class InventoryManagerTests
    {
        private const string TestDataFilePath = "testData.json";

        private JSONStorage jsonStorage;

        [SetUp]
        public void Setup()
        {
            jsonStorage = new JSONStorage(TestDataFilePath);
        }

        [TearDown]
        public void Cleanup()
        {
            if (File.Exists(TestDataFilePath))
            {
                File.Delete(TestDataFilePath);
            }
        }

        [Test]
        public void CreateObject_ShouldAddNewObjectToStorage()
        {
            // Arrange
            var item = new Item { Id = "1", Name = "Item 1" };

            // Act
            jsonStorage.New(item);
            jsonStorage.Save();
            jsonStorage.Load();
            var loadedObjects = jsonStorage.All();

            // Assert
            Assert.That(loadedObjects.ContainsKey("Item.1"), Is.True);
            Assert.That(loadedObjects["Item.1"], Is.EqualTo(item));
        }

        [Test]
        public void ShowObject_WithValidId_ShouldPrintObject()
        {
            // Arrange
            var item = new Item { Id = "1", Name = "Item 1" };
            jsonStorage.New(item);
            jsonStorage.Save();
            jsonStorage.Load();

            // Act
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                Program.ShowObject("Item", "1");
                var printedText = sw.ToString().Trim();

                // Assert
                Assert.That(printedText, Is.EqualTo("Item.1: Item 1"));
            }
        }

        [Test]
        public void ShowObject_WithInvalidId_ShouldPrintError()
        {
            // Arrange
            var item = new Item { Id = "1", Name = "Item 1" };
            jsonStorage.New(item);
            jsonStorage.Save();
            jsonStorage.Load();

            // Act
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                Program.ShowObject("Item", "2");
                var printedText = sw.ToString().Trim();

                // Assert
                Assert.That(printedText, Is.EqualTo("Object 2 could not be found"));
            }
        }

        [Test]
        public void DeleteObject_WithValidId_ShouldRemoveObjectFromStorage()
        {
            // Arrange
            var item = new Item { Id = "1", Name = "Item 1" };
            jsonStorage.New(item);
            jsonStorage.Save();
            jsonStorage.Load();

            // Act
            Program.DeleteObject("Item", "1");
            jsonStorage.Save();
            jsonStorage.Load();
            var loadedObjects = jsonStorage.All();

            // Assert
            Assert.That(loadedObjects.ContainsKey("Item.1"), Is.False);
        }

        [Test]
        public void DeleteObject_WithInvalidId_ShouldPrintError()
        {
            // Arrange
            var item = new Item { Id = "1", Name = "Item 1" };
            jsonStorage.New(item);
            jsonStorage.Save();
            jsonStorage.Load();

            // Act
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                Program.DeleteObject("Item", "2");
                var printedText = sw.ToString().Trim();

                // Assert
                Assert.That(printedText, Is.EqualTo("Object 2 could not be found"));
            }
        }
    }
}
