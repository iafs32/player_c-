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
        public frmReproductor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

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
    }
}
