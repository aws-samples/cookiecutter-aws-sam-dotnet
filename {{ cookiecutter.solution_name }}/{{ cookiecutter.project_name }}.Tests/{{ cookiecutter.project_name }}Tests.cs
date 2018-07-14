using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Xunit;
using Amazon.Lambda.Core;
using Amazon.Lambda.TestUtilities;
using Amazon.Lambda.APIGatewayEvents;

using {{ cookiecutter.project_name }};

namespace {{ cookiecutter.project_name }}.Tests
{
    public class {{ cookiecutter.project_name }}Tests
    {
        public {{ cookiecutter.project_name }}Tests()
        {
        }

        [Fact]
        public void TestFunctionHandlerMethod()
        {
            var function = new Function();
            var request = new APIGatewayProxyRequest();
            var context = new TestLambdaContext();
            
            var response = function.FunctionHandler(request, context);
            
            Assert.Equal(200, response.StatusCode);
            Assert.Equal("Hello AWS Serverless", response.Body);
        }
    }
}
