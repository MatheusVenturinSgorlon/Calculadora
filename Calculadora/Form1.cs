using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
        void AtribuirOperacao(string oper)
        {
            LblOper.Text = oper;
            ButIgual.Enabled = true;
        }
        private void Btsoma_Click(object sender, EventArgs e)
        {
            AtribuirOperacao(Btsoma.Text);
        }

        private void Btsubt_Click(object sender, EventArgs e)
        {
            AtribuirOperacao(Btsubt.Text);
        }

        private void Btmult_Click(object sender, EventArgs e)
        {
            AtribuirOperacao(Btmult.Text);
        }

        private void Btdiv_Click(object sender, EventArgs e)
        {
            AtribuirOperacao(Btdiv.Text);
        }

        private void ButIgual_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado = 0;
            num1= (double)NumOper1.Value;
            num2= (double)NumOper2.Value;

            if(LblOper. Text == Btsoma.Text) 
                resultado = num1 + num2;
            else if (LblOper. Text == Btsubt.Text) 
                resultado = num1 - num2;
            else if (LblOper.Text == Btmult.Text)
                resultado = num1 * num2;
            else
                resultado = num1 / num2;

            LbResultado.Text = resultado.ToString();
        }

        private void BtSeguir_Click(object sender, EventArgs e)
        {
            NumOper1.Text = LbResultado.Text;
        }

        private void BtLimpar_Click(object sender, EventArgs e)
        {
            NumOper1.Value = 0;
            NumOper2.Value = 0;
           LbResultado.Text = "0";
           
        }
    }
}
