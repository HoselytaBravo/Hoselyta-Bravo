
namespace AppMatrices
{
    partial class lblmarge
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
            this.lblContador = new System.Windows.Forms.Label();
            this.labelContador = new System.Windows.Forms.Label();
            this.btnDisminuir = new System.Windows.Forms.Button();
            this.buttonReiniciar = new System.Windows.Forms.Button();
            this.buttonIncrementar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Font = new System.Drawing.Font("Monospac821 BT", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblContador.Location = new System.Drawing.Point(203, 63);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(376, 96);
            this.lblContador.TabIndex = 0;
            this.lblContador.Text = "COUNTER";
            // 
            // labelContador
            // 
            this.labelContador.AutoSize = true;
            this.labelContador.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContador.ForeColor = System.Drawing.Color.Blue;
            this.labelContador.Location = new System.Drawing.Point(347, 150);
            this.labelContador.Name = "labelContador";
            this.labelContador.Size = new System.Drawing.Size(125, 135);
            this.labelContador.TabIndex = 1;
            this.labelContador.Text = "0";
            // 
            // btnDisminuir
            // 
            this.btnDisminuir.Location = new System.Drawing.Point(73, 340);
            this.btnDisminuir.Name = "btnDisminuir";
            this.btnDisminuir.Size = new System.Drawing.Size(203, 59);
            this.btnDisminuir.TabIndex = 2;
            this.btnDisminuir.Text = "DISMINUIR";
            this.btnDisminuir.UseVisualStyleBackColor = true;
            this.btnDisminuir.Click += new System.EventHandler(this.btnDisminuir_Click);
            // 
            // buttonReiniciar
            // 
            this.buttonReiniciar.Location = new System.Drawing.Point(325, 340);
            this.buttonReiniciar.Name = "buttonReiniciar";
            this.buttonReiniciar.Size = new System.Drawing.Size(203, 59);
            this.buttonReiniciar.TabIndex = 3;
            this.buttonReiniciar.Text = "REINICIAR";
            this.buttonReiniciar.UseVisualStyleBackColor = true;
            this.buttonReiniciar.Click += new System.EventHandler(this.buttonReiniciar_Click);
            // 
            // buttonIncrementar
            // 
            this.buttonIncrementar.Location = new System.Drawing.Point(568, 340);
            this.buttonIncrementar.Name = "buttonIncrementar";
            this.buttonIncrementar.Size = new System.Drawing.Size(203, 59);
            this.buttonIncrementar.TabIndex = 4;
            this.buttonIncrementar.Text = "INCREMENTAR";
            this.buttonIncrementar.UseVisualStyleBackColor = true;
            this.buttonIncrementar.Click += new System.EventHandler(this.buttonIncrementar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(728, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 49);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblmarge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(810, 462);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonIncrementar);
            this.Controls.Add(this.buttonReiniciar);
            this.Controls.Add(this.btnDisminuir);
            this.Controls.Add(this.labelContador);
            this.Controls.Add(this.lblContador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "lblmarge";
            this.Text = "Contador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Label labelContador;
        private System.Windows.Forms.Button btnDisminuir;
        private System.Windows.Forms.Button buttonReiniciar;
        private System.Windows.Forms.Button buttonIncrementar;
        private System.Windows.Forms.Button button1;
    }
}