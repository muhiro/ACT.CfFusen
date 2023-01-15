namespace ACT.CfFusen
{
    partial class PluginBase
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.textXpos1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxFront = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textWsize1 = new System.Windows.Forms.TextBox();
            this.textHsize1 = new System.Windows.Forms.TextBox();
            this.checkboxOverlay = new System.Windows.Forms.CheckBox();
            this.textFusenDirectory = new System.Windows.Forms.TextBox();
            this.textYpos1 = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.checkBoxAuto = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(485, 18);
            this.buttonBrowse.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(100, 29);
            this.buttonBrowse.TabIndex = 0;
            this.buttonBrowse.Text = "参照";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // textXpos1
            // 
            this.textXpos1.Location = new System.Drawing.Point(336, 58);
            this.textXpos1.Margin = new System.Windows.Forms.Padding(4);
            this.textXpos1.Name = "textXpos1";
            this.textXpos1.Size = new System.Drawing.Size(39, 22);
            this.textXpos1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxAuto);
            this.groupBox1.Controls.Add(this.checkBoxFront);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textWsize1);
            this.groupBox1.Controls.Add(this.textHsize1);
            this.groupBox1.Controls.Add(this.checkboxOverlay);
            this.groupBox1.Controls.Add(this.textFusenDirectory);
            this.groupBox1.Controls.Add(this.textYpos1);
            this.groupBox1.Controls.Add(this.textXpos1);
            this.groupBox1.Controls.Add(this.buttonBrowse);
            this.groupBox1.Location = new System.Drawing.Point(27, 25);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(593, 123);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "コンテンツファインダー付箋";
            // 
            // checkBoxFront
            // 
            this.checkBoxFront.AutoSize = true;
            this.checkBoxFront.Checked = true;
            this.checkBoxFront.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxFront.Location = new System.Drawing.Point(170, 60);
            this.checkBoxFront.Name = "checkBoxFront";
            this.checkBoxFront.Size = new System.Drawing.Size(110, 19);
            this.checkBoxFront.TabIndex = 12;
            this.checkBoxFront.Text = "最前面にする";
            this.checkBoxFront.UseVisualStyleBackColor = true;
            this.checkBoxFront.CheckStateChanged += new System.EventHandler(this.checkBoxFront_CheckStateChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(521, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "W";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(451, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "H";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(382, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "X";
            // 
            // textWsize1
            // 
            this.textWsize1.Location = new System.Drawing.Point(546, 58);
            this.textWsize1.Margin = new System.Windows.Forms.Padding(4);
            this.textWsize1.Name = "textWsize1";
            this.textWsize1.Size = new System.Drawing.Size(39, 22);
            this.textWsize1.TabIndex = 6;
            // 
            // textHsize1
            // 
            this.textHsize1.Location = new System.Drawing.Point(475, 58);
            this.textHsize1.Margin = new System.Windows.Forms.Padding(4);
            this.textHsize1.Name = "textHsize1";
            this.textHsize1.Size = new System.Drawing.Size(39, 22);
            this.textHsize1.TabIndex = 5;
            // 
            // checkboxOverlay
            // 
            this.checkboxOverlay.AutoSize = true;
            this.checkboxOverlay.Location = new System.Drawing.Point(8, 60);
            this.checkboxOverlay.Margin = new System.Windows.Forms.Padding(4);
            this.checkboxOverlay.Name = "checkboxOverlay";
            this.checkboxOverlay.Size = new System.Drawing.Size(142, 19);
            this.checkboxOverlay.TabIndex = 4;
            this.checkboxOverlay.Text = "Overlayを表示する";
            this.checkboxOverlay.UseVisualStyleBackColor = true;
            this.checkboxOverlay.CheckStateChanged += new System.EventHandler(this.checkboxOverlay_CheckStateChanged);
            // 
            // textFusenDirectory
            // 
            this.textFusenDirectory.Location = new System.Drawing.Point(8, 22);
            this.textFusenDirectory.Margin = new System.Windows.Forms.Padding(4);
            this.textFusenDirectory.Name = "textFusenDirectory";
            this.textFusenDirectory.Size = new System.Drawing.Size(469, 22);
            this.textFusenDirectory.TabIndex = 3;
            // 
            // textYpos1
            // 
            this.textYpos1.Location = new System.Drawing.Point(405, 58);
            this.textYpos1.Margin = new System.Windows.Forms.Padding(4);
            this.textYpos1.Name = "textYpos1";
            this.textYpos1.Size = new System.Drawing.Size(39, 22);
            this.textYpos1.TabIndex = 2;
            // 
            // checkBoxAuto
            // 
            this.checkBoxAuto.AutoSize = true;
            this.checkBoxAuto.Checked = true;
            this.checkBoxAuto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAuto.Location = new System.Drawing.Point(8, 87);
            this.checkBoxAuto.Name = "checkBoxAuto";
            this.checkBoxAuto.Size = new System.Drawing.Size(382, 19);
            this.checkBoxAuto.TabIndex = 13;
            this.checkBoxAuto.Text = "コンテンツに入ったら自動で表示して終わったら自動で非表示";
            this.checkBoxAuto.UseVisualStyleBackColor = true;
            this.checkBoxAuto.CheckStateChanged += new System.EventHandler(this.checkBoxAuto_CheckStateChanged);
            // 
            // PluginBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PluginBase";
            this.Size = new System.Drawing.Size(647, 191);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.TextBox textXpos1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textFusenDirectory;
        private System.Windows.Forms.TextBox textYpos1;
        private System.Windows.Forms.CheckBox checkboxOverlay;
        private System.Windows.Forms.TextBox textWsize1;
        private System.Windows.Forms.TextBox textHsize1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxFront;
        private System.Windows.Forms.CheckBox checkBoxAuto;
    }
}
