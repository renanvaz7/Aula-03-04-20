using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula0304
{
    public partial class frmExercicio1 : Form
    {
        public frmExercicio1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            /*int altura, largura, area;

            altura = Int32.Parse(txtAltura.Text);
            largura = Int32.Parse(txtLargura.Text);

            area = altura * largura;

            txtArea.Text = Convert.ToString(area);*/

            PegarDados();

            Retangulo c = new Retangulo();

            string a = Convert.ToString(c.Area());
            string d = Convert.ToString(c.Diagonal());
            string p = Convert.ToString(c.Perimetro());

            txtArea.Text = a;
            txtDiagonal.Text = d;
            txtPerimetro.Text = p;
        }
        public void PegarDados()
        {
            Retangulo a = new Retangulo();
            Retangulo l = new Retangulo();

            a.altura = Double.Parse(txtAltura.Text);
            l.largura = Double.Parse(txtLargura.Text);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {            
            frmMenu f2 = new frmMenu();
            f2.ShowDialog();
            this.Close();
        }
    }
}
