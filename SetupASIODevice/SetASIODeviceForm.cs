using Microsoft.Win32;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SetupASIODevice
{
    public partial class SetASIODevice : Form
    {
        private readonly string audioDrivEnvVar = "WWISEASIODRV";
        private readonly string[] connectedDevices;

        public SetASIODevice()
        {
            InitializeComponent();
            connectedDevices = GetAudioDriverNames();
        }

        private void SetASIODeviceFormLoad(object sender, EventArgs e)
        {
            ASIODevicesListBox.Items.Clear();
            connectedDevices.ToList().ForEach(s => ASIODevicesListBox.Items.Add(s));

            string currDevice = Environment.GetEnvironmentVariable(audioDrivEnvVar);
            CurrentDeviceTextBox.Text = "Current Device: " + currDevice;
        }

        private void SelectDeviceButtonClick(object sender, EventArgs e)
        {
            string newDevice = (string)ASIODevicesListBox.SelectedItem;
            CurrentDeviceTextBox.Text = "Current Device: " + newDevice;
            Environment.SetEnvironmentVariable(audioDrivEnvVar, newDevice, EnvironmentVariableTarget.User);
        }

        private string[] GetAudioDriverNames()
        {
            string[] names = new string[0];

            using (var hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
            {
                using (var regKey = hklm.OpenSubKey(@"Software\ASIO"))
                {
                    if (regKey != null)
                    {
                        names = regKey.GetSubKeyNames();
                        regKey.Close();
                    }
                }
            }            

            return names;
        }
    }
}
