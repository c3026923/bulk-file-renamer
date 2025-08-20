namespace Renamer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnBrowse = new Button();
            btnConvert = new Button();
            label2 = new Label();
            label3 = new Label();
            txtToReplace = new TextBox();
            txtReplacement = new TextBox();
            label4 = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            label1 = new Label();
            label6 = new Label();
            panel2 = new Panel();
            lblProgressInfo = new Label();
            custProgBar = new CustomProgressBar();
            lblSummary = new Label();
            picBoxInfo = new PictureBox();
            txtFolderLocation = new TextBox();
            label5 = new Label();
            picBoxAvatar = new PictureBox();
            linkLblGithub = new LinkLabel();
            linkLblInfo = new LinkLabel();
            label7 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxInfo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxAvatar).BeginInit();
            SuspendLayout();
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(342, 62);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(75, 23);
            btnBrowse.TabIndex = 1;
            btnBrowse.Text = "Browse...";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // btnConvert
            // 
            btnConvert.Location = new Point(13, 152);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(75, 23);
            btnConvert.TabIndex = 3;
            btnConvert.Text = "Convert";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 99);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 4;
            label2.Text = "Text to replace:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 124);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 5;
            label3.Text = "New Text:";
            // 
            // txtToReplace
            // 
            txtToReplace.Location = new Point(99, 96);
            txtToReplace.Name = "txtToReplace";
            txtToReplace.Size = new Size(312, 23);
            txtToReplace.TabIndex = 6;
            // 
            // txtReplacement
            // 
            txtReplacement.Location = new Point(99, 121);
            txtReplacement.Name = "txtReplacement";
            txtReplacement.Size = new Size(312, 23);
            txtReplacement.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 8);
            label4.Name = "label4";
            label4.Size = new Size(331, 15);
            label4.TabIndex = 8;
            label4.Text = "This tool allows you to quickly rename files in bulk, with ease.";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 9);
            panel1.Name = "panel1";
            panel1.Size = new Size(456, 264);
            panel1.TabIndex = 9;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Highlight;
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(18, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(420, 28);
            panel3.TabIndex = 10;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(127, 28);
            label1.TabIndex = 11;
            label1.Text = "File Renamer";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(220, 0);
            label6.Name = "label6";
            label6.Size = new Size(197, 28);
            label6.TabIndex = 0;
            label6.Text = "created by Jack (C302623)";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblProgressInfo);
            panel2.Controls.Add(custProgBar);
            panel2.Controls.Add(lblSummary);
            panel2.Controls.Add(picBoxInfo);
            panel2.Controls.Add(btnConvert);
            panel2.Controls.Add(txtReplacement);
            panel2.Controls.Add(txtFolderLocation);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtToReplace);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btnBrowse);
            panel2.Location = new Point(18, 37);
            panel2.Name = "panel2";
            panel2.Size = new Size(420, 226);
            panel2.TabIndex = 9;
            // 
            // lblProgressInfo
            // 
            lblProgressInfo.AutoSize = true;
            lblProgressInfo.Location = new Point(298, 178);
            lblProgressInfo.Name = "lblProgressInfo";
            lblProgressInfo.Size = new Size(113, 15);
            lblProgressInfo.TabIndex = 14;
            lblProgressInfo.Text = "Renaming files: x / y";
            lblProgressInfo.Visible = false;
            // 
            // custProgBar
            // 
            custProgBar.Location = new Point(94, 152);
            custProgBar.Name = "custProgBar";
            custProgBar.Size = new Size(317, 23);
            custProgBar.TabIndex = 13;
            // 
            // lblSummary
            // 
            lblSummary.Location = new Point(7, 193);
            lblSummary.Name = "lblSummary";
            lblSummary.Size = new Size(404, 33);
            lblSummary.TabIndex = 12;
            lblSummary.Text = "Renamed {totalCount} files from 'x' to 'y'";
            lblSummary.Visible = false;
            // 
            // picBoxInfo
            // 
            picBoxInfo.ImageLocation = "";
            picBoxInfo.InitialImage = Properties.Resources.Info;
            picBoxInfo.Location = new Point(7, 3);
            picBoxInfo.Name = "picBoxInfo";
            picBoxInfo.Size = new Size(24, 24);
            picBoxInfo.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxInfo.TabIndex = 11;
            picBoxInfo.TabStop = false;
            // 
            // txtFolderLocation
            // 
            txtFolderLocation.Location = new Point(7, 63);
            txtFolderLocation.Name = "txtFolderLocation";
            txtFolderLocation.Size = new Size(329, 23);
            txtFolderLocation.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 35);
            label5.Name = "label5";
            label5.Size = new Size(379, 15);
            label5.TabIndex = 9;
            label5.Text = "To begin, browse to the folder containing the files you wish to rename.";
            // 
            // picBoxAvatar
            // 
            picBoxAvatar.BorderStyle = BorderStyle.FixedSingle;
            picBoxAvatar.Location = new Point(436, 279);
            picBoxAvatar.Name = "picBoxAvatar";
            picBoxAvatar.Size = new Size(32, 32);
            picBoxAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxAvatar.TabIndex = 10;
            picBoxAvatar.TabStop = false;
            // 
            // linkLblGithub
            // 
            linkLblGithub.AutoSize = true;
            linkLblGithub.Location = new Point(387, 288);
            linkLblGithub.Name = "linkLblGithub";
            linkLblGithub.Size = new Size(43, 15);
            linkLblGithub.TabIndex = 11;
            linkLblGithub.TabStop = true;
            linkLblGithub.Text = "Github";
            linkLblGithub.LinkClicked += linkLblGithub_LinkClicked;
            // 
            // linkLblInfo
            // 
            linkLblInfo.AutoSize = true;
            linkLblInfo.Location = new Point(304, 288);
            linkLblInfo.Name = "linkLblInfo";
            linkLblInfo.Size = new Size(77, 15);
            linkLblInfo.TabIndex = 12;
            linkLblInfo.TabStop = true;
            linkLblInfo.Text = "Program Info";
            linkLblInfo.LinkClicked += linkLblInfo_LinkClicked;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(199, 288);
            label7.Name = "label7";
            label7.Size = new Size(99, 15);
            label7.TabIndex = 13;
            label7.Text = "File Renamer v1.1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 321);
            Controls.Add(label7);
            Controls.Add(linkLblInfo);
            Controls.Add(linkLblGithub);
            Controls.Add(picBoxAvatar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MaximumSize = new Size(496, 360);
            MinimizeBox = false;
            MinimumSize = new Size(496, 360);
            Name = "Form1";
            Text = "File Renamer";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxInfo).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxAvatar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnBrowse;
        private Button btnConvert;
        private Label label2;
        private Label label3;
        private TextBox txtToReplace;
        private TextBox txtReplacement;
        private Label label4;
        private Panel panel1;
        private Panel panel2;
        private TextBox txtFolderLocation;
        private Label label5;
        private PictureBox picBoxInfo;
        private PictureBox picBoxAvatar;
        private LinkLabel linkLblGithub;
        private LinkLabel linkLblInfo;
        private Panel panel3;
        private Label label1;
        private Label lblSummary;
        private CustomProgressBar custProgBar;
        private Label lblProgressInfo;
        private Label label6;
        private Label label7;
    }
}
