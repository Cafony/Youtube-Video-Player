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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void LoadYouTubeVideo()
        {
            // Ensure the YouTube URL is valid
            string videoUrl = textBox1.Text;
            string videoId = GetYouTubeVideoId(videoUrl);

            if (!string.IsNullOrEmpty(videoId))
            {
                string html = @"
                <html>
                <head>
                    <meta http-equiv='X-UA-Compatible' content='IE=Edge' />
                    <style>
                        body, html {{
                            margin: 0;
                            padding: 0;
                            overflow: hidden;
                            height: 100%;
                        }}
                        iframe {{
                            width: 100%;
                            height: 100%;
                            border: none;
                        }}
                    </style>
                </head>
                <body>
                    <iframe id='video' 
                            src='https://www.youtube.com/embed/{0}?autoplay=1' 
                            allowfullscreen>
                    </iframe>
                </body>
                </html>";
                webBrowser1.DocumentText = string.Format(html, videoId);
            }
            else
            {
                MessageBox.Show("Invalid YouTube URL. Please provide a valid URL.");
            }
        }

        private string GetYouTubeVideoId(string url)
        {
            // Extract the video ID from a standard YouTube URL
            if (url.Contains("v="))
            {
                var parts = url.Split(new[] { "v=" }, StringSplitOptions.None);
                var idPart = parts[1].Split('&')[0]; // Get the first parameter after 'v='
                return idPart;
            }

            // Handle other formats like short URLs (e.g., youtu.be)
            if (url.Contains("youtu.be/"))
            {
                var parts = url.Split(new[] { "youtu.be/" }, StringSplitOptions.None);
                return parts[1].Split('?')[0];
            }

            return null;
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            LoadYouTubeVideo();

        }
    }
}
