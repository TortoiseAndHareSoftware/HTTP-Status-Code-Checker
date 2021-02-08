using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Windows.Forms;

namespace HTTP_Status_Code_Checker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void CheckStatusButton_Click(object sender, EventArgs e)
        {
            List<string> urlsToCheck = URLs.Text.Split('\n').ToList();
            List<string> statusCodeResults = new List<string>();

            foreach (string item in urlsToCheck)
            {

                using (HttpClient client = new HttpClient())
                {
                    try
                    {


                    HttpResponseMessage response = await client.GetAsync(item);

                    if (response.StatusCode.ToString() == string.Empty)
                    {
                        break;
                    }


                    statusCodeResults.Add(((int)response.StatusCode).ToString());
                    }
                    catch (Exception)
                    {
                        statusCodeResults.Add("999");
                        continue;
                    }
                }

            }

            foreach (var item in statusCodeResults)
            {
                statusCodes.AppendText(item + Environment.NewLine);
            }

            MessageBox.Show("Done");
        }
    }
}
