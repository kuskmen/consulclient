namespace consul.core.Models
{
    using Consul;
    using Newtonsoft.Json;
    using System;
    using System.Net;
    using System.Text;
    using System.Threading.Tasks;

    public class ConsulKeyValueStore : IDisposable
    {
        private Consul.IConsulClient _consulClient;

        public ConsulKeyValueStore(Uri consulUri)
        {
            _consulClient = new ConsulClient(cfg => cfg.Address = consulUri);
        }

        public async Task<string> GetAsync(string key)
        {
            var kvResponse = await _consulClient.KV.Get(key);
            switch (kvResponse.StatusCode)
            {
                case HttpStatusCode.OK:
                    return BytesToUtf8String(kvResponse.Response.Value);
                case HttpStatusCode.NotFound:
                    return null;
                default:
                    throw new Exception($"Unable to get data from Consul KV storage: {key}.");
            }
        }

        public async Task<bool> PutAsync(string key, string value)
        {
            var putResult = await _consulClient.KV.Put(new KVPair(key) { Value = Utf8StringToBytes(value) });
            return putResult.Response;
        }

        public async Task<bool> PutAsync(string key, object value)
        {
            var serializedValue = JsonConvert.SerializeObject(value);
            return await PutAsync(key, serializedValue);
        }

        public async Task<bool> DeleteAsync(string key)
        {
            var deleteResult = await _consulClient.KV.Delete(key);
            return deleteResult.Response;
        }

        public void Dispose()
        {
            _consulClient?.Dispose();
            _consulClient = null;
        }

        private static string BytesToUtf8String(byte[] bytes) => Encoding.UTF8.GetString(bytes);

        private static byte[] Utf8StringToBytes(string @string) => Encoding.UTF8.GetBytes(@string);
    }
}
