using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Xml;
using System.IO;
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
        public async Task<PackageAdded_Result> AddPackage(AddPackageHelper APH)
        {
            object request; //request *was* initialized as var without conditional MPA 9/15/2020

            try
            {
                //MPA 9/15/2020 Conditional for how initial document is included
                if (!string.IsNullOrEmpty(APH.UploadPDFfile))
                {
                    // Add Package Request
                    request = new
                    {
                        Name = "API Call Package",

                        //MPA 9/11/2020
                        Type = "video_closing_room",
                        //State = "open", //draft is another option //forbidden
                        /*
                        Options = new[] { new {
                            MeetingVideoRecordingAuto = false,
                            MeetingVideoRecordingDisabled = false,
                            NotifyMeeting = true,
                            NotifyMeetingIcsAttachment = true} },
                        */                        
                        
                        //MPA 11/10/2020
                        GenerateSignerLinks = "True",

                        Meeting = new[] { new { TimeStart = DateTime.Now.ToString("yyyy/MM/ddTHH:mm")
                                        , Duration = XmlConvert.ToString(TimeSpan.FromHours(1)) // ISO 8601 Duration
                                        , isPrivate = true} },
                        Signers = new object[] { //WAS just new[], changed to relieve error MPA 9/11/2020
                        new  { FirstName = "Michael", LastName = "Andro", Email = "michaelandro94@gmail.com", Role = "host", SignCac = true } //MPA 9/11/2020 added role and signcac
                       ,new { FirstName = "Leahcim", LastName = "Ordna", Email = "michaelandro@hotmail.com" } //MPA 9/11/2020
                        },
                            Documents = new[]
                            {
                                new { //fileUrl = "https://download.syngrafii.com/test/agreement.pdf"
                                      fileData = File.ReadAllBytes(APH.UploadPDFfile)
                                    //fileId = APH.UploadPDFfile
                                }
                            }
                    };
                }
                else if (!string.IsNullOrEmpty(APH.UploadedPDFid))
                {
                    // Add Package Request
                    request = new
                    {
                        Name = "API Call Package",

                        //MPA 9/11/2020
                        Type = "video_closing_room",
                        //State = "open", //draft is another option //forbidden
                        /*
                        Options = new[] { new {
                            MeetingVideoRecordingAuto = false,
                            MeetingVideoRecordingDisabled = false,
                            NotifyMeeting = true,
                            NotifyMeetingIcsAttachment = true} },
                        */
                        Meeting = new[] { new { TimeStart = DateTime.Now.ToString("yyyy/MM/ddTHH:mm")
                                        , Duration = XmlConvert.ToString(TimeSpan.FromHours(1)) // ISO 8601 Duration
                                        , isPrivate = true} },
                        Signers = new object[] { //WAS just new[], changed to relieve error MPA 9/11/2020
                        new  { FirstName = "Michael", LastName = "Andro", Email = "michaelandro94@gmail.com", Role = "host", SignCac = true } //MPA 9/11/2020 added role and signcac
                       ,new { FirstName = "Leahcim", LastName = "Ordna", Email = "michaelandro@hotmail.com" } //MPA 9/11/2020
                    },
                        Documents = new[]
                        {
                    new { //fileUrl = "https://download.syngrafii.com/test/agreement.pdf"
                          //fileData = File.ReadAllBytes(APH.UploadPDFfile)
                            fileId = APH.UploadedPDFid}
                }
                    };
                }
                else
                {
                    throw new Exception("Must have an initial form.");
                }

                // Serialize Json
                var message = new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json");
                // Post Request
                var response = await _httpClient.PostAsync("packages/add", message);
                response.EnsureSuccessStatusCode();

                //return JsonConvert.DeserializeObject(await response.Content.ReadAsStringAsync());
                //MPA 9/14/2020
                dynamic content = JsonConvert.DeserializeObject<dynamic>(await response.Content.ReadAsStringAsync());
                PackageAdded_Result Presult = JsonConvert.DeserializeObject<PackageAdded_Result>(JsonConvert.SerializeObject(content));

                //MPA 11/6/2020
                DebugClass.Jot(new List<string>() { Presult.package.signers[0].meetingLink.ToString() });


                return Presult;
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

        public async Task<FileAdded_Result> AddFile(string TheFileName, string TheFileUrl)
        {
            DebugClass.Jot(new List<string>() { "Test" });


            try
            {
                var request = new
                {
                    files = new[]
                    {
                        new { FileName = TheFileName, FileData = File.ReadAllBytes(TheFileUrl) }
                    }
                };
                //MPA 9/14/2020 note that guide suggests must post file with content-type of application/pdf to work.

                // Serialize Json
                var message = new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json");
                // Post Request
                var response = await _httpClient.PostAsync("files/add", message);
                response.EnsureSuccessStatusCode();
                DebugClass.Jot(new List<string>() { "Successful file add!"});

                //MPA 9/14/2020 Now returns as FileAdded_Result
                dynamic content =  JsonConvert.DeserializeObject<dynamic>(await response.Content.ReadAsStringAsync());
                FileAdded_Result Fresult = JsonConvert.DeserializeObject<FileAdded_Result>(JsonConvert.SerializeObject(content));
                return Fresult;
            }
            catch (Exception Ex)
            {
                DebugClass.Jot(new List<string>() { "Unsuccessful Add File!", Ex.Message, Ex.InnerException?.Message, Ex.StackTrace, Ex.Source});
                return null;
            }
            
            
            
        }
    }
}
