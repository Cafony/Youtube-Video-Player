using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Youtube_Video_Player
{
    public partial class Main : Form
    {
        private readonly YoutubePlayer _youtubePlayer;

        public Main()
        {
            InitializeComponent();
            //_youtubePlayer = new YoutubePlayer(webView21);
            _youtubePlayer = new YoutubePlayer(webView21);
        }

        private async void buttonPlay_Click(object sender, EventArgs e)
        {
            try
            {
                await _youtubePlayer.PlayVideoAsync(textBoxUrl.Text);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            _youtubePlayer.Stop();
        }

        private void buttonPasteLink_Click(object sender, EventArgs e)
        {
            // Paste the YouTube link from the clipboard into the text box

            if (Clipboard.ContainsText())
            {
                textBoxUrl.Text = Clipboard.GetText();
            }
            else
            {
                MessageBox.Show("Clipboard does not contain text.");
            }
        }
    }
}
