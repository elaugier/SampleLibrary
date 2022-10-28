using System;
using RestSharp;

namespace SampleLibrary
{
    public class MyWonderfullClass
    {
        private RestClient _restClient;

#if NETCOREAPP3_1
        private readonly string _version = "3.1";
#elif NET5_0
        private readonly string _version = "5.0";
#else
        private readonly string _version = "6.0";
#endif
        MyWonderfullClass(Uri uri)
        {
            _restClient = new RestClient(uri);
        }
        public string GetVersion()
        {
            return _version;
        }

        public RestClient GetRestClient()
        {
            return _restClient;
        }

        public async void DoSomething()
        {
#if NETCOREAPP3_1
            var r = new RestRequest("/path", Method.Get);
#else
            var r = new RestRequest(new Uri("/path"), Method.Get);
#endif
            var result = await _restClient.ExecuteAsync(r);
        }

    }
}