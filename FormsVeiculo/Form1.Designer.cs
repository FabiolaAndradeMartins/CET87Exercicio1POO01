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
            txtValorLitro = new TextBox();
            label1 = new Label();
            label2 = new Label();
            lblAbastecer = new Label();
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
            btnRegistaViagem.Location = new Point(513, 119);
            btnRegistaViagem.Name = "btnRegistaViagem";
            btnRegistaViagem.Size = new Size(154, 23);
            btnRegistaViagem.TabIndex = 3;
            btnRegistaViagem.Text = "Registar Viagem Km";
            btnRegistaViagem.UseVisualStyleBackColor = true;
            btnRegistaViagem.Click += btnRegistaViagem_Click;
            // 
            // numQuilometros
            // 
            numQuilometros.Location = new Point(413, 119);
            numQuilometros.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numQuilometros.Name = "numQuilometros";
            numQuilometros.Size = new Size(94, 23);
            numQuilometros.TabIndex = 4;
            // 
            // numLitros
            // 
            numLitros.Location = new Point(413, 205);
            numLitros.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numLitros.Name = "numLitros";
            numLitros.Size = new Size(94, 23);
            numLitros.TabIndex = 5;
            // 
            // btnAbastecer
            // 
            btnAbastecer.Location = new Point(513, 187);
            btnAbastecer.Name = "btnAbastecer";
            btnAbastecer.Size = new Size(154, 88);
            btnAbastecer.TabIndex = 6;
            btnAbastecer.Text = "Abastecer Litros";
            btnAbastecer.UseVisualStyleBackColor = true;
            btnAbastecer.Click += btnAbastecer_Click;
            // 
            // txtValorLitro
            // 
            txtValorLitro.Location = new Point(413, 252);
            txtValorLitro.Name = "txtValorLitro";
            txtValorLitro.Size = new Size(94, 23);
            txtValorLitro.TabIndex = 7;
            txtValorLitro.Text = "1,75";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(413, 187);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 8;
            label1.Text = "Litros";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(413, 234);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 9;
            label2.Text = "Valor Litro";
            // 
            // lblAbastecer
            // 
            lblAbastecer.AutoSize = true;
            lblAbastecer.BackColor = Color.Transparent;
            lblAbastecer.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAbastecer.ForeColor = Color.Yellow;
            lblAbastecer.Location = new Point(424, 288);
            lblAbastecer.Name = "lblAbastecer";
            lblAbastecer.Size = new Size(49, 14);
            lblAbastecer.TabIndex = 10;
            lblAbastecer.Text = "label3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(669, 390);
            Controls.Add(lblAbastecer);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtValorLitro);
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
        private TextBox txtValorLitro;
        private Label label1;
        private Label label2;
        private Label lblAbastecer;
    }
}
