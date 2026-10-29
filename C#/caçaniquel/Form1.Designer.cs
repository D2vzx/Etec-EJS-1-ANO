
namespace caçaniquel
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.picdima = new System.Windows.Forms.PictureBox();
            this.btnGirar = new System.Windows.Forms.Button();
            this.btnEncerrar = new System.Windows.Forms.Button();
            this.lblN1 = new System.Windows.Forms.Label();
            this.lblN2 = new System.Windows.Forms.Label();
            this.lblN3 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picdima)).BeginInit();
            this.SuspendLayout();
            // 
            // picdima
            // 
            this.picdima.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picdima.Image = global::caçaniquel.Properties.Resources.diamante;
            this.picdima.Location = new System.Drawing.Point(410, 225);
            this.picdima.Name = "picdima";
            this.picdima.Size = new System.Drawing.Size(356, 213);
            this.picdima.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picdima.TabIndex = 0;
            this.picdima.TabStop = false;
            this.picdima.Visible = false;
            this.picdima.Click += new System.EventHandler(this.picdima_Click);
            // 
            // btnGirar
            // 
            this.btnGirar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnGirar.Location = new System.Drawing.Point(12, 52);
            this.btnGirar.Name = "btnGirar";
            this.btnGirar.Size = new System.Drawing.Size(108, 91);
            this.btnGirar.TabIndex = 1;
            this.btnGirar.Text = "Girar";
            this.btnGirar.UseVisualStyleBackColor = false;
            this.btnGirar.Click += new System.EventHandler(this.btnGirar_Click);
            // 
            // btnEncerrar
            // 
            this.btnEncerrar.BackColor = System.Drawing.Color.Red;
            this.btnEncerrar.Location = new System.Drawing.Point(12, 170);
            this.btnEncerrar.Name = "btnEncerrar";
            this.btnEncerrar.Size = new System.Drawing.Size(111, 91);
            this.btnEncerrar.TabIndex = 2;
            this.btnEncerrar.Text = "Encerrar";
            this.btnEncerrar.UseVisualStyleBackColor = false;
            this.btnEncerrar.Click += new System.EventHandler(this.btnEncerrar_Click);
            // 
            // lblN1
            // 
            this.lblN1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblN1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN1.ForeColor = System.Drawing.Color.Red;
            this.lblN1.Location = new System.Drawing.Point(400, 51);
            this.lblN1.Name = "lblN1";
            this.lblN1.Size = new System.Drawing.Size(104, 90);
            this.lblN1.TabIndex = 3;
            this.lblN1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblN1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblN2
            // 
            this.lblN2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblN2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN2.ForeColor = System.Drawing.Color.Red;
            this.lblN2.Location = new System.Drawing.Point(521, 51);
            this.lblN2.Name = "lblN2";
            this.lblN2.Size = new System.Drawing.Size(113, 91);
            this.lblN2.TabIndex = 4;
            this.lblN2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblN3
            // 
            this.lblN3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblN3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN3.ForeColor = System.Drawing.Color.Red;
            this.lblN3.Location = new System.Drawing.Point(655, 52);
            this.lblN3.Name = "lblN3";
            this.lblN3.Size = new System.Drawing.Size(111, 91);
            this.lblN3.TabIndex = 5;
            this.lblN3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl
            // 
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(99, 338);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(203, 39);
            this.lbl.TabIndex = 6;
            this.lbl.Text = "CAÇA NÍQUEL";
            this.lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lblN3);
            this.Controls.Add(this.lblN2);
            this.Controls.Add(this.lblN1);
            this.Controls.Add(this.btnEncerrar);
            this.Controls.Add(this.btnGirar);
            this.Controls.Add(this.picdima);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picdima)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picdima;
        private System.Windows.Forms.Button btnGirar;
        private System.Windows.Forms.Button btnEncerrar;
        private System.Windows.Forms.Label lblN1;
        private System.Windows.Forms.Label lblN2;
        private System.Windows.Forms.Label lblN3;
        private System.Windows.Forms.Label lbl;
    }
}

