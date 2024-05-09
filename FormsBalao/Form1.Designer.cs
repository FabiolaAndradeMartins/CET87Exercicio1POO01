namespace FormsBalao
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
            txtCor = new TextBox();
            label1 = new Label();
            txtDirecao = new TextBox();
            label2 = new Label();
            label3 = new Label();
            lblAlturaAtual = new Label();
            btnCor = new Button();
            btnDirecao = new Button();
            btnSubir = new Button();
            btnDescer = new Button();
            numX = new NumericUpDown();
            numY = new NumericUpDown();
            colorDialog1 = new ColorDialog();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)numX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // txtCor
            // 
            txtCor.Location = new Point(32, 50);
            txtCor.Name = "txtCor";
            txtCor.Size = new Size(100, 23);
            txtCor.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 32);
            label1.Name = "label1";
            label1.Size = new Size(29, 17);
            label1.TabIndex = 1;
            label1.Text = "Cor";
            // 
            // txtDirecao
            // 
            txtDirecao.Location = new Point(32, 108);
            txtDirecao.Name = "txtDirecao";
            txtDirecao.Size = new Size(100, 23);
            txtDirecao.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(32, 90);
            label2.Name = "label2";
            label2.Size = new Size(55, 17);
            label2.TabIndex = 1;
            label2.Text = "Direção";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(32, 161);
            label3.Name = "label3";
            label3.Size = new Size(46, 17);
            label3.TabIndex = 2;
            label3.Text = "Altura";
            // 
            // lblAlturaAtual
            // 
            lblAlturaAtual.AutoSize = true;
            lblAlturaAtual.BackColor = Color.Transparent;
            lblAlturaAtual.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAlturaAtual.Location = new Point(32, 190);
            lblAlturaAtual.Name = "lblAlturaAtual";
            lblAlturaAtual.Size = new Size(43, 17);
            lblAlturaAtual.TabIndex = 3;
            lblAlturaAtual.Text = "label4";
            // 
            // btnCor
            // 
            btnCor.Location = new Point(138, 49);
            btnCor.Name = "btnCor";
            btnCor.Size = new Size(75, 23);
            btnCor.TabIndex = 4;
            btnCor.Text = "Mudar";
            btnCor.UseVisualStyleBackColor = true;
            btnCor.Click += btnCor_Click;
            // 
            // btnDirecao
            // 
            btnDirecao.Location = new Point(138, 108);
            btnDirecao.Name = "btnDirecao";
            btnDirecao.Size = new Size(75, 23);
            btnDirecao.TabIndex = 5;
            btnDirecao.Text = "Mudar";
            btnDirecao.UseVisualStyleBackColor = true;
            btnDirecao.Click += btnDirecao_Click;
            // 
            // btnSubir
            // 
            btnSubir.Location = new Point(174, 153);
            btnSubir.Name = "btnSubir";
            btnSubir.Size = new Size(75, 23);
            btnSubir.TabIndex = 6;
            btnSubir.Text = "Subir";
            btnSubir.UseVisualStyleBackColor = true;
            btnSubir.Click += btnSubir_Click;
            // 
            // btnDescer
            // 
            btnDescer.Location = new Point(174, 182);
            btnDescer.Name = "btnDescer";
            btnDescer.Size = new Size(75, 23);
            btnDescer.TabIndex = 7;
            btnDescer.Text = "Descer";
            btnDescer.UseVisualStyleBackColor = true;
            btnDescer.Click += btnDescer_Click;
            // 
            // numX
            // 
            numX.Location = new Point(117, 155);
            numX.Name = "numX";
            numX.Size = new Size(51, 23);
            numX.TabIndex = 8;
            // 
            // numY
            // 
            numY.Location = new Point(117, 182);
            numY.Name = "numY";
            numY.Size = new Size(51, 23);
            numY.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(275, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(69, 82);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(375, 118);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(91, 87);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(255, 203);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 87);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(478, 328);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(numY);
            Controls.Add(numX);
            Controls.Add(btnDescer);
            Controls.Add(btnSubir);
            Controls.Add(btnDirecao);
            Controls.Add(btnCor);
            Controls.Add(lblAlturaAtual);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtDirecao);
            Controls.Add(label1);
            Controls.Add(txtCor);
            Name = "Form1";
            Text = "Balão";
            ((System.ComponentModel.ISupportInitialize)numX).EndInit();
            ((System.ComponentModel.ISupportInitialize)numY).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCor;
        private Label label1;
        private TextBox txtDirecao;
        private Label label2;
        private Label label3;
        private Label lblAlturaAtual;
        private Button btnCor;
        private Button btnDirecao;
        private Button btnSubir;
        private Button btnDescer;
        private NumericUpDown numX;
        private NumericUpDown numY;
        private ColorDialog colorDialog1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}
