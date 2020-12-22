using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.Azure.CognitiveServices.Vision.CustomVision.Prediction;
using Microsoft.Azure.CognitiveServices.Vision.CustomVision.Training;
using Microsoft.Azure.CognitiveServices.Vision.CustomVision.Training.Models;
using System.Threading;
using System.IO;

namespace ShopSystem
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string endpoint = "https://westus2.api.cognitive.microsoft.com/";
        string predictionKey = "6e89642a272144e8b90b3013149bd207";
        string projekctId = "b5022524-0dd9-4458-aa99-2c497248daac";
        string publishedModelName = "Iteration2";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            predictImage();
        }

        private void predictImage()
        {
            Label1.Text = "";
            CustomVisionPredictionClient predictionApi = AuthenticatePrediction(endpoint, predictionKey);
            Console.WriteLine("Making a prediction:");
            Microsoft.Azure.CognitiveServices.Vision.CustomVision.Prediction.Models.ImageUrl url = new Microsoft.Azure.CognitiveServices.Vision.CustomVision.Prediction.Models.ImageUrl(TextBox1.Text);
            System.Guid guid = new Guid(projekctId);
            var result = predictionApi.ClassifyImageUrl(guid, publishedModelName, url);

            foreach (var c in result.Predictions)
            {
                Label1.Text = Label1.Text + c.TagName + ": " + c.Probability + " ";
            }
        }

        private CustomVisionPredictionClient AuthenticatePrediction(string endpoint, string predictionKey)
        {
            CustomVisionPredictionClient predictionApi = new CustomVisionPredictionClient(new Microsoft.Azure.CognitiveServices.Vision.CustomVision.Prediction.ApiKeyServiceClientCredentials(predictionKey))
            {
                Endpoint = endpoint
            };
            return predictionApi;
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Image1.ImageUrl = TextBox1.Text;
        }
    }
}