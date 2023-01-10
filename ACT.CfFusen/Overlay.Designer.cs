namespace ACT.CfFusen
{
    partial class Overlay
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
            this.components = new System.ComponentModel.Container();
            this.richTextFusen = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.クリアToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.pictureBoxReload = new System.Windows.Forms.PictureBox();
            this.pictureBoxResize = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResize)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextFusen
            // 
            this.richTextFusen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextFusen.ContextMenuStrip = this.contextMenuStrip1;
            this.richTextFusen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextFusen.Font = new System.Drawing.Font("ＭＳ ゴシック", 10.5F);
            this.richTextFusen.Location = new System.Drawing.Point(0, 28);
            this.richTextFusen.Margin = new System.Windows.Forms.Padding(4);
            this.richTextFusen.Name = "richTextFusen";
            this.richTextFusen.Size = new System.Drawing.Size(740, 283);
            this.richTextFusen.TabIndex = 0;
            this.richTextFusen.Text = "";
            this.richTextFusen.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richTextChatLog_LinkClicked);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.クリアToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(113, 28);
            // 
            // クリアToolStripMenuItem
            // 
            this.クリアToolStripMenuItem.Name = "クリアToolStripMenuItem";
            this.クリアToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.クリアToolStripMenuItem.Text = "クリア";
            this.クリアToolStripMenuItem.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelTitle);
            this.panel1.Controls.Add(this.pictureBoxReload);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 28);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OverlayMove_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OverlayMove_MouseMove);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelTitle.Font = new System.Drawing.Font("ＭＳ ゴシック", 10F);
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Padding = new System.Windows.Forms.Padding(5, 2, 0, 0);
            this.labelTitle.Size = new System.Drawing.Size(67, 19);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "テスト";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OverlayMove_MouseDown);
            this.labelTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OverlayMove_MouseMove);
            // 
            // pictureBoxReload
            // 
            this.pictureBoxReload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxReload.Image = global::ACT.CfFusen.Properties.Resources.reload;
            this.pictureBoxReload.Location = new System.Drawing.Point(711, 3);
            this.pictureBoxReload.Name = "pictureBoxReload";
            this.pictureBoxReload.Size = new System.Drawing.Size(19, 19);
            this.pictureBoxReload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxReload.TabIndex = 1;
            this.pictureBoxReload.TabStop = false;
            this.pictureBoxReload.Click += new System.EventHandler(this.pictureBoxReload_Click);
            // 
            // pictureBoxResize
            // 
            this.pictureBoxResize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxResize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxResize.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.pictureBoxResize.Image = global::ACT.CfFusen.Properties.Resources.resize;
            this.pictureBoxResize.Location = new System.Drawing.Point(710, 281);
            this.pictureBoxResize.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxResize.Name = "pictureBoxResize";
            this.pictureBoxResize.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxResize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxResize.TabIndex = 2;
            this.pictureBoxResize.TabStop = false;
            this.pictureBoxResize.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OverlayResize_MouseDown);
            this.pictureBoxResize.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OverlayResize_MouseMove);
            // 
            // Overlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(740, 311);
            this.Controls.Add(this.pictureBoxResize);
            this.Controls.Add(this.richTextFusen);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Overlay";
            this.Text = "FusenOverlay";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OverlayMove_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OverlayMove_MouseMove);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextFusen;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem クリアToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBoxResize;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox pictureBoxReload;
        private System.Windows.Forms.Panel panel1;
    }
}