using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ACT.CfFusen
{
    public partial class Overlay : Form
    {
        public event EventHandler<FusenReadEventArgs> OnFusenRead;
        public string FusenDirectory;
        public Overlay()
        {
            InitializeComponent();

            this.OnFusenRead += Overlay_OnFusenRead;

            this.StartPosition = FormStartPosition.Manual;
            //this.TransparencyKey = this.BackColor;
            this.BackColor = Color.Black;
            this.Opacity = 0.75D;
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;

            this.panel1.BackColor = Color.Black;

            this.labelTitle.Text = String.Empty;

            this.richTextFusen.BackColor = Color.Black;
            this.richTextFusen.ForeColor = Color.White;
            this.richTextFusen.DetectUrls = true;
            this.richTextFusen.ReadOnly = true;
        }

        const int CS_DROPSHADOW = 0x00020000;
        const int WS_BORDER = 0x00800000;
        protected override CreateParams CreateParams
        {
            get
            {
                //枠だけのフォーム
                CreateParams cp = base.CreateParams;
                if (this.FormBorderStyle != FormBorderStyle.None)
                {
                    cp.Style = cp.Style & (~WS_BORDER);
                }
                return cp;
            }
        }

        public void OnFusenReadp(object sender, FusenReadEventArgs args)
        {
            this.OnFusenRead(sender, args);
        }

        public void OnFusenClearp(object sender, FusenReadEventArgs args)
        {
            this.labelTitle.Text = "";
            this.richTextFusen.Clear();
            this.richTextFusen.ReadOnly = true;
        }
        public void Overlay_OnFusenRead(object sender, FusenReadEventArgs args)
        {
            if (String.IsNullOrEmpty(args.ContentName) || String.IsNullOrEmpty(args.FusenDirectory))
            {
                return;
            }
            this.labelTitle.Text = args.ContentName;
            this.FusenDirectory = args.FusenDirectory;
            string fusenPath = args.FusenDirectory + @"\" + args.ContentName + ".rtf";

            this.richTextFusen.Clear();
            try
            {
                this.richTextFusen.LoadFile(fusenPath, RichTextBoxStreamType.RichText);

                this.richTextFusen.ReadOnly = true;
                this.richTextFusen.DetectUrls = true;
            }
            catch (FileNotFoundException)
            {
                this.richTextFusen.SaveFile(fusenPath, RichTextBoxStreamType.RichText);

                this.richTextFusen.ReadOnly = true;
                this.richTextFusen.DetectUrls = true;
            }
            catch (IOException ex)
            {
                Logging.Exception(ex);
                this.richTextFusen.ReadOnly = true;
                this.richTextFusen.SelectionColor = Color.Red;
                this.richTextFusen.AppendText("ファイルが開かれています。\nファイルを閉じて再読み込みしてください。\n" + fusenPath);
            }
            catch (Exception ex)
            {
                Logging.Exception(ex);
                this.richTextFusen.ReadOnly = true;
                this.richTextFusen.SelectionColor = Color.Red;
                this.richTextFusen.AppendText("ファイルが開けませんでした。\n" + fusenPath);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            this.richTextFusen.Clear();
        }

        private void richTextChatLog_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }

        private Point mouseMovePoint;
        private void OverlayMove_MouseDown(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                //位置を記憶する
                mouseMovePoint = new Point(e.X, e.Y);
            }
        }

        private void OverlayMove_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                this.Left += e.X - mouseMovePoint.X;
                this.Top += e.Y - mouseMovePoint.Y;
            }
        }

        private Point mouseResizePoint;
        private void OverlayResize_MouseDown(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                //位置を記憶する
                mouseResizePoint = new Point(e.X, e.Y);
            }
        }

        private void OverlayResize_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                this.Width += e.X - mouseResizePoint.X;
                this.Height += e.Y - mouseResizePoint.Y;
            }
        }

        private void pictureBoxReload_Click(object sender, EventArgs e)
        {
            FusenReadEventArgs args = new FusenReadEventArgs();
            args.ContentName = this.labelTitle.Text;
            args.FusenDirectory = this.FusenDirectory;

            this.OnFusenRead(sender, args);
        }
    }

    public class FusenReadEventArgs
    {
        public string ContentName { get; set; }
        public string FusenDirectory { get; set; }
    }
}
