using System.Reflection.Metadata;

namespace Editor_de_texto

{
    public partial class From1 : Form
    {
        string archivo;
        string archivo1;
        private object txtContenido;

        public From1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFile = new();
            OpenFile.Filter = "Archivo de texto (*.txt)|*.txt|Archivo HTML (*.html)|*.html |Archivo PDF (*.pdf)|*.pdf";

            if (OpenFile.ShowDialog() == DialogResult.OK)
            {

                archivo = OpenFile.FileName;


                using StreamReader sr = new(archivo);
                {
                    richTextBox1.Text = sr.ReadToEnd();

                }

            }
        }
        private StreamReader StreamReader(string archivo)
        {
            throw new NotImplementedException();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new ();
            saveFile.Filter = "Archivo de texto (*.txt)|*.txt|Archivo HTML (*.html)|*.html |Archivo PDF (*.pdf)|*.pdf";

            if (archivo != null)
            {
                using StreamWriter sw = new (archivo);
                {
                    sw.Write(richTextBox1.Text);
                }

            }
            else
            {
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    archivo = saveFile.FileName;
                    using StreamWriter sw = new(saveFile.FileName);
                    {
                        sw.Write(richTextBox1.Text);

                    }


                }

            }
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void From1_Load(object sender, EventArgs e)
        {

        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveFile = new SaveFileDialog();
            SaveFile.Filter = "Archivo de texto (*.txt)|*.txt|Archivo HTML (*.html)|*.html |Archivo PDF (*.pdf)|*.pdf";

            if (archivo1 != null)
            {
                using StreamWriter ss = new StreamWriter(archivo1);
                {
                    ss.Write(richTextBox1.Text);
                }

            }
            else
            {
                if (SaveFile.ShowDialog() == DialogResult.OK)
                {
                    archivo1 = SaveFile.FileName;
                    using StreamWriter ss = new(SaveFile.FileName);
                    {
                        ss.Write(richTextBox1.Text);
                        archivo1 = null;
                    }


                }
            }
        }

    }

}