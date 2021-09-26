using NUnit.Framework;
using Bunit;

namespace TestProject1

{
    [TestFixture]
    public class Tests
    {
        private Bunit.TestContext testContext;
        
        
        [SetUp]
        public void Setup()
        {
             var fizzBuzz = new Tests();
            //testContext = new Bunit.TestContext();
        }

        [Test]
        public void Test_the_button()
        {
            // using var context = new TestContext();
            using var ctx = new Bunit.TestContext();
            var cut = ctx.RenderComponent<WebApplication10.Pages.FizzBuzz>();
            cut.Find("button").Click();
            cut.Find("h3").MarkupMatches("<h3>FizzBuzz</h3>");


            //Assert.Pass();
        }
        [Test]
      
        public void FizzyOutput_OutputsOne_WhenInputIsOne()
        {
            var output = fizzBuzz.FizzyOutput(1);

            Assert.AreEqual("1", output);
        }
        [Test]
        public void FizzyOutput_OutputsTwo_WhenInputIsTwo()
        {
            var output = fizzBuzz.FizzyOutput(2);

            Assert.AreEqual("2", output);
        }
        [Test]
        public void FizzyOutput_OutputsBuzz_WhenInputIsMultipleOfFive(int input)
        {
            var output = fizzBuzz.FizzyOutput(input);

            Assert.AreEqual("Buzz", output);
        }
        [Test]
        public void FizzyOutput_OutputsFizz_WhenInputIsMultipleOfThree(int input)
        {
            var output = fizzBuzz.FizzyOutput(input);

            Assert.AreEqual("Fizz", output);
        }
        [Test]
        public void FizzyOutput_OutputsFizzBuzz_WhenInputIsMultipleOfThreeAndFive(int input)
        {
            var output = fizzBuzz.FizzyOutput(input);

            Assert.AreEqual("FizzBuzz", output);
        }
    }
}