using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Google.Protobuf.Collections;
using Google.Cloud.Language.V1;
using static Google.Cloud.Language.V1.AnnotateTextRequest.Types;
using Google.Cloud.Storage.V1;
using System.IO;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        public void Analyze()
        {
            
        }

        protected void btnSentiment_Click(object sender, EventArgs e, string analyze)
        {
            NLanguageService.NLanguageServiceSoapClient client = new NLanguageService.NLanguageServiceSoapClient();
            string localFile = File.ReadAllText("C:\\Users\\Yintong\\Documents\\Test STT\\textTest.txt");
            string text = "";

            var textResponse = client.AnalyzeSentimentFromText(text);
            var textResponseFile = client.AnalyzeSentimentFromFile(localFile);

            if (text == "")
                txtSentiment.Text = textResponseFile.ToString();
            else
                txtSentiment.Text = textResponse.ToString();
        }

        protected void btnEntities_Click(object sender, EventArgs e)
        {
            NLanguageService.NLanguageServiceSoapClient client = new NLanguageService.NLanguageServiceSoapClient();
            string localFile = File.ReadAllText("C:\\Users\\Yintong\\Documents\\Test STT\\362RX2.txt");
            string text = "";

            var textResponse = client.AnalyzeEntitiesFromText(text);
            var textResponseFile = client.AnalyzeEntitiesFromFile(localFile);

            if (text == "")
                txtEntities.Text = textResponseFile.ToString();
            else
                txtEntities.Text = textResponse.ToString();
        }

        protected void btnSyntax_Click(object sender, EventArgs e)
        {
            NLanguageService.NLanguageServiceSoapClient client = new NLanguageService.NLanguageServiceSoapClient();
            string localFile = File.ReadAllText("C:\\Users\\Yintong\\Documents\\Test STT\\362RX2.txt");
            string text = "";
            var textResponse = client.AnalyzeSyntaxFromText(text);
            var textResponseFile = client.AnalyzeSyntaxFromFile(localFile);

            if (text == "")
                txtSyntax.Text = textResponseFile.ToString();
            else
                txtSyntax.Text = textResponse.ToString();
        }

    }
}
