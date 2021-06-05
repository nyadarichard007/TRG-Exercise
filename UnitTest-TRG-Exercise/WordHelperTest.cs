using Microsoft.VisualStudio.TestTools.UnitTesting;
using TRG_Exercise;

namespace UnitTest_TRG_Exercise
{
    [TestClass]
    public class WordHelperTest
    {
        private WordHelper helper;

        [TestInitialize]
        public void Initialize() 
        {
            helper = new WordHelper();
        }

        [TestMethod]
        public void Word1_Is_An_Anagram_Of_Word2()
        {
            var result = helper.IsAnagram("Old West Action", "Clint Eastwood");

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Word1_Is_Not_An_Anagram_Of_Word2()
        {
            var result = helper.IsAnagram("Silence", "Silent");

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Word1_Is_A_Palindrome()
        {
            var result = helper.IsPalindrome("Anna");

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Word1_Is_Not_A_Palindrome()
        {
            var result = helper.IsPalindrome("Elbow");

            Assert.AreEqual(false, result);
        }


        [TestMethod]
        public void Sort_The_Characters_Of_The_Word_In_Ascending_Order()
        {
            var result = helper.sortedCharaters("Elbow");

            Assert.AreEqual("below", result);
        }
    }
}
