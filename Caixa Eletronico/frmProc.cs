using Caixa_Eletronico.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caixa_Eletronico
{
    public partial class frmProc : Form
    {
        bool pode_N;
        bool pode_T;
        Singleton s;
        private string tipo;

        public frmProc()
        {
            s = Singleton.Instance;
        }
        public frmProc(string tipo) : this()
        {
            InitializeComponent();
            this.tipo = tipo;
        }

        private void frmProc_Load(object sender, EventArgs e)
        {
            lblOp.Text = tipo;
            if (tipo == "Transferência")
            {
                txtC.Visible = true;
                lblNome.Visible = true;
            }
        }

        private void btR_Click(object sender, EventArgs e)
        {
                if (tipo == "Saque")
                {
                    double valor = (double)numV.Value;
                    if (s.conta_logada.Sacar(valor))
                    {
                        MessageBox.Show("Saque realizado!");
                    }
                    else
                    {
                        MessageBox.Show("Saldo insuficiente...");
                    }
                }
                if (tipo == "Depósito")
                {
                    double valor = (double)numV.Value;
                    s.conta_logada.Depositar(valor);
                    MessageBox.Show("Depósito realizado!");
                }
                if (tipo == "Transferência")
                {
                    double valor = (double)numV.Value;
                    Conta destino = s.BuscarConta(txtC.Text);
                    if (destino != null)
                    {
                        if (s.conta_logada.Transferir(destino, valor))
                        {
                            MessageBox.Show("Transferência realizada!");
                        }
                        else
                        {
                            MessageBox.Show("Saldo insuficiente...!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Conta destino não existe!");
                    }
                }
                frmPrincipal frm = new frmPrincipal();
                frm.Show();
                this.Hide();
        }

        private void numV_ValueChanged(object sender, EventArgs e)
        {
            if(tipo != "Transferência")
            {
                if (numV.Value != 0)
                {
                    btR.Enabled = true;
                }
                else
                {
                    btR.Enabled = false;
                }
            }
            else
            {
                if (numV.Value != 0)
                {
                    pode_N = true;
                    CheckEnableBtFazer();
                }
                else
                {
                    pode_N = false;
                    CheckEnableBtFazer();
                }
            }
        }

        private void txtC_TextChanged(object sender, EventArgs e)
        {
            if(txtC.Text != "") {
                pode_T = true;
                CheckEnableBtFazer();
            }
            else
            {
                btR.Enabled=false;
            }
        }
        private void CheckEnableBtFazer()
        {
            if (tipo == "Transferência")
            {
                btR.Enabled = pode_N && pode_T;
            }
        }
    }
}
