
namespace SetupASIODevice
{
    partial class SetASIODevice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SelectDeviceButton = new System.Windows.Forms.Button();
            this.ASIODevicesListBox = new System.Windows.Forms.ListBox();
            this.CurrentDeviceTextBox = new System.Windows.Forms.TextBox();
            this.RestartReminderLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SelectDeviceButton
            // 
            this.SelectDeviceButton.Location = new System.Drawing.Point(12, 60);
            this.SelectDeviceButton.Name = "SelectDeviceButton";
            this.SelectDeviceButton.Size = new System.Drawing.Size(321, 41);
            this.SelectDeviceButton.TabIndex = 0;
            this.SelectDeviceButton.Text = "Select New Device";
            this.SelectDeviceButton.UseVisualStyleBackColor = true;
            this.SelectDeviceButton.Click += new System.EventHandler(this.SelectDeviceButtonClick);
            // 
            // ASIODevicesListBox
            // 
            this.ASIODevicesListBox.FormattingEnabled = true;
            this.ASIODevicesListBox.Location = new System.Drawing.Point(12, 107);
            this.ASIODevicesListBox.Name = "ASIODevicesListBox";
            this.ASIODevicesListBox.Size = new System.Drawing.Size(321, 108);
            this.ASIODevicesListBox.TabIndex = 1;
            // 
            // CurrentDeviceTextBox
            // 
            this.CurrentDeviceTextBox.Location = new System.Drawing.Point(12, 12);
            this.CurrentDeviceTextBox.Multiline = true;
            this.CurrentDeviceTextBox.Name = "CurrentDeviceTextBox";
            this.CurrentDeviceTextBox.ReadOnly = true;
            this.CurrentDeviceTextBox.Size = new System.Drawing.Size(321, 42);
            this.CurrentDeviceTextBox.TabIndex = 2;
            this.CurrentDeviceTextBox.Text = "Current Device:";
            // 
            // RestartReminderLabel
            // 
            this.RestartReminderLabel.AutoSize = true;
            this.RestartReminderLabel.Location = new System.Drawing.Point(79, 218);
            this.RestartReminderLabel.Name = "RestartReminderLabel";
            this.RestartReminderLabel.Size = new System.Drawing.Size(183, 26);
            this.RestartReminderLabel.TabIndex = 3;
            this.RestartReminderLabel.Text = "You will need to restart your machine \r\nbefore changes can take affect";
            this.RestartReminderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SetASIODevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 251);
            this.Controls.Add(this.RestartReminderLabel);
            this.Controls.Add(this.CurrentDeviceTextBox);
            this.Controls.Add(this.ASIODevicesListBox);
            this.Controls.Add(this.SelectDeviceButton);
            this.Name = "SetASIODevice";
            this.Text = "SetASIODevice";
            this.Load += new System.EventHandler(this.SetASIODeviceFormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SelectDeviceButton;
        private System.Windows.Forms.ListBox ASIODevicesListBox;
        private System.Windows.Forms.TextBox CurrentDeviceTextBox;
        private System.Windows.Forms.Label RestartReminderLabel;
    }
}

