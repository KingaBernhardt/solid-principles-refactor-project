//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace ArdalisRating
//{
//    public class DefaultRatingContext : IRatingContext
//    {
//        public RatingEngine Engine { get; set; }
//        private readonly IPolicySource _policySource;
//        private readonly IPolicySerializer _policySerializer;
//        private readonly ILogger _logger;
//        public DefaultRatingContext(IPolicySource policySource, IPolicySerializer policySerializer, ILogger logger)
//        {
//            _policySource = policySource;
//            _policySerializer = policySerializer;
//            _logger = logger;
//        }

//        public Rater CreateRaterForPolicy(Policy policy)
//        {
//            return new RaterFactory(_logger).Create(policy);
//        }

//        public Policy GetPolicyFromJsonString(string policyJson)
//        {
//            return new JsonPolicySerializer().GetPolicyFromJsonString(policyJson);
//        }

//        public Policy GetPolicyFromXmlString(string policyXml)
//        {
//            throw new NotImplementedException();
//        }

//        public string LoadPolicyFromFile()
//        {
//            return _policySource.GetPolicyFromSource();
//        }

//        public string LoadPolicyFromURI(string uri)
//        {
//            throw new NotImplementedException();
//        }

//        public void Log(string message)
//        {
//            new ConsoleLogger().Log(message);
//        }
//    }
//}
