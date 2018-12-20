using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Film3
{
    public class StartEmotionsAPI
    {
        public async Task<Emotion> Start(string imageFilePath)
        {
            var makeAnalys = new MakeAnalyst();

            if (!File.Exists(imageFilePath))
            {
                throw new Exception();
            }

            try
            {
                var g = await makeAnalys.MakeAnalysisRequest(imageFilePath);
                return g;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}