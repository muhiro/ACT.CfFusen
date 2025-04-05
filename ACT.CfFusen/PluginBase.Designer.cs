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
            this.labelTemplateFusen = new System.Windows.Forms.Label();
            this.buttonBrowseTemplateFile = new System.Windows.Forms.Button();
            this.textTemplateFusen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelDefaultFusen = new System.Windows.Forms.Label();
            this.buttonBrowseFile = new System.Windows.Forms.Button();
            this.textDefaultFusen = new System.Windows.Forms.TextBox();
            this.checkBoxAuto = new System.Windows.Forms.CheckBox();
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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(485, 19);
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
            this.textXpos1.Location = new System.Drawing.Point(336, 138);
            this.textXpos1.Margin = new System.Windows.Forms.Padding(4);
            this.textXpos1.Name = "textXpos1";
            this.textXpos1.Size = new System.Drawing.Size(39, 22);
            this.textXpos1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelTemplateFusen);
            this.groupBox1.Controls.Add(this.buttonBrowseTemplateFile);
            this.groupBox1.Controls.Add(this.textTemplateFusen);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.labelDefaultFusen);
            this.groupBox1.Controls.Add(this.buttonBrowseFile);
            this.groupBox1.Controls.Add(this.textDefaultFusen);
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
            this.groupBox1.Size = new System.Drawing.Size(593, 236);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "コンテンツファインダー付箋";
            // 
            // labelTemplateFusen
            // 
            this.labelTemplateFusen.AutoSize = true;
            this.labelTemplateFusen.Location = new System.Drawing.Point(7, 100);
            this.labelTemplateFusen.Name = "labelTemplateFusen";
            this.labelTemplateFusen.Size = new System.Drawing.Size(116, 15);
            this.labelTemplateFusen.TabIndex = 20;
            this.labelTemplateFusen.Text = "付箋のテンプレート";
            // 
            // buttonBrowseTemplateFile
            // 
            this.buttonBrowseTemplateFile.Location = new System.Drawing.Point(485, 93);
            this.buttonBrowseTemplateFile.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBrowseTemplateFile.Name = "buttonBrowseTemplateFile";
            this.buttonBrowseTemplateFile.Size = new System.Drawing.Size(100, 29);
            this.buttonBrowseTemplateFile.TabIndex = 19;
            this.buttonBrowseTemplateFile.Text = "参照";
            this.buttonBrowseTemplateFile.UseVisualStyleBackColor = true;
            this.buttonBrowseTemplateFile.Click += new System.EventHandler(this.buttonBrowseTemplateFile_Click);
            // 
            // textTemplateFusen
            // 
            this.textTemplateFusen.Location = new System.Drawing.Point(135, 97);
            this.textTemplateFusen.Margin = new System.Windows.Forms.Padding(4);
            this.textTemplateFusen.Name = "textTemplateFusen";
            this.textTemplateFusen.Size = new System.Drawing.Size(342, 22);
            this.textTemplateFusen.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "付箋ディレクトリ";
            // 
            // labelDefaultFusen
            // 
            this.labelDefaultFusen.AutoSize = true;
            this.labelDefaultFusen.Location = new System.Drawing.Point(7, 63);
            this.labelDefaultFusen.Name = "labelDefaultFusen";
            this.labelDefaultFusen.Size = new System.Drawing.Size(121, 15);
            this.labelDefaultFusen.TabIndex = 16;
            this.labelDefaultFusen.Text = "通常表示する付箋";
            // 
            // buttonBrowseFile
            // 
            this.buttonBrowseFile.Location = new System.Drawing.Point(485, 56);
            this.buttonBrowseFile.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBrowseFile.Name = "buttonBrowseFile";
            this.buttonBrowseFile.Size = new System.Drawing.Size(100, 29);
            this.buttonBrowseFile.TabIndex = 15;
            this.buttonBrowseFile.Text = "参照";
            this.buttonBrowseFile.UseVisualStyleBackColor = true;
            this.buttonBrowseFile.Click += new System.EventHandler(this.buttonBrowseFile_Click);
            // 
            // textDefaultFusen
            // 
            this.textDefaultFusen.Location = new System.Drawing.Point(135, 60);
            this.textDefaultFusen.Margin = new System.Windows.Forms.Padding(4);
            this.textDefaultFusen.Name = "textDefaultFusen";
            this.textDefaultFusen.Size = new System.Drawing.Size(342, 22);
            this.textDefaultFusen.TabIndex = 14;
            // 
            // checkBoxAuto
            // 
            this.checkBoxAuto.AutoSize = true;
            this.checkBoxAuto.Checked = true;
            this.checkBoxAuto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAuto.Location = new System.Drawing.Point(7, 187);
            this.checkBoxAuto.Name = "checkBoxAuto";
            this.checkBoxAuto.Size = new System.Drawing.Size(382, 19);
            this.checkBoxAuto.TabIndex = 13;
            this.checkBoxAuto.Text = "コンテンツに入ったら自動で表示して終わったら自動で非表示";
            this.checkBoxAuto.UseVisualStyleBackColor = true;
            this.checkBoxAuto.CheckStateChanged += new System.EventHandler(this.checkBoxAuto_CheckStateChanged);
            // 
            // checkBoxFront
            // 
            this.checkBoxFront.AutoSize = true;
            this.checkBoxFront.Checked = true;
            this.checkBoxFront.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxFront.Location = new System.Drawing.Point(170, 140);
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
            this.label4.Location = new System.Drawing.Point(521, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "W";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(451, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "H";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(382, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "X";
            // 
            // textWsize1
            // 
            this.textWsize1.Location = new System.Drawing.Point(546, 138);
            this.textWsize1.Margin = new System.Windows.Forms.Padding(4);
            this.textWsize1.Name = "textWsize1";
            this.textWsize1.Size = new System.Drawing.Size(39, 22);
            this.textWsize1.TabIndex = 6;
            // 
            // textHsize1
            // 
            this.textHsize1.Location = new System.Drawing.Point(475, 138);
            this.textHsize1.Margin = new System.Windows.Forms.Padding(4);
            this.textHsize1.Name = "textHsize1";
            this.textHsize1.Size = new System.Drawing.Size(39, 22);
            this.textHsize1.TabIndex = 5;
            // 
            // checkboxOverlay
            // 
            this.checkboxOverlay.AutoSize = true;
            this.checkboxOverlay.Location = new System.Drawing.Point(8, 140);
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
            this.textFusenDirectory.Location = new System.Drawing.Point(135, 23);
            this.textFusenDirectory.Margin = new System.Windows.Forms.Padding(4);
            this.textFusenDirectory.Name = "textFusenDirectory";
            this.textFusenDirectory.Size = new System.Drawing.Size(342, 22);
            this.textFusenDirectory.TabIndex = 3;
            // 
            // textYpos1
            // 
            this.textYpos1.Location = new System.Drawing.Point(405, 138);
            this.textYpos1.Margin = new System.Windows.Forms.Padding(4);
            this.textYpos1.Name = "textYpos1";
            this.textYpos1.Size = new System.Drawing.Size(39, 22);
            this.textYpos1.TabIndex = 2;
            // 
            // PluginBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PluginBase";
            this.Size = new System.Drawing.Size(647, 300);
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelDefaultFusen;
        private System.Windows.Forms.Button buttonBrowseFile;
        private System.Windows.Forms.TextBox textDefaultFusen;
        private System.Windows.Forms.Label labelTemplateFusen;
        private System.Windows.Forms.Button buttonBrowseTemplateFile;
        private System.Windows.Forms.TextBox textTemplateFusen;
    }
}
