using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Services;
using System.Xml.Serialization;
using RestSharp;
using RestSharp.Authenticators;
using Newtonsoft.Json;
using System.IO;
using System.Web;

namespace SyngrafiiExecutor
{
    class Program
    {
        static void Main(string[] args)
        {
            MainAsync(args).GetAwaiter().GetResult();
        }

        static async Task MainAsync(string[] args) //static void main
        {
            //first expected argument is account
            //second is "true" for the first parameter is integer account, "false" for first parameter is alias
            //third is "false" for blank form, "true" for final form

#if DEBUG
            args = new[] { "1024246", "True", "False" };
#endif

            string ExitMessage = "";
            if (args == null || args.Length != 3)
            {
                ExitMessage = "Invalid number of arguments given!";
            }
            else if (args[0].Length == 0)
            {
                ExitMessage = "Account not given!";
            }
            else if (args[1].ToUpper() != "TRUE" && args[1].ToUpper() != "FALSE")
            {
                ExitMessage = "Parameter 2 invalid: expected true or false in string form";
            }
            else if (args[2].ToUpper() != "TRUE" && args[2].ToUpper() != "FALSE")
            {
                ExitMessage = "Parameter 3 invalid: expected true or false in string form";
            }

            if (ExitMessage.Length > 0)
            {
                MessageBox.Show("SyngrafiiExecutor error: " + ExitMessage);
                return;
            }

            bool SecondParameterInput = args[1].ToUpper() == "TRUE";
            bool ThirdParameterInput = args[2].ToUpper() == "TRUE";

            string PdfTempFilePath = iTextPlaceholderDLL.iTextPlaceholderClass.CompletedTempForm(args[0], SecondParameterInput, ThirdParameterInput);

            //now that we have the path of the PDF we need to upload to the package, we can do so.
            string FileAddAPIkey = "SK-8BFF18BCA34F6CC1194772997F3A3D6D-E49E0A7F7C5FE1F02CA32AC56B674BFE0C3D1E9880E228127EF3CCA38D791414"; //WIP: find API key and replace!
            string PackageAddAPIkey = "SK-DA2FC1E5EEF303A6358DF2B19E6B718A-DEB5C689924A4B4FA22F83A10F13C3731E184E2101CA333160D3D57155D2B350";



            //First, add files to the account using /api/v1/files/add - the response will include a folderId as well as an addPackageLink that will be used in the next step to create a new package with the uploaded files
            //note: Additional files can be added to an existing folder by passing the original folderId with subsequent files/add requests.
            // /api/v1/packages/add

            //Change to match syngrafii

            //Presumably, final API Endpoint is 

            SyngrafiiHttpClient client = new SyngrafiiHttpClient(@"https://sign.syngrafii.com/api/v1", FileAddAPIkey);
            
            //client = new RestClient(@"https://sandbox.syngrafii.com/api/v1");

            //client.Authenticator = new HttpBasicAuthenticator(GFZuser, GFZpass);

            
            //var request = new RestRequest(@"/files/add", Method.POST);



            //request.AddParameter("files", String.Format("{{ \"fileName\": \"{0}\",  \"fileUrl\": \"{1}\" }}", new string[] { PdfTempFilePath.Split('/')[PdfTempFilePath.Split('/').Length - 1].Split('.')[0], PdfTempFilePath }), "application/json", ParameterType.RequestBody);
            //MPA 8/28/2020 WIP trying to use class to facilitate?
            req_file ToUpload = new req_file();
            ToUpload.fileName = PdfTempFilePath.Split('\\')[PdfTempFilePath.Split('\\').Length - 1]; 
            ToUpload.fileUrl = PdfTempFilePath; //WIP!!! the files need to already exist in SYNGRAFII and then are uploaded to the user's account! I think! This will need to be fixed in placeholder!

            
            
            //byte[] bytes = File.ReadAllBytes(ToUpload.fileUrl);
            string contentType = MimeMapping.GetMimeMapping(ToUpload.fileUrl);


            //request.AddHeader("api_key", FileAddAPIkey);
            //request.AddHeader("Content-Type", "multipart/form-data"); //"application/json"
            //request.AddParameter("files", bytes, contentType, ParameterType.RequestBody);
            //request.AddParameter("files", ToUpload, "application/json", ParameterType.RequestBody);
            //request.AddFile(ToUpload.fileName, bytes, ToUpload.fileUrl, contentType);
            //request.AddBody();

            //var response = client.Execute(request);
            dynamic whatreturns = await client.AddFile(ToUpload.fileName, ToUpload.fileUrl);

            SyngrafiiHttpClient client2 = new SyngrafiiHttpClient(@"https://sign.syngrafii.com/api/v1", PackageAddAPIkey);
            dynamic whatreturns2 = await client2.AddPackage();

            //if (response.IsSuccessful)
            //{
                //MessageBox.Show("Successful response!");
                //string loc = response.Headers.FirstOrDefault(t => t.Name.ToUpper().Equals("LOCATION")).Value.ToString();
                //request = new RestRequest(loc, Method.GET);
                //IRestResponse<ClassLib.PDF_Result> pdfResp;
                //ClassLib.PDF_Result pdfResult = null;
                //string pdfStatus = "UNKNOWN";
            //}
        }

    }
}
