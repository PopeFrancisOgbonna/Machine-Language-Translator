using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Cloud.Translation.V2;
namespace LanguageTranslator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loadCombo();
           Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", @"C:\Users\Pope Francis\Downloads\seventh-carport-258908-6e2ded26af5d.json");
        }
        private void btnDetectSrc_Click(object sender, EventArgs e)
        {
            //var client = new RestClient()
            //{
            //    BaseUrl = new Uri(string.Format(AppCache.UrlDetect, AppCache.API, richTextSrc.Text))
            //};
            //var request = new RestRequest()
            //{
            //    Method = Method.GET
            //};
            //var response = responseService(AppCache.UrlDetect);
            //var diction = JsonConvert.DeserializeObject<IDictionary>(response.Content);
            //try
            //{
            //    var statusCode = diction["code"].ToString();

            //    if (statusCode.Equals("200"))
            //    {
            //        txtSrcLang.Text = diction["lang"].ToString();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message.ToString());
            //}// Yandex API

            if (richTextSrc.Text == "")
            {
                MessageBox.Show("Empty Message Please Enter Text", "Empty Text", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                TranslationClient client = TranslationClient.Create();
                var detection = client.DetectLanguage(richTextSrc.Text);
                switch (detection.Language)
                {
                    case "en":
                        txtSrcLang.Text = "English Language";
                        break;
                    case "ig":
                        txtSrcLang.Text = "Igbo Language";
                        break;
                    case "ha":
                        txtSrcLang.Text = "Hausa Language";
                        break;
                    case "fr":
                        txtSrcLang.Text = "French Language";
                        break;
                    default:
                        txtSrcLang.Text = "Language not listed";
                        MessageBox.Show("Language not listed bu you can translate anyway.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }
                txtSrcLang.Visible = true;
            }
        }
        private void btnTranslate_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Contains("Select") ||richTextSrc.Text=="")
            {
                MessageBox.Show("Please enter text and select language from the drop box");
              
            }
            else
            {
                 TranslationClient translate = TranslationClient.Create();

                try
                {
                    if (comboBox1.SelectedItem.ToString() == "Igbo Language")
                    {
                        TranslationResult result = translate.TranslateText(
                 richTextSrc.Text,
                 targetLanguage: "ig",
                 //sourceLanguage: "en",
                 model: TranslationModel.NeuralMachineTranslation);
                        DestRichT.Text = result.TranslatedText.ToString();
                    }
                    if (comboBox1.SelectedItem.ToString() == "Hausa Language")
                    {
                        TranslationResult result = translate.TranslateText(
                richTextSrc.Text,
                targetLanguage: "ha",
                //sourceLanguage: "en",
                model: TranslationModel.NeuralMachineTranslation);
                        DestRichT.Text = result.TranslatedText.ToString();
                    }
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message.ToString());
                }
                destinationLangPane.Visible = true;
            }
           
        }
        private void loadCombo()
        {
            //comboBox1.Items.Add("English Language");
            comboBox1.Items.Add("Igbo Language");
            comboBox1.Items.Add("Hausa Language");
        }
        private IRestResponse responseService(string url)
        {
            var client = new RestClient()
            {
                BaseUrl = new Uri(string.Format(url,AppCache.API, richTextSrc.Text))
            };
            var request = new RestRequest()
            {
                Method = Method.GET
            };
            return client.Execute(request);
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            richTextSrc.Text = "";
           btnClear.Visible = false;
        }

        private void richTextSrc_TextChanged(object sender, EventArgs e)
        {
            btnClear.Visible = true;
        }
    }

}
