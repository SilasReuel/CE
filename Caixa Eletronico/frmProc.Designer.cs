namespace Caixa_Eletronico
{
    partial class frmProc
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
            label1 = new Label();
            numV = new NumericUpDown();
            lblOp = new Label();
            btR = new Button();
            lblNome = new Label();
            txtC = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numV).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(128, 61);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 0;
            label1.Text = "Valor:";
            // 
            // numV
            // 
            numV.BackColor = SystemColors.Control;
            numV.Location = new Point(128, 85);
            numV.Margin = new Padding(3, 4, 3, 4);
            numV.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numV.Name = "numV";
            numV.Size = new Size(155, 27);
            numV.TabIndex = 1;
            // 
            // lblOp
            // 
            lblOp.AutoSize = true;
            lblOp.Location = new Point(169, 12);
            lblOp.Name = "lblOp";
            lblOp.Size = new Size(0, 20);
            lblOp.TabIndex = 2;
            // 
            // btR
            // 
            btR.BackColor = SystemColors.Control;
            btR.Enabled = false;
            btR.Location = new Point(128, 241);
            btR.Margin = new Padding(3, 4, 3, 4);
            btR.Name = "btR";
            btR.Size = new Size(155, 33);
            btR.TabIndex = 3;
            btR.Text = "Realizar";
            btR.UseVisualStyleBackColor = false;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(128, 133);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(181, 20);
            lblNome.TabIndex = 5;
            lblNome.Text = "Número da conta destino:";
            lblNome.Visible = false;
            // 
            // txtC
            // 
            txtC.BackColor = SystemColors.Control;
            txtC.Location = new Point(128, 157);
            txtC.Margin = new Padding(3, 4, 3, 4);
            txtC.Name = "txtC";
            txtC.Size = new Size(155, 27);
            txtC.TabIndex = 6;
            txtC.Visible = false;
            // 
            // frmProc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(402, 289);
            Controls.Add(txtC);
            Controls.Add(lblNome);
            Controls.Add(btR);
            Controls.Add(lblOp);
            Controls.Add(numV);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmProc";
            Text = "frmProc";
            Load += frmProc_Load;
            ((System.ComponentModel.ISupportInitialize)numV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown numV;
        private Label lblOp;
        private Button btR;
        private Label lblNome;
        private TextBox txtC;
    }
}