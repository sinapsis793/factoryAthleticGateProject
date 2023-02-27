using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Threading;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;
using System.Threading.Tasks;

namespace factoryAthletic
{

    public partial class Main : Form
    {
        SerialPort readPort;
        SerialPort writePort;
        Settings selectedSetting;
        OptionsForm form;

        OptionsForm form2;


        public void startListening(String listeningPort)
        {
            button1.Enabled = false;
            startButton.Enabled = false;
            doorOpen.Enabled = false;
            optionsButton.Enabled = false;
            if(selectedSetting == null)
            {
                selectedSetting = form2.LoadValueFromFile();

                if(selectedSetting != null)
                {

                    writePort = new SerialPort(selectedSetting.writePort, 9600);
                    writePort.Parity = Parity.None;
                    writePort.StopBits = StopBits.One;
                    writePort.DataBits = 8;
                    writePort.Handshake = Handshake.None;
                    writePort.Open();
                    writePort.Write("BB");
                }

            }
            else
            {
                writePort = new SerialPort(selectedSetting.writePort, 9600);
                writePort.Parity = Parity.None;
                writePort.StopBits = StopBits.One;
                writePort.DataBits = 8;
                writePort.Handshake = Handshake.None;
                writePort.Open();
                writePort.Write("BB");
                Thread.Sleep(500);
            }

            readPort = new SerialPort(listeningPort, 9600);
            readPort.Parity = Parity.None;
            readPort.StopBits = StopBits.One;
            readPort.DataBits = 8;
            readPort.Handshake = Handshake.None;
            readPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            readPort.Open();
            Thread.Sleep(500);
            button1.Enabled = true;
            doorOpen.Enabled = true;
            optionsButton.Enabled = true;

            if (readPort != null && readPort.IsOpen)
            {

                connectionStatus.Text = "Bağlantı Başarılı";

                startButton.Enabled = false;
                button1.Enabled = true;

            }


        }

        /// <summary>
        /// Called when there is new data coming in.
        /// </summary>
        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {

                SerialPort sp = (SerialPort)sender;
                if (sp != null && sp.IsOpen)
                {
                    string line = sp.ReadLine();
                    this.BeginInvoke(new LineReceivedEvent(LineReceived), line);
                    Thread.Sleep(3000); 
                }
            }
            catch
            {

            }



        }
        void MyFunction()
        {
            form2 = new OptionsForm();
            selectedSetting = form2.LoadValueFromFile();

            if (selectedSetting != null)
            {
                startListening(selectedSetting.readPort);
            }

        }

        private delegate void LineReceivedEvent(string line);
        String userNo1, userName, dateIn, timeIn, response;
        private void LineReceived(string line)
        {
            Logger("[DEBUG] " + readPort + " Porta gelen bulk veri:  " + line);

            if (line != null && line.Length > 20 && line.Contains(":"))
            {
                Logger("[DEBUG] " + readPort + " Porta gelen veri:  " + line);

                if (line.Split(':').Length == 9)
                {
                    userNo1 = line.Split(':')[0];
                    dateIn = line.Split(':')[1] + "/" + line.Split(':')[2] + "/" + line.Split(':')[3];
                    timeIn = line.Split(':')[4] + ":" + line.Split(':')[5];

                    response = MakeRequest(line.Split(':')[0], selectedSetting.clupId);

                    if (response != null && response.Split(':')[0] == "1")
                    {
                        userName = response.Split(':')[2];
                        Logger("[INFO] Kullanıcı girişi [id: " + userNo1 + "]");
                        usersGridView.Rows.Insert(0, new string[] { userNo1, response.Split(':')[2], dateIn, timeIn, response.Split(':')[3] });
                     
                        userImage.ImageLocation = "https://factoryathletic.com/panel/uploads/user/" + response.Split(':')[1];
                        userImage.SizeMode = PictureBoxSizeMode.AutoSize;
                        openDoorFunc();


                    }
                }

            }

        }

        public Main()
        {
            InitializeComponent();

            Control.CheckForIllegalCrossThreadCalls = false;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            form2 = new OptionsForm();
            selectedSetting = form2.LoadValueFromFile();

            button1.Enabled = false;

        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (thread1 != null && thread1.IsAlive)
                thread1.Abort();
            if (readPort != null)
            {

                if (readPort != null && readPort.IsOpen) readPort.Close();

            }
            if (writePort != null && writePort.IsOpen)
            {
                writePort.Close();
            }


        }


