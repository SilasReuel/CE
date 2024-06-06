namespace Caixa_Eletronico
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btV = new Button();
            btS = new Button();
            btD = new Button();
            btT = new Button();
            btE = new Button();
            label1 = new Label();
            lblSaldo = new Label();
            SuspendLayout();
            // 
            // btV
            // 
            btV.BackColor = SystemColors.Control;
            btV.Location = new Point(14, 16);
            btV.Margin = new Padding(3, 4, 3, 4);
            btV.Name = "btV";
            btV.Size = new Size(86, 31);
            btV.TabIndex = 0;
            btV.Text = "Voltar";
            btV.UseVisualStyleBackColor = false;
            // 
            // btS
            // 
            btS.BackColor = SystemColors.Control;
            btS.Location = new Point(127, 122);
            btS.Margin = new Padding(3, 4, 3, 4);
            btS.Name = "btS";
            btS.Size = new Size(237, 51);
            btS.TabIndex = 1;
            btS.Text = "Sacar";
            btS.UseVisualStyleBackColor = false;
            // 
            // btD
            // 
            btD.BackColor = SystemColors.Control;
            btD.Location = new Point(127, 181);
            btD.Margin = new Padding(3, 4, 3, 4);
            btD.Name = "btD";
            btD.Size = new Size(237, 51);
            btD.TabIndex = 2;
            btD.Text = "Depositar";
            btD.UseVisualStyleBackColor = false;
            // 
            // btT
            // 
            btT.BackColor = SystemColors.Control;
            btT.Location = new Point(127, 240);
            btT.Margin = new Padding(3, 4, 3, 4);
            btT.Name = "btT";
            btT.Size = new Size(237, 51);
            btT.TabIndex = 3;
            btT.Text = "Transferir";
            btT.UseVisualStyleBackColor = false;
            // 
            // btE
            // 
            btE.BackColor = SystemColors.Control;
            btE.Location = new Point(127, 299);
            btE.Margin = new Padding(3, 4, 3, 4);
            btE.Name = "btE";
            btE.Size = new Size(237, 51);
            btE.TabIndex = 5;
            btE.Text = "Extrato";
            btE.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(369, 21);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 6;
            label1.Text = "Saldo: ";
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Location = new Point(424, 21);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(0, 20);
            lblSaldo.TabIndex = 7;
            lblSaldo.Click += lblSaldo_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(488, 404);
            Controls.Add(lblSaldo);
            Controls.Add(label1);
            Controls.Add(btE);
            Controls.Add(btT);
            Controls.Add(btD);
            Controls.Add(btS);
            Controls.Add(btV);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmPrincipal";
            Text = "frmPrincipal";
            Load += frmPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btV;
        private Button btS;
        private Button btD;
        private Button btT;
        private Button btE;
        private Label label1;
        private Label lblSaldo;
    }
}