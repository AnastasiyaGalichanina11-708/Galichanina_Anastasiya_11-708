﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Film3
{
    public class MakeAnalist
    {
        const string subscriptionKey = "5d5294e181464e16bfbc46d5fac79873";

        const string uriBase =
            "https://westcentralus.api.cognitive.microsoft.com/face/v1.0/detect";

        /// <summary>
        /// Gets the analysis of the specified image by using the Face REST API.
        /// </summary>
        /// <param name="imageFilePath">The image file.</param>
        public async Task<Emotion> MakeAnalysisRequest(string imageFilePath)
        {
            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Add(
                "Ocp-Apim-Subscription-Key", subscriptionKey);

            string requestParameters = "returnFaceId=true&returnFaceLandmarks=false" +
                "&returnFaceAttributes=age,gender,headPose,smile,facialHair,glasses," +
                "emotion,hair,makeup,occlusion,accessories,blur,exposure,noise";
            string uri = uriBase + "?" + requestParameters;

            HttpResponseMessage response;


            byte[] byteData = GetImage.GetImageAsByteArray(imageFilePath);

            using (ByteArrayContent content = new ByteArrayContent(byteData))
            {
                content.Headers.ContentType =
                    new MediaTypeHeaderValue("application/octet-stream");

                response = await client.PostAsync(uri, content);

                string contentString = await response.Content.ReadAsStringAsync();

                var list = JsonConvert.DeserializeObject<IEnumerable<FaceComponents>>(contentString);
                return list.First().FaceAttributes.Emotion;
            }
        }
    }
}