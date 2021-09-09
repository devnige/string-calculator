using Xunit;

namespace string_calculator
{
    public class TestClass
    {
        [Fact]
        public void EmptyStringInputReturnsZero()
        {
            // Arrange
            // Need to specify the data you are going to test
            // Method to be tested - create an object of class
            string str1 = "";
            StringCalculator stringcalc1 = new StringCalculator();

            // Act
            // What should happen - call the method
            int result = stringcalc1.Add(str1);
            
            // Assert
            // Compare the response
            Assert.Equal(0, result);
        }

        [Fact]
        public void StringInputReturnsInt()
        {
            // Arrange
            // Need to specify the data you are going to test
            // Method to be tested - create an object of class
            string str2 = "1";
            StringCalculator stringcalc2 = new StringCalculator();

            // Act
            // What should happen - call the method

            int result = stringcalc2.Add(str2);
            
            // Assert
            // Compare the response
            Assert.Equal(1, result);
        }

        [Fact]
        public void StringWithTwoNumsInputReturnsSum()
        {
            // Arrange
            // Need to specify the data you are going to test
            // Method to be tested - create an object of class
            string str3 = "1,2";
            StringCalculator stringcalc3 = new StringCalculator();

            // Act
            // What should happen - call the method

            int result = stringcalc3.Add(str3);
            
            // Assert
            // Compare the response
            Assert.Equal(3, result);
        }
    }   
}