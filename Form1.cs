using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AudioPlayer
{
    public partial class AudioPlayer : Form
    {
        public AudioPlayer()
        {
            InitializeComponent();
        }

        //Create Global Variables of String Type Array to save the titles or names and paths of the tracks
        string[] paths, files;

        private void btnClose_Click(object sender, EventArgs e)
        {
            //code to close the app
            this.Close();
        }

        private void btnPlay_MouseClick(object sender, MouseEventArgs e)
        {
            btnPlay.BackColor = Color.Teal;
        }
        private void btnBurn_MouseClick(object sender, MouseEventArgs e)
        {
            btnBurn.BackColor = Color.Teal;
        }
        private void btnSync_MouseClick(object sender, MouseEventArgs e)
        {
            btnSync.BackColor = Color.Teal;
        }

        private void btnSync_MouseLeave(object sender, EventArgs e)
        {
            btnSync.BackColor = Color.Lavender;
        }

        private void btnBurn_MouseLeave(object sender, EventArgs e)
        {
            btnBurn.BackColor = Color.Lavender;
        }

        private void btnSelectSongs_Click(object sender, EventArgs e)
        {
            //code to Select songs
            OpenFileDialog ofd = new OpenFileDialog();
            //code to select multiple songs
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames; //Save the names of the tracks in the file array
                paths = ofd.FileNames; //Save the paths of the tracks in the paths array
                //Display the music titles in listbox
                for (int i = 0; i < files.Length; i++)
                {
                    listBoxSongs.Items.Add(files[i]); //Display songs in listbox
                }
            }
        }

        private void listBoxSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayerAudio.URL = paths[listBoxSongs.SelectedIndex];
        }

        private void btnPlay_MouseLeave(object sender, EventArgs e)
        {
            btnPlay.BackColor = Color.Lavender;
        }

    }
}
