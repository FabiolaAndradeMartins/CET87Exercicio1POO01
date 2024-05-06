namespace FormsExercicioCronometro
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
            components = new System.ComponentModel.Container();
            btnOnOff = new Button();
            lblContador = new Label();
            TimerRelogio = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // btnOnOff
            // 
            btnOnOff.BackColor = Color.Linen;
            btnOnOff.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOnOff.Location = new Point(256, 180);
            btnOnOff.Name = "btnOnOff";
            btnOnOff.Size = new Size(75, 63);
            btnOnOff.TabIndex = 0;
            btnOnOff.Text = "Ligar";
            btnOnOff.UseVisualStyleBackColor = false;
            btnOnOff.Click += btnOnOff_Click;
            // 
            // lblContador
            // 
            lblContador.AutoSize = true;
            lblContador.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContador.Location = new Point(121, 88);
            lblContador.Name = "lblContador";
            lblContador.Size = new Size(93, 20);
            lblContador.TabIndex = 1;
            lblContador.Text = "00:00:00:00";
            // 
            // TimerRelogio
            // 
            TimerRelogio.Interval = 30;
            TimerRelogio.Tick += TimerRelogio_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(355, 266);
            Controls.Add(lblContador);
            Controls.Add(btnOnOff);
            Name = "Form1";
            Text = "Meu Cronómetro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOnOff;
        private Label lblContador;
        private System.Windows.Forms.Timer TimerRelogio;
    }
}
