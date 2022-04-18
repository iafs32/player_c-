using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Reproductor
{
    public partial class frmReproductor : Form
    {
        bool reproducir = true;
        public frmReproductor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (reproducir == true)
            {
                wmpReproductor.Ctlcontrols.play();
                btnReproducirPausa.Text = "Pausa";
                reproducir = false;
            }
            else
            {
                wmpReproductor.Ctlcontrols.pause();
                btnReproducirPausa.Text = "Reproducir";
                reproducir = true;
            }
        }

        private void abrirToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog cargar = new OpenFileDialog();
            cargar.InitialDirectory = "C:\\";
            cargar.Title = "Abrir Música";
            cargar.Filter = "Audio Files|*.mp3; *.wav";
            cargar.FilterIndex = 4;
            cargar.RestoreDirectory = true;
            cargar.Multiselect = true;
            cargar.ShowDialog();

            ltbPlaylist.Items.AddRange(cargar.FileNames);
        }

        private void ltbPlaylist_SelectedIndexChanged(object sender, EventArgs e)
        {
            wmpReproductor.URL = Convert.ToString(ltbPlaylist.SelectedItem);
        }

        private void wmpReproductor_MediaChange(object sender, AxWMPLib._WMPOCXEvents_MediaChangeEvent e)
        {

        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            wmpReproductor.Ctlcontrols.stop();
        }

        private void wmpReproductor_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (wmpReproductor.playState == WMPPlayState.wmppsPlaying)
            {
                btnReproducirPausa.Text = "Pausa";
                reproducir = false;
            }
            else if ((wmpReproductor.playState == WMPPlayState.wmppsPaused) || (wmpReproductor.playState == WMPPlayState.wmppsStopped))
            {
                btnReproducirPausa.Text = "Reproducir";
                reproducir = true;
            }
        }
    }
}
