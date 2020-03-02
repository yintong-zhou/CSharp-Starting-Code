using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Google.Protobuf.Collections;
using Google.Cloud.Language.V1;
using static Google.Cloud.Language.V1.AnnotateTextRequest.Types;
using Google.Cloud.Storage.V1;
using System.IO;

namespace MyService
{
    /// <summary>
    /// Descrizione di riepilogo per NLanguageService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Per consentire la chiamata di questo servizio Web dallo script utilizzando ASP.NET AJAX, rimuovere il commento dalla riga seguente. 
    // [System.Web.Script.Services.ScriptService]
    public class NLanguageService : System.Web.Services.WebService
    {

        #region Analyze from Text
        [WebMethod]
        public string AnalyzeSentimentFromText(string text)
        {
            var client = LanguageServiceClient.Create();
            var response = client.AnalyzeSentiment(new Document()
            {
                Content = text,
                Type = Document.Types.Type.PlainText
            });
            var finalResponse = text + response;
            return finalResponse;
        }

        [WebMethod]
        public string AnalyzeEntitiesFromText(string text)
        {
            var client = LanguageServiceClient.Create();
            var response = client.AnalyzeEntities(new Document()
            {
                Content = text,
                Type = Document.Types.Type.PlainText
            });
            var finalResponse = text + response;
            return finalResponse;
        }

        [WebMethod]
        public string AnalyzeSyntaxFromText(string text)
        {
            var client = LanguageServiceClient.Create();
            var response = client.AnnotateText(new Document()
            {
                Content = text,
                Type = Document.Types.Type.PlainText
            },
            new Features() { ExtractSyntax = true });
            var finalResponse = text + response;
            return finalResponse;
        }

        #endregion

        #region Analyze from File
        [WebMethod] 
        public string AnalyzeSentimentFromFile(string path)
        {
            var client = LanguageServiceClient.Create();
            var response = client.AnalyzeSentiment(new Document()
            {
                Content = path,
                Type = Document.Types.Type.PlainText
            });
            var finalResponseFile = response.ToString();
            return finalResponseFile;
        }
       
        [WebMethod] 
        public string AnalyzeEntitiesFromFile(string path)
        {
            var client = LanguageServiceClient.Create();
            var response = client.AnalyzeEntities(new Document()
            {
                Content = path,
                Type = Document.Types.Type.PlainText
            });
            var finalResponseFile = response.ToString();
            return finalResponseFile;
        }
       
        [WebMethod] 
        public string AnalyzeSyntaxFromFile(string path)
        {
            var client = LanguageServiceClient.Create();
            var response = client.AnnotateText(new Document()
            {
                Content = path,
                Type = Document.Types.Type.PlainText
            },
            new Features() { ExtractSyntax = true });
            var finalResponseFile = response.ToString();
            return finalResponseFile;
        }
        #endregion

    }
}
