using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace GendocsForms
{
    public partial class FrmRedimensionarImagenes : Form
    {
        FolderBrowserDialog CarpetaEntrada;
        FolderBrowserDialog CarpetaSalida;
        bool Redimensionar = false;

        public FrmRedimensionarImagenes()
        {
            InitializeComponent();
        }

        private void FrmRedimensionarImagenes_Load(object sender, EventArgs e)
        {
            txtRutaOrigen.Focus();
        }

        private void BtnCarpetaOrigen_Click(object sender, EventArgs e)
        {
            try
            {
                CarpetaEntrada = new FolderBrowserDialog();
                if (CarpetaEntrada.ShowDialog() == DialogResult.OK)
                {
                    txtRutaOrigen.Text = CarpetaEntrada.SelectedPath;
                    txtRutaDestino.Text = CarpetaEntrada.SelectedPath;
                    Redimensionar = true;
                }
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }

        private void BtnCarpetaDestino_Click(object sender, EventArgs e)
        {
            CarpetaSalida = new FolderBrowserDialog();
            if (CarpetaSalida.ShowDialog() == DialogResult.OK)
            {
                txtRutaDestino.Text = CarpetaSalida.SelectedPath;
                Redimensionar = true;
            }
        }

        private void BtnRedimensionar_Click(object sender, EventArgs e)
        {
            try
            {
                RedimensionarImagenes();
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }

        private void RedimensionarImagenes()
        {
            try
            {
                if (Redimensionar)
                {
                    string[] files = Directory.GetFiles(txtRutaOrigen.Text);
                    String NombreArchivo;
                    String NuevaCarpetaArchivo;
                    NuevaCarpetaArchivo = txtRutaDestino.Text + "\\";

                    for (int i = 0; i < files.Length; i++)
                    {
                        if (Path.GetExtension(files[i]) == ".jpg")
                        {
                            NombreArchivo = Path.GetFileName(files[i]);
                            Bitmap orig = new Bitmap(files[i].Trim());
                            Bitmap bmp = new Bitmap(RedimensionarImagen(orig, (int)numAncho.Value, (int)numAlto.Value));
                            bmp.Save(NuevaCarpetaArchivo + txtNomeclatura.Text + NombreArchivo, System.Drawing.Imaging.ImageFormat.Jpeg);
                            pbProgreso.Value = (100 * i + 1) / (files.Length);
                        }
                    }
                    if (pbProgreso.Value <= 100)
                    {
                        pbProgreso.Value = 0;
                        MessageBox.Show("Todas las imágenes has sido redimensiodadas correctamente", "Redimensionar Imágenes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Process.Start(txtRutaDestino.Text);
                    }
                }
                else
                {
                    MessageBox.Show("No ha seleccionado imágenes para redimensionar", "Redimensionar Imágenes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }

        public static Bitmap RedimensionarImagen(Image imagenOriginal, int width, int height)
        {

            var Radio = Math.Max((double)width / imagenOriginal.Width, (double)height / imagenOriginal.Height);
            var NuevoAncho = (int)(imagenOriginal.Width * Radio);
            var NuevoAlto = (int)(imagenOriginal.Height * Radio);
            var ImagenRedimensionada = new Bitmap(NuevoAncho, NuevoAlto);
            Graphics.FromImage(ImagenRedimensionada).DrawImage(imagenOriginal, 0, 0, NuevoAncho, NuevoAlto);
            Bitmap ImagenFinal = new Bitmap(ImagenRedimensionada);
            return ImagenFinal;
        }
    }
}
