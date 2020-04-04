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
            // você estava indo no caminho certo :-)

            /*int altura, largura, area; // so´não era int, e sim double

            altura = Int32.Parse(txtAltura.Text);
            largura = Int32.Parse(txtLargura.Text);

            area = altura * largura;

            txtArea.Text = Convert.ToString(area);*/

            PegarDados();

            Retangulo c = new Retangulo();

            /*declarando as entradas*/
            double altura,largura;
            /*pegando os valores digitados*/
            altura = Convert.ToDouble(txtAltura.Text);
            largura = Convert.ToDouble(txtLargura.Text);

            
            /*convertendo para string*/
            string a = Convert.ToString(c.Area(altura, largura));

            //string d = Convert.ToString(c.Diagonal());
            //string p = Convert.ToString(c.Perimetro());

            /*mostrando no formulário*/
            txtArea.Text = a;
            //txtDiagonal.Text = d;
            //txtPerimetro.Text = p;
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
