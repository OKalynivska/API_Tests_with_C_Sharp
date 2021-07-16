using API_Testing.DataFolder;
using NUnit.Framework;
using RestSharp;
using RestSharp.Serialization.Json;


namespace API_Testing.Tests
{
    [TestFixture]
    public class DeserealizationTest
    {
        [Test]
        public void CountrySerializationTest()
        {
            
            RestClient client = new RestClient("http://api.zippopotam.us");
            RestRequest request = new RestRequest("PL/00-001", Method.GET);

            IRestResponse response = client.Execute(request);

            LocationDTO locationResponse =
                new JsonDeserializer().
                Deserialize<LocationDTO>(response);
            Assert.That(locationResponse.Country, Is.EqualTo("Poland"));
        }



        [Test]
        public void PlaceNameSerializationTest()
        {
            RestClient client = new RestClient("http://api.zippopotam.us");
            RestRequest request = new RestRequest("ZA/0002", Method.GET);

            IRestResponse response = client.Execute(request);

            LocationDTO locationResponse =
                new JsonDeserializer().
                Deserialize<LocationDTO>(response);

            Assert.That(locationResponse.Places[0].PlaceName, Is.EqualTo("Pretoria"));
        }

        [Test]
        public void PostCodeSerializationTest()
        {
            RestClient client = new RestClient("http://api.zippopotam.us");
            RestRequest request = new RestRequest("MX/01000", Method.GET);

            IRestResponse response = client.Execute(request);

            LocationDTO locationResponse =
                new JsonDeserializer().
                Deserialize<LocationDTO>(response);

            Assert.That(locationResponse.PostCode, Is.EqualTo("01000"));
        }

    }
}
