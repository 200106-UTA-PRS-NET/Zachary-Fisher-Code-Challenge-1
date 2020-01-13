using Microsoft.VisualStudio.TestTools.UnitTesting;
using PallindromeTestLib;


namespace PalindromeTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestReverse()
        {
            
            //Arrange
            string s = "hello world";
            string r = "dlrow olleh";
            TestPalindrome p = new TestPalindrome();
            //Act
            s = p.Reverse(s);
            //Assert
            Assert.AreEqual(r, s);
        }
        [TestMethod]
        public void TestPrepare()
        {
            //Arrange
            string s = "Welcome, to the game.";
            string e = "welcometothegame";
            TestPalindrome p = new TestPalindrome();
            //Act
            s = p.Prepare(s);
            //Assert
            Assert.AreEqual(e, s);
        }
        [TestMethod]
        public void TestTrue()
        {
            //Arrange
            string s = "nurses run";
            TestPalindrome p = new TestPalindrome();
            //Act
            bool pal = p.TestPal(s);
            //Assert
            Assert.IsTrue(pal);
        }
        [TestMethod]
        public void TestTrue2()
        {
            //Arrange
            string s = "racecaR";
            TestPalindrome p = new TestPalindrome();
            //Act
            bool pal = p.TestPal(s);
            //Assert
            Assert.IsTrue(pal);
        }
        [TestMethod]
        public void TestTrue3()
        {
            //Arrange
            string s = "1221";
            TestPalindrome p = new TestPalindrome();
            //Act
            bool pal = p.TestPal(s);
            //Assert
            Assert.IsTrue(pal);
        }
        [TestMethod]
        public void TestTrue4()
        {
            //Arrange
            string s = "never odd, or even.";
            TestPalindrome p = new TestPalindrome();
            //Act
            bool pal = p.TestPal(s);
            //Assert
            Assert.IsTrue(pal);
        }
        [TestMethod]
        public void TestFalse1()
        {
            //Arrange
            string s = "one two one";
            TestPalindrome p = new TestPalindrome();
            //Act
            bool pal = p.TestPal(s);
            //Assert
            Assert.IsFalse(pal);
        }
        [TestMethod]
        public void TestFalse2()
        {
            //Arrange
            string s = "123abccba123";
            TestPalindrome p = new TestPalindrome();
            //Act
            bool pal = p.TestPal(s);
            //Assert
            Assert.IsFalse(pal);
        }
    }
}
