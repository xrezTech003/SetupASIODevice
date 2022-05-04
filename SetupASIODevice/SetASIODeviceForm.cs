using Microsoft.Win32;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SetupASIODevice
{
    public partial class SetASIODevice : Form
    {
        /// <summary>
        /// enviornmental variable to be set
        /// </summary>
        private readonly string audioDrivEnvVar = "WWISEASIODRV";

        /// <summary>
        /// list of all audio devices
        /// </summary>
        private readonly string[] connectedDevices;

        /// <summary>
        /// on application startup
        /// </summary>
        public SetASIODevice()
        {
            // init application components
            InitializeComponent();

            // grab all drivers
            connectedDevices = GetAudioDriverNames();
        }

        /// <summary>
        /// on form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SetASIODeviceFormLoad(object sender, EventArgs e)
        {
            // clear listbox items and add all drivers as selectable options
            ASIODevicesListBox.Items.Clear();
            connectedDevices.ToList().ForEach(s => ASIODevicesListBox.Items.Add(s));

            // display current value of environmental variable
            string currDevice = Environment.GetEnvironmentVariable(audioDrivEnvVar);
            CurrentDeviceTextBox.Text = "Current Device: " + currDevice;
        }

        /// <summary>
        /// on button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectDeviceButtonClick(object sender, EventArgs e)
        {
            // grab selected item and set env var to this item
            string newDevice = (string)ASIODevicesListBox.SelectedItem;
            CurrentDeviceTextBox.Text = "Current Device: " + newDevice;
            Environment.SetEnvironmentVariable(audioDrivEnvVar, newDevice, EnvironmentVariableTarget.User);
        }

        /// <summary>
        /// get all drivers
        /// </summary>
        /// <returns></returns>
        private string[] GetAudioDriverNames()
        {
            string[] names = new string[0];

            // look through 64bit registry
            using (var hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
            {
                // look under ASIO devices
                using (var regKey = hklm.OpenSubKey(@"Software\ASIO"))
                {
                    // get all driver names
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
