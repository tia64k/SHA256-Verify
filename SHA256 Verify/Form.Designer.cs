namespace SHA256_Verify
{
    partial class Form
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
            this.tab = new System.Windows.Forms.TabControl();
            this.generateTab = new System.Windows.Forms.TabPage();
            this.compareTab = new System.Windows.Forms.TabPage();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.fileComboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.selectFile1Button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.generateChecksumBox = new System.Windows.Forms.TextBox();
            this.compareChecksumBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.selectFile2Button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.fileComboBox2 = new System.Windows.Forms.ComboBox();
            this.selectFile3Button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.fileComboBox3 = new System.Windows.Forms.ComboBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.compareButton = new System.Windows.Forms.Button();
            this.tab.SuspendLayout();
            this.generateTab.SuspendLayout();
            this.compareTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab
            // 
            this.tab.Controls.Add(this.generateTab);
            this.tab.Controls.Add(this.compareTab);
            this.tab.Location = new System.Drawing.Point(12, 12);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(607, 242);
            this.tab.TabIndex = 0;
            this.tab.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // generateTab
            // 
            this.generateTab.Controls.Add(this.generateButton);
            this.generateTab.Controls.Add(this.generateChecksumBox);
            this.generateTab.Controls.Add(this.label2);
            this.generateTab.Controls.Add(this.selectFile1Button);
            this.generateTab.Controls.Add(this.label1);
            this.generateTab.Controls.Add(this.fileComboBox1);
            this.generateTab.Location = new System.Drawing.Point(4, 25);
            this.generateTab.Name = "generateTab";
            this.generateTab.Size = new System.Drawing.Size(599, 213);
            this.generateTab.TabIndex = 0;
            this.generateTab.Text = "Generate SHA256";
            this.generateTab.UseVisualStyleBackColor = true;
            // 
            // compareTab
            // 
            this.compareTab.Controls.Add(this.compareButton);
            this.compareTab.Controls.Add(this.selectFile3Button);
            this.compareTab.Controls.Add(this.label5);
            this.compareTab.Controls.Add(this.fileComboBox3);
            this.compareTab.Controls.Add(this.compareChecksumBox);
            this.compareTab.Controls.Add(this.label3);
            this.compareTab.Controls.Add(this.selectFile2Button);
            this.compareTab.Controls.Add(this.label4);
            this.compareTab.Controls.Add(this.fileComboBox2);
            this.compareTab.Location = new System.Drawing.Point(4, 25);
            this.compareTab.Name = "compareTab";
            this.compareTab.Size = new System.Drawing.Size(599, 213);
            this.compareTab.TabIndex = 1;
            this.compareTab.Text = "Compare SHA256 with file";
            this.compareTab.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "All files (*.*)|*.*";
            this.openFileDialog1.FilterIndex = 0;
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            this.openFileDialog2.Filter = "SHA256 checksum files|*.sha256";
            this.openFileDialog2.FilterIndex = 0;
            // 
            // fileComboBox1
            // 
            this.fileComboBox1.Location = new System.Drawing.Point(17, 41);
            this.fileComboBox1.Name = "fileComboBox1";
            this.fileComboBox1.Size = new System.Drawing.Size(459, 24);
            this.fileComboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "File";
            // 
            // selectFile1Button
            // 
            this.selectFile1Button.Location = new System.Drawing.Point(482, 41);
            this.selectFile1Button.Name = "selectFile1Button";
            this.selectFile1Button.Size = new System.Drawing.Size(110, 24);
            this.selectFile1Button.TabIndex = 2;
            this.selectFile1Button.Text = "Select file...";
            this.selectFile1Button.UseVisualStyleBackColor = true;
            this.selectFile1Button.Click += new System.EventHandler(this.selectFile1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "SHA256 checksum";
            // 
            // generateChecksumBox
            // 
            this.generateChecksumBox.Location = new System.Drawing.Point(14, 163);
            this.generateChecksumBox.Name = "generateChecksumBox";
            this.generateChecksumBox.Size = new System.Drawing.Size(575, 22);
            this.generateChecksumBox.TabIndex = 4;
            // 
            // compareChecksumBox
            // 
            this.compareChecksumBox.Location = new System.Drawing.Point(14, 163);
            this.compareChecksumBox.Multiline = true;
            this.compareChecksumBox.Name = "compareChecksumBox";
            this.compareChecksumBox.Size = new System.Drawing.Size(575, 47);
            this.compareChecksumBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "SHA256 checksum";
            // 
            // selectFile2Button
            // 
            this.selectFile2Button.Location = new System.Drawing.Point(478, 29);
            this.selectFile2Button.Name = "selectFile2Button";
            this.selectFile2Button.Size = new System.Drawing.Size(110, 24);
            this.selectFile2Button.TabIndex = 7;
            this.selectFile2Button.Text = "Select file...";
            this.selectFile2Button.UseVisualStyleBackColor = true;
            this.selectFile2Button.Click += new System.EventHandler(this.selectFile2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "SHA256 file";
            // 
            // fileComboBox2
            // 
            this.fileComboBox2.Location = new System.Drawing.Point(14, 29);
            this.fileComboBox2.Name = "fileComboBox2";
            this.fileComboBox2.Size = new System.Drawing.Size(459, 24);
            this.fileComboBox2.TabIndex = 5;
            // 
            // selectFile3Button
            // 
            this.selectFile3Button.Location = new System.Drawing.Point(478, 76);
            this.selectFile3Button.Name = "selectFile3Button";
            this.selectFile3Button.Size = new System.Drawing.Size(110, 24);
            this.selectFile3Button.TabIndex = 12;
            this.selectFile3Button.Text = "Select file...";
            this.selectFile3Button.UseVisualStyleBackColor = true;
            this.selectFile3Button.Click += new System.EventHandler(this.selectFile3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "File";
            // 
            // fileComboBox3
            // 
            this.fileComboBox3.Location = new System.Drawing.Point(14, 76);
            this.fileComboBox3.Name = "fileComboBox3";
            this.fileComboBox3.Size = new System.Drawing.Size(459, 24);
            this.fileComboBox3.TabIndex = 10;
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(17, 90);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(132, 24);
            this.generateButton.TabIndex = 5;
            this.generateButton.Text = "Generate SHA256";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // compareButton
            // 
            this.compareButton.Location = new System.Drawing.Point(14, 110);
            this.compareButton.Name = "compareButton";
            this.compareButton.Size = new System.Drawing.Size(145, 24);
            this.compareButton.TabIndex = 13;
            this.compareButton.Text = "Compare SHA256";
            this.compareButton.UseVisualStyleBackColor = true;
            this.compareButton.Click += new System.EventHandler(this.compareButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 266);
            this.Controls.Add(this.tab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "SHA256 Verify";
            this.tab.ResumeLayout(false);
            this.generateTab.ResumeLayout(false);
            this.generateTab.PerformLayout();
            this.compareTab.ResumeLayout(false);
            this.compareTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage generateTab;
        private System.Windows.Forms.TextBox generateChecksumBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button selectFile1Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage compareTab;
        private System.Windows.Forms.Button selectFile3Button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox fileComboBox3;
        private System.Windows.Forms.TextBox compareChecksumBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button selectFile2Button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox fileComboBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Button compareButton;
        private System.Windows.Forms.ComboBox fileComboBox1;
        private System.Windows.Forms.TabControl tab;
    }
}

