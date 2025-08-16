using System;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace Speak_App
{
    public partial class Form1 : Form
    {
        private readonly SpeechSynthesizer s = new SpeechSynthesizer();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSpeak_click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please enter Some text.");
                return;
            }
            try
            {
                s.SpeakAsync(textBox1.Text);
                s.Rate = 0; // Set the rate of speech
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while trying to speak: {ex.Message}");
            }
        }
    }
}
