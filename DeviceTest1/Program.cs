﻿using DeviceSample.Model;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace DeviceSample
{
    class Program
    {
        //Note:  Make this address configurable in your app.  It is almost certainly going to change for our device services.
        //Also note that right now this url and parameter names are case sensitive.
        const string baseAddress = "https://api.fdbprizm.com/mdp/api/v1_2/";

        //Update these two variables with the credentials provided by FDB
        //const string clientId = "REPLACE_THIS_TEXT_WITH_YOUR_PROVIDED_CLIENT_ID";
        //const string secret = "REPLACE_THIS_TEXT_WITH_YOUR_PROVIDED_SECRET";

        const string clientId = "REPLACE_THIS_TEXT_WITH_YOUR_PROVIDED_CLIENT_ID";
        const string secret = "REPLACE_THIS_TEXT_WITH_YOUR_PROVIDED_SECRET";

        static void Main(string[] args)
        {
            GetDevices().Wait();
        }

        static async Task GetDevices()
        {
            using (var client = new HttpClient())
            {
                //Here we're adding two headers:  An Authorization header and an accept header.  The authorization header
                //takes the following format, where xx is the clientId and yyyyyyy is the secret.
                //Authorization: SHAREDKEY xx:yyyyyyyyyyyyyyyy
                client.BaseAddress = new Uri(baseAddress);
                client.DefaultRequestHeaders.Add("Authorization", "SHAREDKEY " + clientId + ":" + secret);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Now structure the request so that it searches on the fields you want.
                //Here is a request that returns the top 100 devices in the database
                var request = "devices?limit=100&offset=1&callSystemName=ConsoleAppExample";

                //OTHER EXAMPLES:
                //Here is an example of searching for a GTIN14
                //var request = "devices?searchFilter=GTIN14:09420012421777&callSystemName=ConsoleAppExample";

                //Here is an example of searching for a HIBC
                //var request = "devices?searchFilter=HIBC:H67141496090&callSystemName=ConsoleAppExample";

                //Here is an example of searching for any identifier (GTIN, HIBC, NDC/NHRIC, UPN etc.)
                //var request = "devices?searchFilter=Packages.PackageIdentifiers.ExternalPackageId:"00841447100034"&callSystemName=ConsoleAppExample";

                //Here is an example of searching for HCPCSCode
                //var request = "devices?searchFilter=HCPCS.HCPCSCode:"K0738"&callSystemName=ConsoleAppExample";

                //Here is an example where you are searching and you don't necessarily know the type
                //var request = "devices?searchText=H67141496090&searchType=Fuzzy&callSystemName=ConsoleAppExample";

                //Here is an example where you are searching for CatalogNumber
                //var request = "devices?searchFilter=CatalogNumbers.CatalogNumber:"47-2347-123-00"&callSystemName=ConsoleAppExample";

                //Here is an example where you can search between dates on the PrizmPublishDate
                //var request = "devices?SearchFilter=PrizmPublishDate:[2017-01-05 TO 2017-01-10]"; 

                //Here is an example where you can search between dates on the PrizmRevisionDate
                //var request = "devices?SearchFilter=PrizmRevisionDate:[2017-09-01 TO 2017-09-25]"; 

                //We always recommend calling API services asynchronously
                HttpResponseMessage response = await client.GetAsync(request);

                //Look for a 200 status code.  400 level status codes indicate something went wrong that a client could potentially fix.
                // For example, 401 unauthorized, or 404 not found.
                // 500 level errors indicate that something went wrong on the server side.
                if (response.IsSuccessStatusCode)
                {

                    var r = await response.Content.ReadAsAsync<SearchDevicesResponse>();
                    foreach (var device in r.Items)
                    {
                        Console.WriteLine(device.StandardDeviceName);
                    }

                    Console.WriteLine("");

                    //In a typical app, you might display these results, and then the user would select the device that matched.
                    //Send the feedback on items that are selected.  In this case, let's say the first item returned is the one
                    //the user selects.  The intent here is that you send back the unique identifier for the search operation, as
                    //well as the Id that was chosen, and the action that was taken on it.  In this case, we don't have the stable
                    //FDBId for devices out there yet, so just send back the name of the device selected.
                    //This can be a fire and forget method, so it does not need to impact the performance of your app
                    if (r.Items.Count > 0)
                    {
                        SendFeedback(r.ServiceCallId, r.Items[0].StandardDeviceName, SearchAction.selected);
                    }
                    else
                    {
                        Console.WriteLine("No Records found with the search criteria.");
                    }
                }
                else
                {
                    Console.WriteLine("Call Failed, reason: " + response.ReasonPhrase);
                    Console.WriteLine("");
                }

                Console.WriteLine("Press Enter to Exit.");
                Console.ReadLine();
            }
        }

        static async void SendFeedback(string serviceCallId, string deviceId, SearchAction action)
        {
            using (var client = new HttpClient())
            {
                //Here we're adding two headers:  An Authorization header and an accept header.  The authorization header
                //takes the following format, where xx is the clientId and yyyyyyy is the secret.
                //Authorization: SHAREDKEY xx:yyyyyyyyyyyyyyyy
                client.BaseAddress = new Uri(baseAddress);
                client.DefaultRequestHeaders.Add("Authorization", "SHAREDKEY " + clientId + ":" + secret);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var request = String.Format("devicesearchfeedback/{0}?action={1}&entityid={2}", serviceCallId, action.ToString(), deviceId);

                //Fire and forget.  No need to wait for this method to complete, or check on whether or not it was successful.
                client.PutAsync(request, null);

                return;
            }
        }
    }
}