        private void optionsButton_Click(object sender, EventArgs e)

        {
            form = new OptionsForm();
            FormCollection fc = Application.OpenForms;
            bool acıldı = false;
            foreach (Form frm in fc)
            {
                //iterate through
                if (frm.Name == form.Name)
                {
                    frm.Show();
                    frm.Activate();
                    acıldı = true;
                }
            }
            if (!acıldı)
            {
                form.Show();
            }




        }



        Thread thread1;
        private void startButton_Click(object sender, EventArgs e)
        {
            
            if (selectedSetting == null)
                selectedSetting = form2.LoadValueFromFile();

            if (selectedSetting != null)
            {
                thread1 = new Thread(MyFunction);
                thread1.Start();


            }
            else
            {
                MessageBox.Show("Ayarlar boş bırakılmamalıdır!", "Uyarı");
            }
        }
        private void doorOpen_Click(object sender, EventArgs e)
        {
            if (writePort != null && writePort.IsOpen)
            {
                Logger("[DEBUG] Tanımsız giriş.");
            }
            openDoorFunc();
        }

        void openDoorFunc()
        {
            if (writePort != null && writePort.IsOpen)
            {

                writePort.Write("A");
                button1.Enabled = false;
                doorOpen.Enabled = false;
                Thread.Sleep(750);
                writePort.Write("BB");
                doorOpen.Enabled = true;
                button1.Enabled = true;

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (readPort != null && readPort.IsOpen)
            {
                readPort.DiscardInBuffer();
                readPort.DiscardOutBuffer();
                thread1.Join();
                readPort.Close();
                readPort.Dispose();
            }

            if (writePort != null && writePort.IsOpen)
            {
                writePort.DiscardInBuffer();
                writePort.DiscardOutBuffer();
                writePort.Close();
                writePort.Dispose();
            }
            if (thread1 != null && thread1.IsAlive)
                thread1.Abort();
            if (readPort != null && !readPort.IsOpen)
            {
                startButton.Enabled = true;
                button1.Enabled = false;
            }
            connectionStatus.Text = "Bağlantı Durduruldu";
        }

        private void Logger(string value)
        {
            if(selectedSetting == null)
            {
                selectedSetting = form2.LoadValueFromFile();

            }

            if (selectedSetting != null &&selectedSetting.debugMode == "True")
            {
                string exePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
                string settingsString = "debug.txt";
                string loggerFilePath = Path.Combine(Path.GetDirectoryName(exePath), settingsString);

                DateTime now = DateTime.Now;
                string formattedDateTime = now.ToString("dd-MM-yyyy HH:mm:ss");

                try
                {
                    using (StreamWriter writer = File.AppendText(loggerFilePath))
                    {
                        writer.WriteLine(formattedDateTime + " " + value);
                        writer.Flush();
                        writer.Close();
                    }
                }
                catch (IOException e)
                {
                    // exception handling left as an exercise for the reader
                }
            }

        }

        private string MakeRequest(string requestId, string requestedClubId)
        {
            Logger("[INFO] Kullanıcı kontrol [id: " + requestId + "]");
            StringBuilder body = null;
            string line = "";

            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)(0xc0 | 0x300 | 0xc00);
            ServicePointManager.ServerCertificateValidationCallback = ValidateServerCertificate;

            try
            {
                string url = "https://factoryathletic.com/panel/api/checkUser/" + requestedClubId + "/" + requestId;
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Timeout = 3000;
                request.KeepAlive = true;

                request.Method = "GET";

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                int responseCode = (int)response.StatusCode;
                Logger("[INFO] Kullanıcı kontrol response code: " + responseCode);

                if (responseCode == 200)
                {
                    using (StreamReader streamReader = new StreamReader(response.GetResponseStream()))
                    {
                        body = new StringBuilder();
                        while ((line = streamReader.ReadLine()) != null)
                            body.Append(line);
                    }
                }
            }
            catch (Exception e)
            {
                Logger("[ERROR] Kullanıcı kontrol hatası " + e.Message);
            }

            Logger("[INFO] Kullanıcı giriş api dönen cevap: " + body?.ToString());
            return body?.ToString();
        }
        private bool ValidateServerCertificate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            if (sslPolicyErrors == SslPolicyErrors.None)
                return true;
            else
                return false;
        }


    }


}
