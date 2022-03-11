using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace TranslateString
{
    public partial class Form1 : Form
    {

        // When you have your own cliend ID and secret, specify them here:
        private static string CLIENT_ID = "FREE_TRIAL_ACCOUNT";
        private static string CLIENT_SECRET = "PUBLIC_SECRET";

        private static string API_URL = "http://api.whatsmate.net/v1/translation/translate";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /* Console.WriteLine("-----------------------.");
             //Translator textTranslator = new Translator();
             // Specify your translation requirements here:
             string fromLang = "en";
             string toLang = "vi";
             string text = "Let's have some fun!";
             translate(fromLang, toLang, text);
             Console.WriteLine("Press Enter to exit.");
             Console.ReadLine();*/
            comboBoxFrom.SelectedItem = null;
            comboBoxFrom.SelectedText = "--select--";

            comboBoxTo.SelectedItem = null;
            comboBoxTo.SelectedText = "--select--";

            btnStart.Enabled = false;
            btnDownload.Enabled = false;
        }

        public string translate(string fromLang, string toLang, string text)
        {

            try
            {
                using (WebClient client = new WebClient())
                {
                    client.Headers[HttpRequestHeader.ContentType] = "application/json";
                    client.Headers["X-WM-CLIENT-ID"] = CLIENT_ID;
                    client.Headers["X-WM-CLIENT-SECRET"] = CLIENT_SECRET;
                    client.Encoding = Encoding.UTF8;

                    Payload payloadObj = new Payload() { fromLang = fromLang, toLang = toLang, text = text };
                    string postData = (new JavaScriptSerializer()).Serialize(payloadObj);

                    return client.UploadString(API_URL, postData);
                }
            }
            catch (WebException webEx)
            {
                Console.WriteLine(((HttpWebResponse)webEx.Response).StatusCode);
                Stream stream = ((HttpWebResponse)webEx.Response).GetResponseStream();
                StreamReader reader = new StreamReader(stream);
                String body = reader.ReadToEnd();
                Console.WriteLine(body);
            }

            return "fail";
        }

        public class Payload
        {
            public string fromLang { get; set; }
            public string toLang { get; set; }
            public string text { get; set; }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        TextReader textReader;
        String nameFile = "";
        private void btnInputFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog mOpenFileDialog;


            listDataInput.Rows.Clear();

            mOpenFileDialog = new OpenFileDialog();
            mOpenFileDialog.Title = "Chọn file cần translate";
            mOpenFileDialog.InitialDirectory = "C:pathtofile";
            mOpenFileDialog.Filter = "String (*.xml)|*.xml";
            mOpenFileDialog.FilterIndex = 1;
            mOpenFileDialog.RestoreDirectory = true;

            if (mOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                nameFile = mOpenFileDialog.FileName;

                int rowCurrent = 0;
                int rowTotal = 0;
                int position = 0;

                try
                {
                    // Create an instance of StreamReader to read from a file.
                    // The using statement also closes the StreamReader.
                    using (StreamReader sr = new StreamReader(nameFile))
                    {
                        string line;

                        // Read and display lines from the file until 
                        // the end of the file is reached. 
                        while ((line = sr.ReadLine()) != null)
                        {
                            if (!string.IsNullOrWhiteSpace(line))
                            {
                                string[] firstArr = line.Split(Convert.ToChar(">"));
                                string first = firstArr[0];
                                string[] nameArr = first.Split(Convert.ToChar(" "));
                                string name = "";

                                foreach (var item in nameArr)
                                {
                                    if (item.Contains("name="))
                                    {
                                        name = item;
                                    }
                                }

                                string translatedNot = "false";
                                string[] secondArr = firstArr[1].Split(Convert.ToChar("<"));
                                string value = secondArr[0];

                                try
                                {
                                    if (!string.IsNullOrWhiteSpace(value) && !first.Contains(translatedNot))
                                    {
                                        position++;

                                        int indexRow = listDataInput.Rows.Add();
                                        listDataInput.Rows[indexRow].Cells["stt"].Value = position;
                                        listDataInput.Rows[indexRow].Cells["name"].Value = name;
                                        listDataInput.Rows[indexRow].Cells["text"].Value = value;

                                        rowTotal++;
                                        Application.DoEvents();
                                    }
                                }
                                catch (Exception ex1)
                                {
                                    continue;
                                }

                                rowCurrent++;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Let the user know what went wrong.
                    Console.WriteLine("The file could not be read:");
                }
                txtTotal.Text = rowTotal + "";
                txtTotalCurrent.Text = "" + rowTotal;

                btnStart.Enabled = true;
                
            }
        }

        private void listDataInput_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        DataGridView listDataInputStart;

        private void btnStart_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(Translate("Hello"));
            listDataInputStart = listDataInput;
            int index = 1;
            int rowIndex = 0;
            String value = comboBoxFrom.Text;
            string fromLang = comboBoxFrom.Text;
            string toLang = comboBoxTo.Text;


            if (fromLang == "--select--")
            {
                MessageBox.Show("Hãy chọn ngôn ngữ gốc!");
                comboBoxFrom.Focus();
            }

            if (toLang == "--select--")
            {
                MessageBox.Show("Hãy chọn ngôn ngữ muốn dịch!");
                comboBoxTo.Focus();
            }


            if (fromLang != "--select--" && toLang != "--select--")
            {
                while (rowIndex < listDataInput.Rows.Count)
                {
                    LoadSTT("Đang điền...", "status", rowIndex, listDataInput);

                    txtCurrentLoop.Text = index.ToString();

                    string stringValue = listDataInput.Rows[rowIndex].Cells["text"].Value.ToString();

                    string valueTranslated = Translate(fromLang, toLang, stringValue);

                    if (valueTranslated == "Error")
                    {
                        LoadSTT("Thất bại", "status", rowIndex, listDataInput);
                    }
                    else
                    {
                        listDataInput.FirstDisplayedScrollingRowIndex = rowIndex;//nhảy đến hangi đang xử lý trong datagridview
                        LoadSTT(valueTranslated, "translated", rowIndex, listDataInput);
                        LoadSTT("Thành công", "status", rowIndex, listDataInput);
                    }

                    rowIndex += 1;
                    index++;
                    if (rowIndex == listDataInput.Rows.Count)
                    {
                        btnDownload.Enabled = true;
                        MessageBox.Show("OK rồi download thôi anh em!!!! ");
                    }
                }
            }
        }

        public String Translate(string fromLanguage, string toLanguage, String word)
        {
            var url = $"https://translate.googleapis.com/translate_a/single?client=gtx&sl={fromLanguage}&tl={toLanguage}&dt=t&q={HttpUtility.UrlEncode(word)}";
            var webClient = new WebClient
            {
                Encoding = System.Text.Encoding.UTF8
            };
            var result = webClient.DownloadString(url);
            try
            {
                result = result.Substring(4, result.IndexOf("\"", 4, StringComparison.Ordinal) - 4);
                return result;
            }
            catch
            {
                return "Error";
            }
        }

        private void LoadSTT(string status, string colName, int row, DataGridView gv)
        {
            try
            {
                gv.Invoke(new Action(delegate ()
                {
                    gv.Rows[row].Cells[colName].Value = status;
                }));
            }
            catch
            {
                MessageBox.Show("error");
            }
        }
        String fullPathFile = "";

        private void btnDownload_Click(object sender, EventArgs e)
        {
            string toLang = comboBoxTo.Text;
            if (listDataInput.Rows.Count > 0)
            {
                DateTime today = DateTime.Today;

                string folderName = fullPathFile + today.ToString("dd-MM-yyyy");
                // If directory does not exist, create it
                if (!Directory.Exists(folderName))
                {
                    Directory.CreateDirectory(folderName);
                }

                String fileName = folderName + "\\string_" + toLang + ".xml";
                FileStream fs = new FileStream(fileName, FileMode.Create);//Tạo file mới tên là test.txt            
                StreamWriter sWriter = new StreamWriter(fs, Encoding.UTF8);//fs là 1 FileStream 

                using (StreamReader sr = new StreamReader(nameFile))
                {
                    string line;
                      
                    Console.WriteLine("------------------------  "+ listDataInput.Rows.Count);
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (!string.IsNullOrWhiteSpace(line))
                        {
                            string[] firstArr = line.Split(Convert.ToChar(">"));
                            string first = firstArr[0];
                            string[] nameArr = first.Split(Convert.ToChar(" "));
                            string name = "";

                            foreach (var item in nameArr)
                            {
                                if (item.Contains("name="))
                                {
                                    name = item;
                                }
                            }

                            string[] secondArr = firstArr[1].Split(Convert.ToChar("<"));
                            string value = secondArr[0];

                            for (int i = 0; i < listDataInput.Rows.Count; i++)
                            {
                                string nameTranslated = listDataInput.Rows[i].Cells["name"].Value.ToString();
                                string textTranslated = listDataInput.Rows[i].Cells["text"].Value.ToString();
                                string valueTranslated = listDataInput.Rows[i].Cells["translated"].Value.ToString();
                                if (name == nameTranslated)
                                {
                                    line= line.Replace(textTranslated, valueTranslated);
                                }
                                
                            }

                            sWriter.WriteLine(line);
                        }
                        
                        // Ghi và đóng file
                        
                    }
                    sWriter.Flush();
                    fs.Close();
                    Console.WriteLine("----------END--------------");
                }
                MessageBox.Show("Data Exported Successfully !!!", "Info");
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }

        }


        private void lblSoLuongMuonChay_Click(object sender, EventArgs e)
        {

        }
    }
}
