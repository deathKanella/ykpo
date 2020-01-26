using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void testHashInsert()
        {
            var hashTable = new HashTable();
            hashTable.Insert("1", "Little Prince");
            hashTable.Insert("2", "Fox");
            hashTable.Insert("3", "Rose");
            hashTable.Insert("4", "King");
        }
    }
}
