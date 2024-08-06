namespace TestProject
{
    public class Tests
    {
        NumericFunctions.NumericFunctions numericFunctions;

        [SetUp]
        public void Setup()
        { 
        numericFunctions = new NumericFunctions.NumericFunctions();
        }

        [Test]
        public void AddTest1()
        {
            // AAA 
            // A> Arrange
            // A> Act
            // A> Assert

            // Arrange > create instance of class 
            //NumericFunctions.NumericFunctions numericFunctions = new NumericFunctions.NumericFunctions();

            // Act > make call to the function that we have to test

            int actual = numericFunctions.Add(10, 20);

            // Assert > to check whether test has passed or faile

            Assert.AreEqual(30, actual);

        }



        [Test]
        public void AddTest2()
        {
            // AAA 
            // A> Arrange
            // A> Act
            // A> Assert

            // Arrange > create instance of class 
            //NumericFunctions.NumericFunctions numericFunctions = new NumericFunctions.NumericFunctions();

            // Act > make call to the function that we have to test

            int actual = numericFunctions.Add(11, 20);

            // Assert > to check whether test has passed or faile

            Assert.AreEqual(31, actual);

        }


        [Test]
        public void AddTest3()
        { 
            // AAA 
            // A> Arrange
            // A> Act
            // A> Assert

            // Arrange > create instance of class 
            //NumericFunctions.NumericFunctions numericFunctions = new NumericFunctions.NumericFunctions();

            // Act > make call to the function that we have to test

            int actual = numericFunctions.Add(1, 20);

            // Assert > to check whether test has passed or faile

            Assert.AreEqual(30, actual);

        }

        [TestCase(1, 1, 2)]
        [TestCase(12, 12, 24)]
        [TestCase(13, 13, 26)]
        [TestCase(0, 0, 0)]
        public void AddTest(int x, int y, int exptected)
        {
            NumericFunctions.NumericFunctions numericFunctions = new NumericFunctions.NumericFunctions();
            int actual = numericFunctions.Add(x, y);
            Assert.AreEqual(exptected, actual);
        }


    }
}