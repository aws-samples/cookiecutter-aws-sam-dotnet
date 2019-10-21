using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

using Amazon.Lambda.Core;
using Amazon.Lambda.APIGatewayEvents;
using Newtonsoft.Json;
 {%- if cookiecutter.include_xray == "y" %}
using Amazon.XRay.Recorder.Core;
using Amazon.XRay.Recorder.Handlers.AwsSdk;
{% endif %}
 {%- if cookiecutter.include_sqs_events == "y" %}
using Amazon.Lambda.SQSEvents;
{% endif %}

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]
namespace {{ cookiecutter.project_name }}
{
    public class Function
    {
        private static readonly HttpClient client = new HttpClient();

        /// <summary>
        /// Default constructor that Lambda will invoke.
        /// </summary>
        public Function()
        {
            {%- if cookiecutter.include_xray == "y" %}
             AWSSDKHandler.RegisterXRayForAllServices();{% endif %}
        }

        public APIGatewayProxyResponse FunctionHandler(APIGatewayProxyRequest apigProxyEvent, ILambdaContext context)
        {
            var location = GetCallingIP().Result;
            
            var body = new Dictionary<string, string>
            {
                { "message", "hello world" },
                { "location", location },
            };

            return new APIGatewayProxyResponse
            {
                Body = JsonConvert.SerializeObject(body),
                StatusCode = 200,
                Headers = new Dictionary<string, string> { { "Content-Type", "application/json" } }
            };
        }
        private static async Task<string> GetCallingIP()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Add("User-Agent", "AWS Lambda .Net Client");

            var stringTask = client.GetStringAsync("http://checkip.amazonaws.com/").ConfigureAwait(continueOnCapturedContext:false);

            var msg = await stringTask;
            return msg.Replace("\n","");
        }
    }
}
