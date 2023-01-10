using Advanced_Combat_Tracker;
using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;

namespace ACT.CfFusen
{
    public partial class PluginBase : UserControl, IActPluginV1
    {
        Overlay formOverlay = null;

        string settingsFile = Path.Combine(ActGlobals.oFormActMain.AppDataFolder.FullName, "Config\\" + Assembly.GetExecutingAssembly().GetName().Name + ".config.xml");
        SettingsSerializer xmlSettings;

        public PluginBase()
        {
            InitializeComponent();
        }

        public void DeInitPlugin()
        {
            ActGlobals.oFormActMain.OnLogLineRead -= OnLogLineRead;
            formOverlay.Close();
        }

        public void InitPlugin(TabPage pluginScreenSpace, Label pluginStatusText)
        {
            pluginScreenSpace.Controls.Add(this);
            this.Dock = DockStyle.Fill;

            xmlSettings = new SettingsSerializer(this);
            LoadSettings();

            ActGlobals.oFormActMain.OnLogLineRead += OnLogLineRead;
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog()
            {
                Title = "フォルダを選択してください",
                InitialDirectory = textFusenDirectory.Text,
                FileName = "Folder Selection",
                Filter = "Folder|.",
                ValidateNames = false,
                CheckFileExists = false,
                CheckPathExists = true,
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textFusenDirectory.Text = Path.GetDirectoryName(ofd.FileName);
            }
            ofd.Dispose();
            SaveSettings();
        }

        private void checkboxOverlay_CheckStateChanged(object sender, EventArgs e)
        {
            if (((CheckBox)(sender)).CheckState == CheckState.Checked)
            {
                //LoadSettingsよりこっちが先に動く
                if (formOverlay == null)
                {
                    formOverlay = new Overlay();
                    if (!(textXpos1.Text.Equals(String.Empty)))
                    {
                        var position = new Point(int.Parse(textXpos1.Text), int.Parse(textYpos1.Text));
                        formOverlay.Location = position;
                    }
                    if (!(textHsize1.Text.Equals(String.Empty)))
                    {
                        formOverlay.Size = new Size(int.Parse(textWsize1.Text), int.Parse(textHsize1.Text));
                    }
                    formOverlay.TopMost = checkBoxFront.Checked;

                    formOverlay.Move += new EventHandler(formOverlay_Move);
                    formOverlay.Resize += new EventHandler(formOverlay_Resize);
                    formOverlay.Show();
                }
            }
            else
            {
                if (formOverlay != null)
                {
                    formOverlay.Close();
                    formOverlay = null;
                }
            }
            SaveSettings();
        }

        private void checkBoxFront_CheckStateChanged(object sender, EventArgs e)
        {
            if (formOverlay != null)
            {
                if (((CheckBox)(sender)).CheckState == CheckState.Checked)
                {
                    formOverlay.TopMost = true;
                }
                else
                {
                    formOverlay.TopMost = false;
                }
            }
            SaveSettings();
        }

        private void formOverlay_Move(object sender, EventArgs e)
        {
            textXpos1.Text = formOverlay.Left.ToString();
            textYpos1.Text = formOverlay.Top.ToString();

            textWsize1.Text = formOverlay.Width.ToString();
            textHsize1.Text = formOverlay.Height.ToString();
            SaveSettings();
        }

        private void formOverlay_Resize(object sender, EventArgs e)
        {
            textXpos1.Text = formOverlay.Left.ToString();
            textYpos1.Text = formOverlay.Top.ToString();

            textWsize1.Text = formOverlay.Width.ToString();
            textHsize1.Text = formOverlay.Height.ToString();
            SaveSettings();
        }

        private void OnLogLineRead(bool isImport, LogLineEventArgs logInfo)
        {
            if (isImport) return;

            FusenReadEventArgs fusenInfo = new FusenReadEventArgs();

            string[] logType = logInfo.logLine.Split(' ');
            string[] logMessage = logInfo.logLine.Split(new string[] { "::" }, StringSplitOptions.None);
            string chatLogType = "";

            if (logType.Length >= 3 && logType[2].Length >= 7)
            {
                chatLogType = logType[2].Substring(3, 4);
            }

            if ((logType[1].Equals("ChatLog")) && (chatLogType.Equals("0839")) && logMessage[1].IndexOf("の攻略を開始した。") >= 0)
            {
                if (this.textFusenDirectory.Text.Equals(string.Empty) || !Directory.Exists(this.textFusenDirectory.Text)) { return; }
                try
                {
                    Regex reg = new Regex("「(?<ContentsName>.*?)」.*", RegexOptions.IgnoreCase | RegexOptions.Singleline);
                    Match m = reg.Match(logMessage[1]);
                    fusenInfo.ContentName = m.Groups["ContentsName"].Value;
                    fusenInfo.FusenDirectory = textFusenDirectory.Text;

                    formOverlay.OnFusenReadp(this, fusenInfo);
                }
                catch (Exception ex)
                {
                    Logging.Exception(ex);
                }
            }
            else if ((logType[1].Equals("ChatLog")) && (chatLogType.Equals("0839")) && logMessage[1].IndexOf("の攻略を終了した。") >= 0)
            {
                formOverlay.OnFusenClearp(this, null);
            }
        }

        void LoadSettings()
        {
            xmlSettings.AddControlSetting(textXpos1.Name, textXpos1);
            xmlSettings.AddControlSetting(textYpos1.Name, textYpos1);
            xmlSettings.AddControlSetting(textWsize1.Name, textWsize1);
            xmlSettings.AddControlSetting(textHsize1.Name, textHsize1);
            xmlSettings.AddControlSetting(textFusenDirectory.Name, textFusenDirectory);
            xmlSettings.AddControlSetting(checkboxOverlay.Name, checkboxOverlay);

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
                    Logging.Exception(ex);
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
    }
}
