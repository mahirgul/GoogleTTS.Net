using System;
using System.Media;
using System.Windows.Forms;
using ttsGenerator;

namespace WindowsFormsApp4
{
    public partial class MainForm : Form
    {        
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            listBox1.Items.Clear();
            try
            {
                string appFolder = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
                Generate gtts = new Generate();

                string mp3Folder;
                string wavFolder;


                if (mp3FolderTB.Text.Length > 0)
                    mp3Folder = mp3FolderTB.Text + "\\";
                else
                    mp3Folder = appFolder + "\\";



                if (wavFolderTB.Text.Length > 0)
                    wavFolder = wavFolderTB.Text + "\\";
                else
                    wavFolder = appFolder+"\\";


                gtts.tts(textBox1.Text, textBox2.Text, writeWavCB.Checked, useCacheCB.Checked, mp3Folder, wavFolder, "");

                string fileName = gtts.GetMd5Hash(textBox1.Text);

                if (writeWavCB.Checked)
                {
                    SoundPlayer snd = new SoundPlayer(wavFolder + fileName + ".wav");
                    if (playCBox.Checked)
                    {
                        listBox1.Items.Insert(0, "File Playing...");

                        snd.PlaySync();
                    }
                }
                listBox1.Items.Insert(0, "Completed.......");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void mp3FolderBtn_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    mp3FolderTB.Text = fbd.SelectedPath;
                }
                else
                    mp3FolderTB.Text = "";
            }            
        }

        private void wavFolderBtn_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    wavFolderTB.Text = fbd.SelectedPath;
                }
                else
                    wavFolderTB.Text = "";
            }            
        }

        private void writeWavCB_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (!writeWavCB.Checked)

            {
                listBox1.Items.Add("If you dont select \"Write wav\" you cant hear anything,");
                listBox1.Items.Add("but you can see mp3 file in to the mp3 folder.");
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if(openFileDialog1.FileName!=null)
            {
                OpenFileTB.Text = openFileDialog1.FileName;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}