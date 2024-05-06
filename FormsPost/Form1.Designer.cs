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
            llblTitulo = new Label();
            lblDescricao = new Label();
            lblData = new Label();
            btnLike = new Button();
            btnDislike = new Button();
            SuspendLayout();
            // 
            // llblTitulo
            // 
            llblTitulo.AutoSize = true;
            llblTitulo.BackColor = Color.White;
            llblTitulo.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            llblTitulo.Location = new Point(38, 125);
            llblTitulo.Name = "llblTitulo";
            llblTitulo.Size = new Size(236, 25);
            llblTitulo.TabIndex = 0;
            llblTitulo.Text = "Transição de Carreira";
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.BackColor = Color.White;
            lblDescricao.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescricao.Location = new Point(22, 219);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(754, 76);
            lblDescricao.TabIndex = 1;
            lblDescricao.Text = resources.GetString("lblDescricao.Text");
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.BackColor = Color.White;
            lblData.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblData.Location = new Point(12, 338);
            lblData.Name = "lblData";
            lblData.Size = new Size(107, 18);
            lblData.TabIndex = 2;
            lblData.Text = "Data do Post:";
            lblData.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnLike
            // 
            btnLike.BackColor = Color.FromArgb(255, 224, 192);
            btnLike.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLike.Location = new Point(576, 399);
            btnLike.Name = "btnLike";
            btnLike.Size = new Size(127, 39);
            btnLike.TabIndex = 3;
            btnLike.Text = "Like";
            btnLike.UseVisualStyleBackColor = false;
            // 
            // btnDislike
            // 
            btnDislike.BackColor = Color.FromArgb(255, 192, 192);
            btnDislike.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDislike.ImageAlign = ContentAlignment.MiddleLeft;
            btnDislike.Location = new Point(355, 399);
            btnDislike.Name = "btnDislike";
            btnDislike.Size = new Size(127, 39);
            btnDislike.TabIndex = 4;
            btnDislike.Text = "Dislike";
            btnDislike.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(btnDislike);
            Controls.Add(btnLike);
            Controls.Add(lblData);
            Controls.Add(lblDescricao);
            Controls.Add(llblTitulo);
            Name = "Form1";
            Text = "Meus Posts";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label llblTitulo;
        private Label lblDescricao;
        private Label lblData;
        private Button btnLike;
        private Button btnDislike;
    }
}
