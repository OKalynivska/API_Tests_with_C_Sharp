

using NUnit.Framework;
using RestSharp;
using System.Net;

namespace API_Testing
{
    [TestFixture]
    public class StatusCodeTest
    {
        [Test]
        public void TestStatusCode()
        {
            RestClient client = new RestClient("http://api.zippopotam.us");
            RestRequest request = new RestRequest("us/90210",Method.GET);

            IRestResponse response = client.Execute(request);
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK),"Somesing wrong!!!");


        }
        [Test]
        public void TestStatusNotFound()
        {
            RestClient client = new RestClient("http://api.zippopotam.us");
            RestRequest request = new RestRequest("us/9210", Method.GET);

            IRestResponse response = client.Execute(request);
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.NotFound), "Somesing wrong!!!");


        }

        [Test]
        public void TestStatusNotAllowed()
        {
            RestClient client = new RestClient("http://api.zippopotam.us");
            RestRequest request = new RestRequest("us/9210", Method.DELETE);

            IRestResponse response = client.Execute(request);
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.MethodNotAllowed), "Somesing wrong!!!");


        }

        [Test]
        public void TestStatus()
        {
            RestClient client = new RestClient("http://api.zippopotam.us");
            RestRequest request = new RestRequest("us/9210", Method.POST);

            IRestResponse response = client.Execute(request);
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.MethodNotAllowed), "Somesing wrong!!!");


        }

    }
}
