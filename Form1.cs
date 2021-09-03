using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_IMC_OO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            //Botao calcular
            double valtura, vpeso;

            Imc obj = new Imc();

            valtura = double.Parse(txtaltura.Text);
            vpeso = double.Parse(txtpeso.Text);

            //Exibi imc
            txtimc.Text = obj.CalcularImc(valtura, vpeso).ToString();

            MessageBox.Show("Seu imc é: " + obj.VerificaImc());

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            //Botao limpar
            Imc obj = new Imc();
            obj.LimparCampos(txtaltura, txtpeso, txtimc);
        }
    }
}
