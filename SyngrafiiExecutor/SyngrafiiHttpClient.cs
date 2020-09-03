using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace SyngrafiiExecutor
{
    public class SyngrafiiHttpClient
    {
        private readonly HttpClient _httpClient;
        public SyngrafiiHttpClient(string instanceUrl, string apiKey)
        {
            _httpClient = new HttpClient();
            // Authentication
            _httpClient.DefaultRequestHeaders.Add("api_key", apiKey);
            // Base Url
            _httpClient.BaseAddress = new Uri(new Uri(instanceUrl, UriKind.Absolute), "/api/v1/");
        }
        public async Task<dynamic> AddPackage()
        {

            try
            {
                // Add Package Request
                var request = new
                {
                    Name = "New Package",
                    Signers = new[] {
                    new  { FirstName = "Signer", LastName = "One", Email = "testsigner@syngrafii.com" }
                },
                    Documents = new[]
                    {
                    new { fileUrl = "https://download.syngrafii.com/test/agreement.pdf" }
                }
                };
                // Serialize Json
                var message = new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json");
                // Post Request
                var response = await _httpClient.PostAsync("packages/add", message);
                response.EnsureSuccessStatusCode();
                return JsonConvert.DeserializeObject(await response.Content.ReadAsStringAsync());
            }
            catch (Exception Ex)
            {
                DebugClass.Jot(new List<string>() { "Unsuccessful Package Add! " + Ex.Message });
                return null;
            }


        }
        public async Task<dynamic> GetPackage(Guid packageId)
        {
            return await _httpClient.GetAsync($"packages/{packageId}");
        }

        public async Task<dynamic> AddFile(string FileName, string FileUrl)
        {
            DebugClass.Jot(new List<string>() { "Test" });


            try
            {
                var request = new
                {
                    files = new[]
                    {
                        new { fileName = FileName, fileUrl = FileUrl }
                    }
                };
                // Serialize Json
                var message = new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json");
                // Post Request
                var response = await _httpClient.PostAsync("files/add", message);
                response.EnsureSuccessStatusCode();
                DebugClass.Jot(new List<string>() { "Successful file add!"});
                return JsonConvert.DeserializeObject(await response.Content.ReadAsStringAsync());
            }
            catch (Exception Ex)
            {
                DebugClass.Jot(new List<string>() { "Unsuccessful Add File!", Ex.Message, Ex.InnerException?.Message, Ex.StackTrace, Ex.Source});
                return null;
            }
            
            
            
        }
    }
}
