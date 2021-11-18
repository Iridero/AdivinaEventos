
namespace AdivinaEventos
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
            this.btnIniciar = new System.Windows.Forms.Button();
            this.nmrNumero = new System.Windows.Forms.NumericUpDown();
            this.btnAdivinar = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmrNumero)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(12, 12);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(201, 26);
            this.btnIniciar.TabIndex = 0;
            this.btnIniciar.Text = "Iniciar juego";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // nmrNumero
            // 
            this.nmrNumero.Enabled = false;
            this.nmrNumero.Location = new System.Drawing.Point(12, 44);
            this.nmrNumero.Maximum = new decimal(new int[] {
            5001,
            0,
            0,
            0});
            this.nmrNumero.Name = "nmrNumero";
            this.nmrNumero.Size = new System.Drawing.Size(120, 23);
            this.nmrNumero.TabIndex = 1;
            // 
            // btnAdivinar
            // 
            this.btnAdivinar.Enabled = false;
            this.btnAdivinar.Location = new System.Drawing.Point(138, 44);
            this.btnAdivinar.Name = "btnAdivinar";
            this.btnAdivinar.Size = new System.Drawing.Size(75, 23);
            this.btnAdivinar.TabIndex = 2;
            this.btnAdivinar.Text = "Adivinar";
            this.btnAdivinar.UseVisualStyleBackColor = true;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Enabled = false;
            this.btnFinalizar.Location = new System.Drawing.Point(12, 73);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(201, 23);
            this.btnFinalizar.TabIndex = 3;
            this.btnFinalizar.Text = "Terminar juego";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 113);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnAdivinar);
            this.Controls.Add(this.nmrNumero);
            this.Controls.Add(this.btnIniciar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrNumero)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.NumericUpDown nmrNumero;
        private System.Windows.Forms.Button btnAdivinar;
        private System.Windows.Forms.Button btnFinalizar;
    }
}

