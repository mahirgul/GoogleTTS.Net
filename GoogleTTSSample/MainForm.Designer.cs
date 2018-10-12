namespace WindowsFormsApp4
{
    partial class MainForm
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
            this.createAndPlayBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.useCacheCB = new System.Windows.Forms.CheckBox();
            this.writeWavCB = new System.Windows.Forms.CheckBox();
            this.wavFolderTB = new System.Windows.Forms.TextBox();
            this.mp3FolderTB = new System.Windows.Forms.TextBox();
            this.mp3FolderBtn = new System.Windows.Forms.Button();
            this.wavFolderBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.playCBox = new System.Windows.Forms.CheckBox();
            this.OpenFileTB = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // createAndPlayBtn
            // 
            this.createAndPlayBtn.Location = new System.Drawing.Point(335, 242);
            this.createAndPlayBtn.Margin = new System.Windows.Forms.Padding(4);
            this.createAndPlayBtn.Name = "createAndPlayBtn";
            this.createAndPlayBtn.Size = new System.Drawing.Size(209, 28);
            this.createAndPlayBtn.TabIndex = 3;
            this.createAndPlayBtn.Text = "Let\'s Begin....";
            this.createAndPlayBtn.UseVisualStyleBackColor = true;
            this.createAndPlayBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 79);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.MaxLength = 500;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(315, 191);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Welcome";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(13, 31);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.MaxLength = 200;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(315, 22);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "en";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Language Selection:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Text To Speech Text:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(13, 278);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(970, 164);
            this.listBox1.TabIndex = 5;
            // 
            // useCacheCB
            // 
            this.useCacheCB.AutoSize = true;
            this.useCacheCB.Checked = true;
            this.useCacheCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useCacheCB.Location = new System.Drawing.Point(533, 33);
            this.useCacheCB.Margin = new System.Windows.Forms.Padding(4);
            this.useCacheCB.Name = "useCacheCB";
            this.useCacheCB.Size = new System.Drawing.Size(99, 21);
            this.useCacheCB.TabIndex = 6;
            this.useCacheCB.Text = "Use Cache";
            this.useCacheCB.UseVisualStyleBackColor = true;
            // 
            // writeWavCB
            // 
            this.writeWavCB.AutoSize = true;
            this.writeWavCB.Checked = true;
            this.writeWavCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.writeWavCB.Location = new System.Drawing.Point(336, 32);
            this.writeWavCB.Margin = new System.Windows.Forms.Padding(4);
            this.writeWavCB.Name = "writeWavCB";
            this.writeWavCB.Size = new System.Drawing.Size(91, 21);
            this.writeWavCB.TabIndex = 7;
            this.writeWavCB.Text = "Write wav";
            this.writeWavCB.UseVisualStyleBackColor = true;
            this.writeWavCB.CheckedChanged += new System.EventHandler(this.writeWavCB_CheckedChanged);
            // 
            // wavFolderTB
            // 
            this.wavFolderTB.Location = new System.Drawing.Point(551, 152);
            this.wavFolderTB.Margin = new System.Windows.Forms.Padding(4);
            this.wavFolderTB.MaxLength = 200;
            this.wavFolderTB.Name = "wavFolderTB";
            this.wavFolderTB.ReadOnly = true;
            this.wavFolderTB.Size = new System.Drawing.Size(423, 22);
            this.wavFolderTB.TabIndex = 8;
            // 
            // mp3FolderTB
            // 
            this.mp3FolderTB.Location = new System.Drawing.Point(551, 116);
            this.mp3FolderTB.Margin = new System.Windows.Forms.Padding(4);
            this.mp3FolderTB.MaxLength = 200;
            this.mp3FolderTB.Name = "mp3FolderTB";
            this.mp3FolderTB.ReadOnly = true;
            this.mp3FolderTB.Size = new System.Drawing.Size(423, 22);
            this.mp3FolderTB.TabIndex = 11;
            // 
            // mp3FolderBtn
            // 
            this.mp3FolderBtn.Location = new System.Drawing.Point(335, 113);
            this.mp3FolderBtn.Margin = new System.Windows.Forms.Padding(4);
            this.mp3FolderBtn.Name = "mp3FolderBtn";
            this.mp3FolderBtn.Size = new System.Drawing.Size(209, 28);
            this.mp3FolderBtn.TabIndex = 12;
            this.mp3FolderBtn.Text = "Select MP3 Output Folder";
            this.mp3FolderBtn.UseVisualStyleBackColor = true;
            this.mp3FolderBtn.Click += new System.EventHandler(this.mp3FolderBtn_Click);
            // 
            // wavFolderBtn
            // 
            this.wavFolderBtn.Location = new System.Drawing.Point(335, 149);
            this.wavFolderBtn.Margin = new System.Windows.Forms.Padding(4);
            this.wavFolderBtn.Name = "wavFolderBtn";
            this.wavFolderBtn.Size = new System.Drawing.Size(209, 28);
            this.wavFolderBtn.TabIndex = 13;
            this.wavFolderBtn.Text = "Select Wav Output Folder";
            this.wavFolderBtn.UseVisualStyleBackColor = true;
            this.wavFolderBtn.Click += new System.EventHandler(this.wavFolderBtn_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(335, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 27);
            this.button1.TabIndex = 14;
            this.button1.Text = "Load \"txt\" File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // playCBox
            // 
            this.playCBox.AutoSize = true;
            this.playCBox.Location = new System.Drawing.Point(435, 32);
            this.playCBox.Margin = new System.Windows.Forms.Padding(4);
            this.playCBox.Name = "playCBox";
            this.playCBox.Size = new System.Drawing.Size(90, 21);
            this.playCBox.TabIndex = 15;
            this.playCBox.Text = "Play Files";
            this.playCBox.UseVisualStyleBackColor = true;
            // 
            // OpenFileTB
            // 
            this.OpenFileTB.Location = new System.Drawing.Point(551, 79);
            this.OpenFileTB.Margin = new System.Windows.Forms.Padding(4);
            this.OpenFileTB.MaxLength = 200;
            this.OpenFileTB.Name = "OpenFileTB";
            this.OpenFileTB.ReadOnly = true;
            this.OpenFileTB.Size = new System.Drawing.Size(422, 22);
            this.OpenFileTB.TabIndex = 16;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 446);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(996, 25);
            this.statusStrip1.TabIndex = 17;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(500, 19);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 471);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.OpenFileTB);
            this.Controls.Add(this.playCBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.wavFolderBtn);
            this.Controls.Add(this.mp3FolderBtn);
            this.Controls.Add(this.mp3FolderTB);
            this.Controls.Add(this.wavFolderTB);
            this.Controls.Add(this.writeWavCB);
            this.Controls.Add(this.useCacheCB);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.createAndPlayBtn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(479, 358);
            this.Name = "MainForm";
            this.Text = "Google Text To Speech Sample";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createAndPlayBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.CheckBox useCacheCB;
        private System.Windows.Forms.CheckBox writeWavCB;
        private System.Windows.Forms.TextBox wavFolderTB;
        private System.Windows.Forms.TextBox mp3FolderTB;
        private System.Windows.Forms.Button mp3FolderBtn;
        private System.Windows.Forms.Button wavFolderBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox playCBox;
        private System.Windows.Forms.TextBox OpenFileTB;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

