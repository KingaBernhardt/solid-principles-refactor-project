using System;
using System.Collections.Generic;
using System.Text;

namespace ArdalisRating.Tests
{
    //Should use Mock instead (but not for this course)
    public class FakePolicySource : IPolicySource
    {
        public string PolicyString { get; set; } = "";
        public string GetPolicyFromSource()
        {
            return PolicyString;
        }
    }
}
