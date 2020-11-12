using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Amazon;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Amazon.Lambda.Core;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace AWSLambdaDynamoDBDemo
{
    public class Function
    {
        private static readonly AmazonDynamoDBClient Client = new AmazonDynamoDBClient(RegionEndpoint.APNortheast1);

        public void DynamoDbOperationHandler(DuoThree duoThreeEntity, ILambdaContext context)
        {
            using (var dbContext = new DynamoDBContext(Client))
            {
                switch (duoThreeEntity.Operation)
                {
                    case "Insert":
                        break;

                    case "Update":
                        break;

                    case "Select":
                        break;

                    case "Delete":
                        break;

                    default:
                        throw new ArgumentException("The operation is invalid.");
                }
            }
        }

        /// <summary>
        /// A simple function that takes a string and does a ToUpper
        /// </summary>
        /// <param name="input"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        //public string FunctionHandler(string input, ILambdaContext context)
        //{
        //    return input?.ToUpper();
        //}

        
    }
}
