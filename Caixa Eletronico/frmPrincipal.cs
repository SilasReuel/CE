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
    public partial class frmPrincipal : Form
    {
        Singleton s;
        public frmPrincipal()
        {
            InitializeComponent();
            s = Singleton.Instance;
        }

        private void btV_Click(object sender, EventArgs e)
        {
            FrmInicial frm = new FrmInicial();
            frm.Show();
            this.Close();
        }

        private void btE_Click(object sender, EventArgs e)
        {
            frmExtrato frm = new frmExtrato();
            frm.Show();
            this.Hide();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblSaldo.Text = s.conta_logada.Saldo.ToString();
        }

        private void lblSaldo_Click(object sender, EventArgs e)
        {

        }

        private void btS_Click(object sender, EventArgs e)
        {
            frmProc frm = new frmProc("Saque");
            frm.Show();
            this.Hide();
        }

        private void btD_Click(object sender, EventArgs e)
        {
            frmProc frm = new frmProc("Depósito");
            frm.Show();
            this.Hide();
        }

        private void btT_Click(object sender, EventArgs e)
        {
            frmProc frm = new frmProc("Transferência");
            frm.Show();
            this.Hide();
        }
    }
}
