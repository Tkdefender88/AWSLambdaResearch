using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Xunit;
using Amazon.Lambda.Core;
using Amazon.Lambda.TestUtilities;

using HelloWorldFunc;

namespace HelloWorldFunc.Tests
{
    public class FunctionTest
    {
        [Fact]
        public void TestToUpperFunction()
        {

            // Invoke the lambda function and confirm the string was upper cased.
            var function = new DisplayNewUser();
            var context = new TestLambdaContext();
            var resp = function.FunctionHandler(new NewUser
            {
                FirstName = "Joe",
                LastName = "Bob"
            }, context);

            Assert.Equal("Welcome new user, Joe Bob", resp);
        }
    }
}
