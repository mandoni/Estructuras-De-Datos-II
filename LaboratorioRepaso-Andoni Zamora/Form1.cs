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
        Dictionary<string, ArchivoMusica> diccionarioPlaylist = new Dictionary<string, ArchivoMusica>();
        ArchivoMusica[] ordenada;
        ArchivoMusica resultadoDeBusqueda;
        bool nombre = true, duracion = true, play = false;
        string ruta;
        

        public Form1()
        {
            InitializeComponent();
            panelAgregar.Visible = false;
            playlistPanel.Visible = false;
            panelResult.Visible = false;
            reproductor.Visible = false;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void durasiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ALista();
            int i, j;
            ArchivoMusica auxiliar;
            if (duracion == true)
            {
                for (i = 0; i < ordenada.Length - 1; i++)
                {
                    for (j = 1; j < ordenada.Length; j++)
                    {
                        if (ordenada[j].ordenarDuracion(ordenada[i].duracion) == true)
                        {
                            auxiliar = ordenada[j];
                            ordenada[j] = ordenada[j - 1];
                            ordenada[j - 1] = auxiliar;
                        }
                    }
                }
            }
            else
            {
                for (i = 0; i < ordenada.Length - 1; i++)
                {
                    for (j = 1; j < ordenada.Length; j++)
                    {
                        if (ordenada[j].ordenarDuracion(ordenada[i].duracion) == false)
                        {
                            auxiliar = ordenada[j];
                            ordenada[j] = ordenada[j - 1];
                            ordenada[j - 1] = auxiliar;
                        }
                    }
                }
            }
            duracion = !duracion;
            ImprimirLista();
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

                track.artista = artistBox.Text;
                track.album = albumBox.Text;
                track.duracion = durationBox.Text;
                track.nombreCancion = nameBox.Text;
                track.url = ruta.ToString();

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
                        songList.Items.Add(file.nombreCancion);
                    }
                }
            }
            catch
            {
                MessageBox.Show("El nombre de una canción está repetido", "Error en el nombre", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (itemToSearch.Text.Length != 0)
                buscar(itemToSearch.Text);
        }

        public void buscar(string item)
        {
            try
            {
                resultadoDeBusqueda = diccionarioMusica[item];
                panelResult.Visible = true;
                nameResult.Text = resultadoDeBusqueda.nombreCancion;
                artistResult.Text = resultadoDeBusqueda.artista;
                albumResult.Text = resultadoDeBusqueda.album;
                durationResult.Text = resultadoDeBusqueda.duracion;
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
            itemToSearch.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            reproductor.URL = resultadoDeBusqueda.url;
            songName.Text = resultadoDeBusqueda.nombreCancion + " - " + resultadoDeBusqueda.artista;
            PlayMethod();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                panelResult.Visible = false;
                itemToSearch.Text = "";
                playlistPanel.Visible = true;
                palylistList.Items.Add(resultadoDeBusqueda.nombreCancion);
                diccionarioPlaylist.Add(resultadoDeBusqueda.nombreCancion, resultadoDeBusqueda);
            }
            catch
            {
                MessageBox.Show("Esta canción ya ha sido agregada anteriormente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void songList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string consulta = songList.SelectedItem.ToString();
                File track = File.Create(diccionarioMusica[consulta].url);
                reproductor.URL = diccionarioMusica[consulta].url;
                songName.Text = consulta+" - "+diccionarioMusica[consulta].artista;
                PlayMethod();
            }
            catch { }

        }
        private void palylistList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string consulta = palylistList.SelectedItem.ToString();
                reproductor.URL = diccionarioMusica[consulta].url;
                songName.Text = consulta + " - " + diccionarioMusica[consulta].artista;
                PlayMethod();
            }
            catch { }
            
        }
        private void nombreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ALista();
            int i, j;
            ArchivoMusica auxiliar;
            if(nombre == true)
            {
                for (i = 0; i < ordenada.Length - 1; i++)
                {
                    for (j = 1; j < ordenada.Length; j++)
                    {
                        if (ordenada[j].ordenarNombre(ordenada[i].nombreCancion) == true)
                        {
                            auxiliar = ordenada[j];
                            ordenada[j] = ordenada[j - 1];
                            ordenada[j - 1] = auxiliar;
                        }
                    }
                }
            }
            else
            {
                for (i = 0; i < ordenada.Length - 1; i++)
                {
                    for (j = 1; j < ordenada.Length; j++)
                    {
                        if (ordenada[j].ordenarNombre(ordenada[i].nombreCancion) == false) 
                        {
                            auxiliar = ordenada[j];
                            ordenada[j] = ordenada[j - 1];
                            ordenada[j - 1] = auxiliar;
                        }
                    }
                }
            }
            nombre = !nombre;
            ImprimirLista();
        }

        public void ALista()
        {
            ordenada = new ArchivoMusica[diccionarioPlaylist.Count];
            for(int i = 0; i < diccionarioPlaylist.Count; i++)
            {
                ordenada[i] = diccionarioPlaylist[palylistList.Items[i].ToString()];
            }
        }

        public void ImprimirLista()
        {
            palylistList.Items.Clear();
            for (int i = 0; i < ordenada.Length; i++)
            {
                palylistList.Items.Add(ordenada[i].nombreCancion);
            }
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            switch (play)
            {
                case true:
                    PlayMethod();
                    break;
                case false:
                    reproductor.Ctlcontrols.pause();
                    playButton.Image = Properties.Resources.Button_3_512;
                    play = true;
                    break;
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            reproductor.Ctlcontrols.stop();
            playButton.Image = Properties.Resources.Button_3_512;
            play = false;
        }

        public void PlayMethod()
        {
            reproductor.Ctlcontrols.play();
            playButton.Image = Properties.Resources.Button_4_128;
            play = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SongStatus();
            songStatus.Value = (int)reproductor.Ctlcontrols.currentPosition;
            volumeStatus.Value = reproductor.settings.volume;
        }

        private void reproductor_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e) => SongStatus();

        private void volumeStatus_ValueChanged(object sender, EventArgs e) => reproductor.settings.volume = volumeStatus.Value;

        public void SongStatus()
        {
            if(reproductor.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                songStatus.Maximum = (int)reproductor.Ctlcontrols.currentItem.duration;
                timer1.Start();
            }
            else if(reproductor.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                timer1.Stop();
                songStatus.Value = 0;
            }
            else if(reproductor.playState == WMPLib.WMPPlayState.wmppsPaused)
                timer1.Stop();
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