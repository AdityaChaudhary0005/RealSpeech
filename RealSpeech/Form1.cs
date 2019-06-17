using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace RealSpeech
{
    public partial class Form1 : Form
    {
        SpeechSynthesizer say = new SpeechSynthesizer();
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //
            say.Rate = -5;
            say.Volume = trackBar1.Value;
            say.SpeakAsync(richTextBox1.Text);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            //
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" RealSpeech is a Text-to-Speech Software.\n You are free to copy and share RealSpeech.\n Current Version: v1.0\n\n Designed and Programmed by Shreyas D. Sable.\n\n Programmed in C#.", "About RealSpeech");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            //
        }
    }
}
