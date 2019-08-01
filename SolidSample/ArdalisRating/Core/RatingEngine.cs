using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.IO;

namespace ArdalisRating
{
    /// <summary>
    /// The RatingEngine reads the policy application details from a file and produces a numeric 
    /// rating value based on the details.
    /// </summary>
    public class RatingEngine
    {
        private readonly ILogger _logger;
        private readonly IPolicySource _policySource;
        public readonly IPolicySerializer _policySerializer;
        private readonly RaterFactory _factory;
        
        public decimal Rating { get; set; }

        public RatingEngine(ILogger logger, IPolicySource policySource, IPolicySerializer policySerializer, RaterFactory factory)
        {
            _logger = logger;
            _policySource = policySource;
            _policySerializer = policySerializer;
            _factory = factory;
        }
        
        public void Rate()
        {
            _logger.Log("Starting rate.");

            _logger.Log("Loading policy.");

            string policyString = _policySource.GetPolicyFromSource();

            var policy = _policySerializer.GetPolicyFromJsonString(policyString);

            //Rate(policy);

            _logger.Log("Rating completed.");
        }
    }
}
