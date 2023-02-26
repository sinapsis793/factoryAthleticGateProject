using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace factoryAthletic
{

    public partial class OptionsForm : Form
    {




        public OptionsForm()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void optionsButton_Click(object sender, EventArgs e)
        {

            if (readComPortCombo.SelectedItem != null && writeComboPort.SelectedItem != null && clupTextBox.Text != "")
            {
                SaveValueToFile("ComPortRead=" + readComPortCombo.SelectedItem + ":" + "ComPortWrite=" + writeComboPort.SelectedItem + ":" + "id=" + clupTextBox.Text + ":" + "Debug=" + debugCheckBox.Checked);

            }
            this.Hide();
            // do what you have to do
            //   logger("[INFO] Ayarlar kaydedildi.");

        }

        public Settings LoadValueFromFile()
        {
            string exePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string settingsString = "settings.txt";
            string settingsFilePath = Path.Combine(Path.GetDirectoryName(exePath), settingsString);
            string value = null;

            try
            {
                using (var reader = new StreamReader(settingsFilePath))
                {
                    value = reader.ReadLine();
                    reader.Close();
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }

            if (value != null)
            {

                string readport = value.Split(':')[0].Split('=')[1];
                string writeport = value.Split(':')[1].Split('=')[1];
                string clupID = value.Split(':')[2].Split('=')[1];
                string debugMode = value.Split(':')[3].Split('=')[1];
                Settings setting1 = new Settings(readport, writeport, clupID, debugMode);
                return setting1;

            }
            else
            {
                return null;
            }


        }
        private void SaveValueToFile(string value)
        {
            string exePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string settingsString = "settings.txt";
            string settingsFilePath = Path.Combine(Path.GetDirectoryName(exePath), settingsString);
            Console.WriteLine(settingsFilePath);
            try
            {
                using (StreamWriter writer = new StreamWriter(settingsFilePath))
                {
                    writer.WriteLine(value);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("[ERROR] " + e.Message);
            }
        }

        private void OptionsForm_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();

            foreach (string port in ports)
            {
                readComPortCombo.Items.Add(port);
                writeComboPort.Items.Add(port);
            }
            Settings setting = LoadValueFromFile();
            if (setting != null)
            {
                readComPortCombo.SelectedItem = setting.readPort;
                writeComboPort.SelectedItem = setting.writePort;
                clupTextBox.Text = setting.clupId;
                if (setting.debugMode == "True")
                {
                    debugCheckBox.Checked = true;

                }
                else
                {
                    debugCheckBox.Checked = false;

                }

            }

        }
    }
    public class Settings
    {
        public string readPort;
        public string writePort;
        public string clupId;
        public string debugMode;

        public Settings(string readPortVal, string writePortVal, string clupIdVal, string debugModeVal)
        {
            readPort = readPortVal;
            writePort = writePortVal;
            clupId = clupIdVal;
            debugMode = debugModeVal;
        }
    }
}
