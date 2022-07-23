using Advanced_Combat_Tracker;
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

[assembly: AssemblyTitle("UFHT Plugin")]
[assembly: AssemblyDescription("Plugin for UFHT hunt tracker")]
[assembly: AssemblyCompany("https://github.com/imaginary-png/a-ffxiv-hunt-tracker.ACT")]
[assembly: AssemblyCopyright("https://github.com/imaginary-png/a-ffxiv-hunt-tracker.ACT")]
[assembly: AssemblyVersion("1.0.0")]

namespace UFHT_Plugin
{
    public class UFHTPlugin : UserControl, IActPluginV1
    {
        #region Designer Created Code (Avoid editing)
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UFHTPlugin));
            this.label1 = new System.Windows.Forms.Label();
            this.UFHT_DIR_PATH = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.usageInformation = new System.Windows.Forms.Label();
            this.gitHubLink = new System.Windows.Forms.LinkLabel();
            this.requirementLabel = new System.Windows.Forms.Label();
            this.ufhtLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AccessibleName = "UFHT Directory Path Title";
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "UFHT Directory Path:";
            // 
            // UFHT_DIR_PATH
            // 
            this.UFHT_DIR_PATH.AccessibleDescription = "Paste in the directory for ufht-UI.exe here";
            this.UFHT_DIR_PATH.AccessibleName = "UFHT Directory Path";
            this.UFHT_DIR_PATH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.UFHT_DIR_PATH.Location = new System.Drawing.Point(26, 47);
            this.UFHT_DIR_PATH.Name = "UFHT_DIR_PATH";
            this.UFHT_DIR_PATH.Size = new System.Drawing.Size(431, 23);
            this.UFHT_DIR_PATH.TabIndex = 1;
            this.UFHT_DIR_PATH.Text = "Paste the folder directory of ufht-UI.exe here";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(556, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // usageInformation
            // 
            this.usageInformation.AccessibleDescription = "Type \'/ufht\' into chat to open UFHT.";
            this.usageInformation.AccessibleName = "How To Use";
            this.usageInformation.AutoSize = true;
            this.usageInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usageInformation.Location = new System.Drawing.Point(26, 114);
            this.usageInformation.Name = "usageInformation";
            this.usageInformation.Size = new System.Drawing.Size(748, 68);
            this.usageInformation.TabIndex = 3;
            this.usageInformation.Text = resources.GetString("usageInformation.Text");
            // 
            // gitHubLink
            // 
            this.gitHubLink.AccessibleDescription = "Link to the Plugins GitHub Page";
            this.gitHubLink.AccessibleName = "GitHub Link";
            this.gitHubLink.AutoSize = true;
            this.gitHubLink.Location = new System.Drawing.Point(26, 194);
            this.gitHubLink.Name = "gitHubLink";
            this.gitHubLink.Size = new System.Drawing.Size(40, 13);
            this.gitHubLink.TabIndex = 4;
            this.gitHubLink.TabStop = true;
            this.gitHubLink.Text = "GitHub";
            this.gitHubLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.gitHubLink_LinkClicked);
            // 
            // requirementLabel
            // 
            this.requirementLabel.AccessibleDescription = "Requires UFHT program";
            this.requirementLabel.AccessibleName = "Requirements";
            this.requirementLabel.AutoSize = true;
            this.requirementLabel.Location = new System.Drawing.Point(26, 328);
            this.requirementLabel.Name = "requirementLabel";
            this.requirementLabel.Size = new System.Drawing.Size(149, 13);
            this.requirementLabel.TabIndex = 5;
            this.requirementLabel.Text = "Requires the UFHT program - ";
            // 
            // ufhtLink
            // 
            this.ufhtLink.AccessibleDescription = "Link to the UFHT GitHub page";
            this.ufhtLink.AccessibleName = "UFHT GitHub Link";
            this.ufhtLink.AutoSize = true;
            this.ufhtLink.Location = new System.Drawing.Point(172, 328);
            this.ufhtLink.Name = "ufhtLink";
            this.ufhtLink.Size = new System.Drawing.Size(40, 13);
            this.ufhtLink.TabIndex = 6;
            this.ufhtLink.TabStop = true;
            this.ufhtLink.Text = "GitHub";
            this.ufhtLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ufhtLink_LinkClicked);
            // 
            // UFHTPlugin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ufhtLink);
            this.Controls.Add(this.requirementLabel);
            this.Controls.Add(this.gitHubLink);
            this.Controls.Add(this.usageInformation);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.UFHT_DIR_PATH);
            this.Controls.Add(this.label1);
            this.Name = "UFHTPlugin";
            this.Size = new System.Drawing.Size(725, 395);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox UFHT_DIR_PATH;
        private Button button1;
        private Label usageInformation;
        private LinkLabel gitHubLink;
        private Label requirementLabel;
        private LinkLabel ufhtLink;
        private System.Windows.Forms.Label label1;


        #endregion


        public UFHTPlugin()
        {
            InitializeComponent();
        }

        Label lblStatus;    // The status label that appears in ACT's Plugin tab
        string settingsFile = Path.Combine(ActGlobals.oFormActMain.AppDataFolder.FullName, "Config\\UFHT.config.xml");
        SettingsSerializer xmlSettings;

        #region IActPluginV1 Members
        public void InitPlugin(TabPage pluginScreenSpace, Label pluginStatusText)
        {
            lblStatus = pluginStatusText;   // Hand the status label's reference to our local var
            pluginScreenSpace.Controls.Add(this);   // Add this UserControl to the tab ACT provides
            this.Dock = DockStyle.Fill; // Expand the UserControl to fill the tab's client space
            xmlSettings = new SettingsSerializer(this); // Create a new settings serializer and pass it this instance
            LoadSettings();

            lblStatus.Text = "Plugin Started <^owo^>";

            ActGlobals.oFormActMain.OnLogLineRead += OFormActMain_OnLogLineRead;
        }
        private void OFormActMain_OnLogLineRead(bool isImport, LogLineEventArgs logInfo)
        {

            var rg = new Regex(@"^\[.*\] ChatLog 00:003C::The command ((?i)\/ufht) does not exist.");

            if (rg.IsMatch(logInfo.logLine))
            {
                Debug.Write($"\n==============================================\n" +
                            $"{logInfo.logLine}\n" +
                            $"==================================================");
                StartUFHT_Program();
            }

            //Debug.WriteLine(logInfo.logLine);
        }

        public void DeInitPlugin()
        {
            // Unsubscribe from any events you listen to when exiting!
            ActGlobals.oFormActMain.OnLogLineRead -= OFormActMain_OnLogLineRead;

            SaveSettings();
            lblStatus.Text = "Plugin Exited";
        }
        #endregion

        void LoadSettings()
        {
            // Add any controls you want to save the state of
            xmlSettings.AddControlSetting(UFHT_DIR_PATH.Name, UFHT_DIR_PATH);

            if (File.Exists(settingsFile))
            {
                FileStream fs = new FileStream(settingsFile, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                XmlTextReader xReader = new XmlTextReader(fs);

                try
                {
                    while (xReader.Read())
                    {
                        if (xReader.NodeType == XmlNodeType.Element)
                        {
                            if (xReader.LocalName == "SettingsSerializer")
                            {
                                xmlSettings.ImportFromXml(xReader);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    lblStatus.Text = "Error loading settings: " + ex.Message;
                }
                xReader.Close();
            }
        }
        void SaveSettings()
        {
            FileStream fs = new FileStream(settingsFile, FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
            XmlTextWriter xWriter = new XmlTextWriter(fs, Encoding.UTF8);
            xWriter.Formatting = Formatting.Indented;
            xWriter.Indentation = 1;
            xWriter.IndentChar = '\t';
            xWriter.WriteStartDocument(true);
            xWriter.WriteStartElement("Config");    // <Config>
            xWriter.WriteStartElement("SettingsSerializer");    // <Config><SettingsSerializer>
            xmlSettings.ExportToXml(xWriter);   // Fill the SettingsSerializer XML
            xWriter.WriteEndElement();  // </SettingsSerializer>
            xWriter.WriteEndElement();  // </Config>
            xWriter.WriteEndDocument(); // Tie up loose ends (shouldn't be any)
            xWriter.Flush();    // Flush the file buffer to disk
            xWriter.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            //testWindow.Visibility = testWindow.Visibility == Visibility.Hidden ? Visibility.Visible : Visibility.Hidden;
        }

        private void StartUFHT_Program()
        {
            if (!File.Exists(UFHT_DIR_PATH.Text + "\\ufht-UI.exe"))
            {
                MessageBox.Show("Unable to find ufht-UI.exe. Please recheck you directory path", "UFHT - exe not found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Process process = new Process();
            process.StartInfo.FileName = this.UFHT_DIR_PATH.Text + "\\ufht-UI.exe";
            process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
            process.StartInfo.WorkingDirectory = UFHT_DIR_PATH.Text;
            process.Start();
            
            
        }

        private void gitHubLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/imaginary-png/a-ffxiv-hunt-tracker.ACT");
        }

        private void ufhtLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/imaginary-png/a-ffxiv-hunt-tracker");
        }
    }
}
