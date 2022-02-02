using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.CognitiveServices.Speech;
using Microsoft.CognitiveServices.Speech.Audio;
using System.Media;

namespace TextoParaFala
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            vozes.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var texto_ = texto.Text;
            string[] array_vozes = { "pt-BR-FranciscaNeural", "pt-BR-AntonioNeural", "pt-BR-Daniel", "pt-BR-HeloisaRUS" };
            var config = SpeechConfig.FromSubscription("0d4a131eed7d4bcdaa6d56b0cbd790af", "brazilsouth");
            config.SpeechSynthesisVoiceName = array_vozes[vozes.SelectedIndex];
            var audioConfig = AudioConfig.FromWavFileOutput("C:\\audios\\fala.wav");
            var synthesizer = new SpeechSynthesizer(config, audioConfig);
            synthesizer.SpeakTextAsync(texto_);
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Audio files | *.wav"; // file types, that will be allowed to upload
            dialog.Multiselect = false; // allow/deny user to upload more than one file at a time
            if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK
            {
                String path = dialog.FileName; // get name of file
                using (StreamReader reader = new StreamReader(new FileStream(path, FileMode.Open), new UTF8Encoding())) // do anything you want, e.g. read it
                {
                    SoundPlayer simpleSound = new();
                    simpleSound.Play();
                }
            }
        }
    }
}
