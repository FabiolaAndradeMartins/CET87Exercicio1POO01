namespace FormsPost
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
            lblTitulo = new Label();
            lblTexto = new Label();
            lbl = new Label();
            btnLike = new Button();
            btnDislike = new Button();
            lblTituloPost = new Label();
            btnAnterior = new Button();
            btnProximo = new Button();
            lblData = new Label();
            lblLike = new Label();
            lblDislike = new Label();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Tahoma", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(12, 38);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(776, 69);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Blog EducAção";
            // 
            // lblTexto
            // 
            lblTexto.BackColor = Color.Transparent;
            lblTexto.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTexto.Location = new Point(22, 172);
            lblTexto.Name = "lblTexto";
            lblTexto.Size = new Size(754, 154);
            lblTexto.TabIndex = 1;
            lblTexto.Text = resources.GetString("lblTexto.Text");
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.BackColor = Color.Transparent;
            lbl.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl.Location = new Point(12, 338);
            lbl.Name = "lbl";
            lbl.Size = new Size(107, 18);
            lbl.TabIndex = 2;
            lbl.Text = "Data do Post:";
            lbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnLike
            // 
            btnLike.BackColor = Color.FromArgb(255, 224, 192);
            btnLike.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLike.Location = new Point(547, 384);
            btnLike.Name = "btnLike";
            btnLike.Size = new Size(127, 39);
            btnLike.TabIndex = 3;
            btnLike.Text = "Like";
            btnLike.UseVisualStyleBackColor = false;
            btnLike.Click += btnLike_Click;
            // 
            // btnDislike
            // 
            btnDislike.BackColor = Color.FromArgb(255, 192, 192);
            btnDislike.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDislike.ImageAlign = ContentAlignment.MiddleLeft;
            btnDislike.Location = new Point(260, 384);
            btnDislike.Name = "btnDislike";
            btnDislike.Size = new Size(127, 39);
            btnDislike.TabIndex = 4;
            btnDislike.Text = "Dislike";
            btnDislike.UseVisualStyleBackColor = false;
            btnDislike.Click += btnDislike_Click;
            // 
            // lblTituloPost
            // 
            lblTituloPost.AutoSize = true;
            lblTituloPost.BackColor = Color.Transparent;
            lblTituloPost.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloPost.Location = new Point(47, 125);
            lblTituloPost.Name = "lblTituloPost";
            lblTituloPost.Size = new Size(55, 21);
            lblTituloPost.TabIndex = 5;
            lblTituloPost.Text = "Título";
            // 
            // btnAnterior
            // 
            btnAnterior.BackColor = Color.MistyRose;
            btnAnterior.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAnterior.Location = new Point(557, 38);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(85, 33);
            btnAnterior.TabIndex = 6;
            btnAnterior.Text = "Anterior";
            btnAnterior.UseVisualStyleBackColor = false;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // btnProximo
            // 
            btnProximo.BackColor = Color.MistyRose;
            btnProximo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProximo.Location = new Point(668, 38);
            btnProximo.Name = "btnProximo";
            btnProximo.Size = new Size(70, 33);
            btnProximo.TabIndex = 7;
            btnProximo.Text = "Próximo";
            btnProximo.UseVisualStyleBackColor = false;
            btnProximo.Click += btnProximo_Click;
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.BackColor = Color.Transparent;
            lblData.Location = new Point(140, 340);
            lblData.Name = "lblData";
            lblData.Size = new Size(38, 15);
            lblData.TabIndex = 8;
            lblData.Text = "label1";
            // 
            // lblLike
            // 
            lblLike.AutoSize = true;
            lblLike.BackColor = Color.Transparent;
            lblLike.Location = new Point(680, 400);
            lblLike.Name = "lblLike";
            lblLike.Size = new Size(38, 15);
            lblLike.TabIndex = 9;
            lblLike.Text = "label1";
            // 
            // lblDislike
            // 
            lblDislike.AutoSize = true;
            lblDislike.BackColor = Color.Transparent;
            lblDislike.Location = new Point(393, 400);
            lblDislike.Name = "lblDislike";
            lblDislike.Size = new Size(38, 15);
            lblDislike.TabIndex = 10;
            lblDislike.Text = "label2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(lblDislike);
            Controls.Add(lblLike);
            Controls.Add(lblData);
            Controls.Add(btnProximo);
            Controls.Add(btnAnterior);
            Controls.Add(lblTituloPost);
            Controls.Add(btnDislike);
            Controls.Add(btnLike);
            Controls.Add(lbl);
            Controls.Add(lblTexto);
            Controls.Add(lblTitulo);
            Name = "Form1";
            Text = "Meus Posts";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblTexto;
        private Label lbl;
        private Button btnLike;
        private Button btnDislike;
        private Label lblTituloPost;
        private Button btnAnterior;
        private Button btnProximo;
        private Label lblData;
        private Label lblLike;
        private Label lblDislike;
    }
}
