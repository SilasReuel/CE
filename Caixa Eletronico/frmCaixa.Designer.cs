namespace Caixa_Eletronico
{
    partial class frmCaixa
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
            components = new System.ComponentModel.Container();
            lblNome = new Label();
            btA = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            campo = new TextBox();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(69, 101);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(51, 20);
            lblNome.TabIndex = 0;
            lblNome.Text = "Conta:";
            // 
            // btA
            // 
            btA.BackColor = SystemColors.Control;
            btA.Location = new Point(152, 161);
            btA.Margin = new Padding(3, 4, 3, 4);
            btA.Name = "btA";
            btA.Size = new Size(141, 37);
            btA.TabIndex = 1;
            btA.Text = "Acessar";
            btA.UseVisualStyleBackColor = false;
            btA.Click += btAcessar_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // campo
            // 
            campo.BackColor = SystemColors.Control;
            campo.Location = new Point(123, 97);
            campo.Margin = new Padding(3, 4, 3, 4);
            campo.Name = "campo";
            campo.Size = new Size(209, 27);
            campo.TabIndex = 3;
            campo.TextChanged += textBox1_TextChanged;
            // 
            // frmCaixa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(467, 260);
            Controls.Add(campo);
            Controls.Add(btA);
            Controls.Add(lblNome);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmCaixa";
            Text = "frmCaixa";
            Load += frmCaixa_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private Button btA;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox campo;
    }
}