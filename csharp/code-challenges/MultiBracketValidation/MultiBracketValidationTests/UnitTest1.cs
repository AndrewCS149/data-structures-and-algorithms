using System;
using Xunit;
using static MultiBracketValidation.Program;

namespace MultiBracketValidationTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("{{}}")]
        [InlineData("{}(){}")]
        [InlineData("()[[Extra Characters]]")]
        [InlineData("(){}[[]]")]
        [InlineData("{}{Code}[Fellows](())")]
        public void CanReturnTrueOnValidStrings(string str)
        {
            bool result = MultiBracketVal(str);
            Assert.True(result);
        }

        [Theory]
        [InlineData("[({}]")]
        [InlineData("(](")]
        [InlineData("[(])")]
        [InlineData("Andrew")]
        public void CanReturnFalseOnInvalidStrings(string str)
        {
            bool result = MultiBracketVal(str);
            Assert.False(result);
        }
    }

}
