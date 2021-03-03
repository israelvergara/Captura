using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Captura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // File.WriteAllText(@"C: \Users\DELL\Documents\UASLP\ciclo 2020 - 2021II\Interface Graficas 8 - 9lmjv\Captura\a.txt") = textBox1.Text;
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            List<string> contenido = new List<string>();
            
            contenido.Add(txtNombre.Text);

            SaveFileDialog dlg = new SaveFileDialog();

            DialogResult res = dlg.ShowDialog();

            if (res == DialogResult.OK)
                File.WriteAllText(dlg.FileName, contenido[0]);//agrega el texto ingresao en txtNombre


        }
    }
}
