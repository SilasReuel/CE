namespace Caixa_Eletronico
{
    partial class frmExtrato
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
            dgvE = new DataGridView();
            btV = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvE).BeginInit();
            SuspendLayout();
            // 
            // dgvE
            // 
            dgvE.BackgroundColor = SystemColors.ActiveCaption;
            dgvE.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvE.Location = new Point(34, 35);
            dgvE.Margin = new Padding(3, 4, 3, 4);
            dgvE.Name = "dgvE";
            dgvE.RowHeadersWidth = 51;
            dgvE.Size = new Size(614, 336);
            dgvE.TabIndex = 0;
            // 
            // btV
            // 
            btV.Location = new Point(683, 35);
            btV.Margin = new Padding(3, 4, 3, 4);
            btV.Name = "btV";
            btV.Size = new Size(86, 31);
            btV.TabIndex = 1;
            btV.Text = "Voltar";
            btV.UseVisualStyleBackColor = true;
            btV.Click += btVoltar_Click;
            // 
            // frmExtrato
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(783, 397);
            Controls.Add(btV);
            Controls.Add(dgvE);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmExtrato";
            Text = "frmExtrato";
            Load += frmExtrato_Load;
            ((System.ComponentModel.ISupportInitialize)dgvE).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvE;
        private Button btV;
    }
}