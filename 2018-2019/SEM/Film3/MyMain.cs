//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;

//namespace Film3
//{
//    public class MyMain
//    {
//        if (e.Message.Photo != null)
//                {
//                    var photos = e.Message.Photo;
//        var photo = photos[photos.Length - 1];
//        var fileId = photo.FileId;
//        var photoIdentifier = Guid.NewGuid();
//                    using (var fileStream = System.IO.File.OpenWrite($"files\\{photoIdentifier}.jpg"))
//                    {
//                        var fileInfo = await botClient.GetInfoAndDownloadFileAsync(
//                          fileId: fileId,
//                          destination: fileStream
//                        );
//}

//userInfo.Photo.Path = $"files\\{photoIdentifier}.jpg";
//                    userInfo.Photo.DateCreate = DateTime.Today;

//                    userInfo.Photo.UserId = 1;
//                    PhotoService.Save(userInfo.Photo);
//    }
//}
//using System;
//using System.Net.Http.Headers;
//using System.Text;
//using System.Net.Http;
//using System.Web;

//namespace CSHttpClientSample
//{
//    static class Program
//    {
//        static void Main()
//        {
//            MakeRequest();
//            Console.WriteLine("Hit ENTER to exit...");
//            Console.ReadLine();
//        }

//        static async void MakeRequest()
//        {
//            var client = new HttpClient();
//            var queryString = HttpUtility.ParseQueryString(string.Empty);

//            // Request headers
//            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", "{subscription key}");

//            var uri = "https://westus.api.cognitive.microsoft.com/emotion/v1.0/recognize?" + queryString;

//            HttpResponseMessage response;

//            // Request body
//            byte[] byteData = Encoding.UTF8.GetBytes("{body}");

//            using (var content = new ByteArrayContent(byteData))
//            {
//                content.Headers.ContentType = new MediaTypeHeaderValue("< your content type, i.e. application/json >");
//                response = await client.PostAsync(uri, content);
//            }

//        }
//    }
//}
