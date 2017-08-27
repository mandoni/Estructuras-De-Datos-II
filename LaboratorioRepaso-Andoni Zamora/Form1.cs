using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TagLib;

namespace LaboratorioRepaso_Andoni_Zamora
{
    public partial class Form1 : Form
    {
        Dictionary<int, ArchivoMusica> diccionarioMusica = new Dictionary<int, ArchivoMusica>();
        bool nombre = true, duracion = true;
        string ruta;

        public Form1()
        {
            InitializeComponent();
            panelAgregar.Visible = false;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void durasiónToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog trak = new OpenFileDialog();

            trak.Filter = "Audio Files |*.mp3|Audio Files |*.mid|Audio Files |*.midi" +
                "|Audio Files |*.wma|Audio Files |*.wav|Audio Files |*.cad";
            trak.FilterIndex = 1;

            if (trak.ShowDialog() == DialogResult.OK)
            {
                panelAgregar.Visible = true;
                ruta = trak.FileName;

                File track = File.Create(ruta);
                nameBox.Text = track.Tag.Title;
                artistBox.Text = track.Tag.FirstPerformer;
                durationBox.Text = track.Properties.Duration.ToString();
                albumBox.Text = track.Tag.Album;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArchivoMusica track = new ArchivoMusica();

            track.artista = artistBox.ToString();
            track.album = albumBox.ToString();
            track.duracion = durationBox.ToString();
            track.nombreCancion = nameBox.ToString();
            track.url = ruta;

            diccionarioMusica.Add(track.nombreCancion.GetHashCode(), track);

            panelAgregar.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nameBox.Text = "";
            artistBox.Text = "";
            durationBox.Text = "";
            albumBox.Text = "";
            panelAgregar.Visible = false;
        }
        public class ArchivoMusica
        {
            public string nombreCancion;
            public string artista;
            public string album;
            public string duracion;
            public string url;

            public bool ordenarDuracion(string duracionComparar)
            {
                if (this.duracion.CompareTo(duracionComparar) < 1)
                    return true;
                return false;
            }

            public bool ordenarNombre(string nombreComparar)
            {
                if (this.nombreCancion.CompareTo(nombreComparar) < 1)
                    return true;
                return false;
            }
        }
    }
}

    


