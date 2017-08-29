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
        Dictionary<string, ArchivoMusica> diccionarioMusica = new Dictionary<string, ArchivoMusica>();
        ArchivoMusica resultadoDeBusqueda;
        bool nombre = true, duracion = true;
        string ruta;
        

        public Form1()
        {
            InitializeComponent();
            panelAgregar.Visible = false;
            playlistPanel.Visible = false;
            panelResult.Visible = false;
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

            trak.Filter = "Audio comprimido (.mp3) |*.mp3|Interfaz digital (.mid) |*.mid|" +
                "Instrumentos musicales (.midi)|*.midi|Audio digital (.wma) |*.wma|" +
                "Audio sin comprimir (.wav) |*.wav|CD de audio (.cad) |*.cad";
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
            try
            {
                ArchivoMusica track = new ArchivoMusica();

                track.artista = artistBox.ToString();
                track.album = albumBox.ToString();
                track.duracion = durationBox.ToString();
                track.nombreCancion = nameBox.ToString();
                track.url = ruta;

                songList.Items.Add(track.nombreCancion);
                diccionarioMusica.Add(track.nombreCancion, track);

                panelAgregar.Visible = false;
            }
            catch
            {
                MessageBox.Show("Ya existe una canción con ese nombre.\nIntenta cambiar el nombre", "Error:" +
                    " Elemento repetido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nameBox.Text = "";
            artistBox.Text = "";
            durationBox.Text = "";
            albumBox.Text = "";
            panelAgregar.Visible = false;
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            playlistPanel.Visible = false;
        }

        private void verPlaylistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            playlistPanel.Visible = true;
        }

        private void agragarCarpetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog trak = new OpenFileDialog();
                string[] archivos;

                trak.Filter = "Audio comprimido (.mp3) |*.mp3|Interfaz digital (.mid) |*.mid|" +
                    "Instrumentos musicales (.midi)|*.midi|Audio digital (.wma) |*.wma|" +
                    "Audio sin comprimir (.wav) |*.wav|CD de audio (.cad) |*.cad";
                trak.Multiselect = true;

                if (trak.ShowDialog() == DialogResult.OK)
                {
                    archivos = trak.FileNames;
                    foreach (var archivo in archivos)
                    {
                        ArchivoMusica file = new ArchivoMusica();
                        File track = File.Create(archivo);

                        file.artista = track.Tag.FirstPerformer;
                        file.album = track.Tag.Album;
                        file.duracion = track.Properties.Duration.ToString();
                        file.nombreCancion = track.Tag.Title;
                        file.url = archivo;

                        diccionarioMusica.Add(file.nombreCancion, file);
                    }
                    reproductor.URL = archivos[0];
                }
            }
            catch
            {
                MessageBox.Show("El nombre de una canción está repetido", "Error en el nombre", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void songList_SelectedIndexChanged(object sender, EventArgs e) => reproductor.URL = diccionarioMusica[songList.SelectedItem.ToString()].url;

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (itemToSearch.Text.Length != 0)
                buscar(itemToSearch.Text);
        }

        public void buscar(string item)
        {
            try
            {
                ArchivoMusica file = new ArchivoMusica();
                file.nombreCancion = item;
                resultadoDeBusqueda = diccionarioMusica["System.Windows.Forms.TextBox, Text: "+item];
                panelResult.Visible = true;
            }
            catch
            {
                MessageBox.Show("No se encontró ningún resultado", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelResult.Visible = false;
            resultadoDeBusqueda = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            reproductor.URL = resultadoDeBusqueda.url;
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

    


