namespace Caixa_Eletronico
{
    partial class frmAdm
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
            dgvContas = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNumero = new TextBox();
            chbEspecial = new CheckBox();
            numLimite = new NumericUpDown();
            numSaldo = new NumericUpDown();
            cboxTipo = new ComboBox();
            btC = new Button();
            chbStatus = new CheckBox();
            btS = new Button();
            btE = new Button();
            btV = new Button();
            btCan = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvContas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numLimite).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSaldo).BeginInit();
            SuspendLayout();
            // 
            // dgvContas
            // 
            dgvContas.AllowUserToAddRows = false;
            dgvContas.AllowUserToDeleteRows = false;
            dgvContas.AllowUserToResizeColumns = false;
            dgvContas.AllowUserToResizeRows = false;
            dgvContas.BackgroundColor = SystemColors.ActiveCaption;
            dgvContas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContas.Location = new Point(14, 16);
            dgvContas.Margin = new Padding(3, 4, 3, 4);
            dgvContas.Name = "dgvContas";
            dgvContas.ReadOnly = true;
            dgvContas.RowHeadersWidth = 51;
            dgvContas.Size = new Size(514, 568);
            dgvContas.TabIndex = 0;
            dgvContas.CellClick += dgvContas_CellClick;
            dgvContas.CellContentClick += dgvContas_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(579, 63);
            label1.Name = "label1";
            label1.Size = new Size(128, 20);
            label1.TabIndex = 1;
            label1.Text = "Número da conta:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(648, 173);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 2;
            label2.Text = "Limite:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(653, 233);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 3;
            label3.Text = "Saldo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(659, 115);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 4;
            label4.Text = "Tipo:";
            // 
            // txtNumero
            // 
            txtNumero.BackColor = SystemColors.Control;
            txtNumero.Location = new Point(704, 59);
            txtNumero.Margin = new Padding(3, 4, 3, 4);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(140, 27);
            txtNumero.TabIndex = 1;
            txtNumero.TextChanged += txtNumero_TextChanged;
            // 
            // chbEspecial
            // 
            chbEspecial.AutoSize = true;
            chbEspecial.Location = new Point(704, 284);
            chbEspecial.Margin = new Padding(3, 4, 3, 4);
            chbEspecial.Name = "chbEspecial";
            chbEspecial.Size = new Size(85, 24);
            chbEspecial.TabIndex = 5;
            chbEspecial.Text = "Especial";
            chbEspecial.UseVisualStyleBackColor = true;
            // 
            // numLimite
            // 
            numLimite.BackColor = SystemColors.Control;
            numLimite.Location = new Point(704, 171);
            numLimite.Margin = new Padding(3, 4, 3, 4);
            numLimite.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numLimite.Name = "numLimite";
            numLimite.Size = new Size(137, 27);
            numLimite.TabIndex = 3;
            // 
            // numSaldo
            // 
            numSaldo.BackColor = SystemColors.ControlDark;
            numSaldo.Location = new Point(704, 231);
            numSaldo.Margin = new Padding(3, 4, 3, 4);
            numSaldo.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numSaldo.Name = "numSaldo";
            numSaldo.ReadOnly = true;
            numSaldo.Size = new Size(137, 27);
            numSaldo.TabIndex = 4;
            // 
            // cboxTipo
            // 
            cboxTipo.BackColor = SystemColors.Control;
            cboxTipo.FormattingEnabled = true;
            cboxTipo.Items.AddRange(new object[] { "Conta Corrente", "Conta Poupança" });
            cboxTipo.Location = new Point(704, 111);
            cboxTipo.Margin = new Padding(3, 4, 3, 4);
            cboxTipo.Name = "cboxTipo";
            cboxTipo.Size = new Size(138, 28);
            cboxTipo.TabIndex = 2;
            cboxTipo.SelectedIndexChanged += cboxTipo_SelectedIndexChanged;
            // 
            // btC
            // 
            btC.BackColor = SystemColors.Control;
            btC.Location = new Point(550, 553);
            btC.Margin = new Padding(3, 4, 3, 4);
            btC.Name = "btC";
            btC.Size = new Size(122, 31);
            btC.TabIndex = 7;
            btC.Text = "Cadastrar";
            btC.UseVisualStyleBackColor = false;
            btC.Click += btCadastrar_Click;
            // 
            // chbStatus
            // 
            chbStatus.AutoSize = true;
            chbStatus.Enabled = false;
            chbStatus.Location = new Point(704, 317);
            chbStatus.Margin = new Padding(3, 4, 3, 4);
            chbStatus.Name = "chbStatus";
            chbStatus.Size = new Size(71, 24);
            chbStatus.TabIndex = 6;
            chbStatus.Text = "Status";
            chbStatus.UseVisualStyleBackColor = true;
            // 
            // btS
            // 
            btS.BackColor = SystemColors.Control;
            btS.Location = new Point(679, 553);
            btS.Margin = new Padding(3, 4, 3, 4);
            btS.Name = "btS";
            btS.Size = new Size(123, 31);
            btS.TabIndex = 8;
            btS.Text = "Salvar";
            btS.UseVisualStyleBackColor = false;
            btS.Click += btSalvar_Click;
            // 
            // btE
            // 
            btE.BackColor = SystemColors.Control;
            btE.Location = new Point(809, 553);
            btE.Margin = new Padding(3, 4, 3, 4);
            btE.Name = "btE";
            btE.Size = new Size(86, 31);
            btE.TabIndex = 9;
            btE.Text = "Excluir";
            btE.UseVisualStyleBackColor = false;
            btE.Click += btExcluir_Click;
            // 
            // btV
            // 
            btV.BackColor = SystemColors.Control;
            btV.Location = new Point(14, 592);
            btV.Margin = new Padding(3, 4, 3, 4);
            btV.Name = "btV";
            btV.Size = new Size(86, 31);
            btV.TabIndex = 10;
            btV.Text = "Voltar";
            btV.UseVisualStyleBackColor = false;
            btV.Click += btVoltar_Click;
            // 
            // btCan
            // 
            btCan.BackColor = SystemColors.Control;
            btCan.Location = new Point(106, 592);
            btCan.Margin = new Padding(3, 4, 3, 4);
            btCan.Name = "btCan";
            btCan.Size = new Size(86, 31);
            btCan.TabIndex = 11;
            btCan.Text = "Cancelar";
            btCan.UseVisualStyleBackColor = false;
            btCan.Click += btCancelar_Click;
            // 
            // frmAdm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(914, 633);
            Controls.Add(btCan);
            Controls.Add(btV);
            Controls.Add(btE);
            Controls.Add(btS);
            Controls.Add(chbStatus);
            Controls.Add(btC);
            Controls.Add(cboxTipo);
            Controls.Add(numSaldo);
            Controls.Add(numLimite);
            Controls.Add(chbEspecial);
            Controls.Add(txtNumero);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvContas);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmAdm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CTiBank - Acesso Administrativo";
            FormClosing += frmAdm_FormClosing;
            Load += frmAdm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvContas).EndInit();
            ((System.ComponentModel.ISupportInitialize)numLimite).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSaldo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvContas;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNumero;
        private CheckBox chbEspecial;
        private NumericUpDown numLimite;
        private NumericUpDown numSaldo;
        private ComboBox cboxTipo;
        private Button btC;
        private CheckBox chbStatus;
        private Button btS;
        private Button btE;
        private Button btV;
        private Button btCan;
    }
}