using Amazon.DynamoDBv2.DataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace AWSLambdaDynamoDBDemo
{
    [DynamoDBTable("duo-three")]
    public class DuoThree
    {
        [DynamoDBHashKey]
        public int Example_No { get; set; }

        [DynamoDBProperty("section_no")]
        public int Section_No { get; set; }

        [DynamoDBProperty("english_text")]
        public string English_Text { get; set; }

        [DynamoDBProperty("japanese_text")]
        public string Japanese_Text { get; set; }

        [DynamoDBIgnore]
        public string Operation { get; set; }
    }
}
