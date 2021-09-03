using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_IMC_OO
{
   public class Imc
    {

        //Atributos
        public double altura;
        public double peso;
        public double imc;

        //metodos
        public double CalcularImc(double altura, double peso)
        {
            this.altura = altura;
            this.peso = peso;

            imc = peso / (altura * altura);

            return imc;
        }

        //Metodo que limpa tela
        public void LimparCampos(TextBox txt1, TextBox txt2, TextBox txt3)
        {
            txt1.Clear();
            txt2.Clear();
            txt3.Clear();

            MessageBox.Show("Campos Limpos!");
        }


        //Metodo que verfica a situacao imc
        public string VerificaImc()
        {
            string situacao = "";

            if(imc == 18.5)
            {
                situacao = "Magreza";
            }

            else if(imc>18.5 && imc <= 24.9)
            {
                situacao = "Normal";
            }

            else if (imc > 24.9 && imc <= 30)
            {
                situacao = "Sobrepeso";
            }

            else if (imc > 30)
            {
                situacao = "Obesidade";
            }

            return situacao;
        }
    }
}
