namespace FormsVeiculo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            lblStatusVeiculo = new Label();
            btnRegistaViagem = new Button();
            numQuilometros = new NumericUpDown();
            numLitros = new NumericUpDown();
            btnAbastecer = new Button();
            txtValorMedioPorKm = new TextBox();
            btnValorMedioPorKm = new Button();
            lblValorMedioPorKm = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numQuilometros).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numLitros).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(-18, 145);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(312, 223);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lblStatusVeiculo
            // 
            lblStatusVeiculo.AutoSize = true;
            lblStatusVeiculo.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatusVeiculo.Location = new Point(16, 14);
            lblStatusVeiculo.Name = "lblStatusVeiculo";
            lblStatusVeiculo.Size = new Size(119, 14);
            lblStatusVeiculo.TabIndex = 2;
            lblStatusVeiculo.Text = "lblStatusVeiculo";
            // 
            // btnRegistaViagem
            // 
            btnRegistaViagem.Location = new Point(424, 32);
            btnRegistaViagem.Name = "btnRegistaViagem";
            btnRegistaViagem.Size = new Size(154, 23);
            btnRegistaViagem.TabIndex = 3;
            btnRegistaViagem.Text = "Registar Viagem Km";
            btnRegistaViagem.UseVisualStyleBackColor = true;
            btnRegistaViagem.Click += btnRegistaViagem_Click;
            // 
            // numQuilometros
            // 
            numQuilometros.Location = new Point(324, 32);
            numQuilometros.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numQuilometros.Name = "numQuilometros";
            numQuilometros.Size = new Size(94, 23);
            numQuilometros.TabIndex = 4;
            // 
            // numLitros
            // 
            numLitros.Location = new Point(324, 71);
            numLitros.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numLitros.Name = "numLitros";
            numLitros.Size = new Size(94, 23);
            numLitros.TabIndex = 5;
            // 
            // btnAbastecer
            // 
            btnAbastecer.Location = new Point(424, 71);
            btnAbastecer.Name = "btnAbastecer";
            btnAbastecer.Size = new Size(154, 23);
            btnAbastecer.TabIndex = 6;
            btnAbastecer.Text = "Abastecer Litros";
            btnAbastecer.UseVisualStyleBackColor = true;
            btnAbastecer.Click += btnAbastecer_Click;
            // 
            // txtValorMedioPorKm
            // 
            txtValorMedioPorKm.Location = new Point(324, 109);
            txtValorMedioPorKm.Name = "txtValorMedioPorKm";
            txtValorMedioPorKm.Size = new Size(94, 23);
            txtValorMedioPorKm.TabIndex = 7;
            // 
            // btnValorMedioPorKm
            // 
            btnValorMedioPorKm.Location = new Point(424, 108);
            btnValorMedioPorKm.Name = "btnValorMedioPorKm";
            btnValorMedioPorKm.Size = new Size(154, 23);
            btnValorMedioPorKm.TabIndex = 8;
            btnValorMedioPorKm.Text = "Calcular ValorMedio/Km";
            btnValorMedioPorKm.UseVisualStyleBackColor = true;
            btnValorMedioPorKm.Click += btnValorMedioPorKm_Click;
            // 
            // lblValorMedioPorKm
            // 
            lblValorMedioPorKm.AutoSize = true;
            lblValorMedioPorKm.BackColor = Color.Transparent;
            lblValorMedioPorKm.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblValorMedioPorKm.ForeColor = Color.Yellow;
            lblValorMedioPorKm.Location = new Point(442, 134);
            lblValorMedioPorKm.Name = "lblValorMedioPorKm";
            lblValorMedioPorKm.Size = new Size(40, 15);
            lblValorMedioPorKm.TabIndex = 9;
            lblValorMedioPorKm.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(669, 390);
            Controls.Add(lblValorMedioPorKm);
            Controls.Add(btnValorMedioPorKm);
            Controls.Add(txtValorMedioPorKm);
            Controls.Add(btnAbastecer);
            Controls.Add(numLitros);
            Controls.Add(numQuilometros);
            Controls.Add(btnRegistaViagem);
            Controls.Add(lblStatusVeiculo);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Veículo";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numQuilometros).EndInit();
            ((System.ComponentModel.ISupportInitialize)numLitros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label lblStatusVeiculo;
        private Button btnRegistaViagem;
        private NumericUpDown numQuilometros;
        private NumericUpDown numLitros;
        private Button btnAbastecer;
        private TextBox txtValorMedioPorKm;
        private Button btnValorMedioPorKm;
        private Label lblValorMedioPorKm;
    }
}
