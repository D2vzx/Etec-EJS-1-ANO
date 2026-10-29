namespace Relatorio_certo
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
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.rdbmaoo = new System.Windows.Forms.RadioButton();
            this.rdbpeemaoo = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupbox2 = new System.Windows.Forms.GroupBox();
            this.chkbcafe = new System.Windows.Forms.CheckBox();
            this.chkbchoco = new System.Windows.Forms.CheckBox();
            this.chkbsuco = new System.Windows.Forms.CheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.LstBox2 = new System.Windows.Forms.ListBox();
            this.rdbpee = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupbox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnexcluir
            // 
            this.btnexcluir.BackColor = System.Drawing.SystemColors.Info;
            this.btnexcluir.Location = new System.Drawing.Point(448, 377);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(127, 88);
            this.btnexcluir.TabIndex = 0;
            this.btnexcluir.Text = "Excluir items do relatório ";
            this.btnexcluir.UseVisualStyleBackColor = false;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.BackColor = System.Drawing.SystemColors.Info;
            this.btnlimpar.Location = new System.Drawing.Point(581, 377);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(126, 88);
            this.btnlimpar.TabIndex = 1;
            this.btnlimpar.Text = "Limpar relatório";
            this.btnlimpar.UseVisualStyleBackColor = false;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // rdbmaoo
            // 
            this.rdbmaoo.AutoSize = true;
            this.rdbmaoo.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbmaoo.Location = new System.Drawing.Point(6, 66);
            this.rdbmaoo.Name = "rdbmaoo";
            this.rdbmaoo.Size = new System.Drawing.Size(55, 20);
            this.rdbmaoo.TabIndex = 3;
            this.rdbmaoo.TabStop = true;
            this.rdbmaoo.Text = "Mão";
            this.rdbmaoo.UseVisualStyleBackColor = true;
            this.rdbmaoo.CheckedChanged += new System.EventHandler(this.rdbmaoo_CheckedChanged);
            // 
            // rdbpeemaoo
            // 
            this.rdbpeemaoo.AutoSize = true;
            this.rdbpeemaoo.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbpeemaoo.Location = new System.Drawing.Point(6, 102);
            this.rdbpeemaoo.Name = "rdbpeemaoo";
            this.rdbpeemaoo.Size = new System.Drawing.Size(85, 20);
            this.rdbpeemaoo.TabIndex = 4;
            this.rdbpeemaoo.TabStop = true;
            this.rdbpeemaoo.Text = "Pé e Mão";
            this.rdbpeemaoo.UseVisualStyleBackColor = true;
            this.rdbpeemaoo.CheckedChanged += new System.EventHandler(this.rdbpeemaoo_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Controls.Add(this.rdbpee);
            this.groupBox1.Controls.Add(this.rdbmaoo);
            this.groupBox1.Controls.Add(this.rdbpeemaoo);
            this.groupBox1.Location = new System.Drawing.Point(41, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 157);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serviços";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupbox2
            // 
            this.groupbox2.BackColor = System.Drawing.SystemColors.Info;
            this.groupbox2.Controls.Add(this.chkbcafe);
            this.groupbox2.Controls.Add(this.chkbchoco);
            this.groupbox2.Controls.Add(this.chkbsuco);
            this.groupbox2.Location = new System.Drawing.Point(41, 254);
            this.groupbox2.Name = "groupbox2";
            this.groupbox2.Size = new System.Drawing.Size(170, 164);
            this.groupbox2.TabIndex = 6;
            this.groupbox2.TabStop = false;
            this.groupbox2.Text = "Cantina";
            // 
            // chkbcafe
            // 
            this.chkbcafe.AutoSize = true;
            this.chkbcafe.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbcafe.Location = new System.Drawing.Point(14, 82);
            this.chkbcafe.Name = "chkbcafe";
            this.chkbcafe.Size = new System.Drawing.Size(56, 20);
            this.chkbcafe.TabIndex = 8;
            this.chkbcafe.Text = "Café";
            this.chkbcafe.UseVisualStyleBackColor = true;
            this.chkbcafe.CheckedChanged += new System.EventHandler(this.chkbcafe_CheckedChanged);
            // 
            // chkbchoco
            // 
            this.chkbchoco.AutoSize = true;
            this.chkbchoco.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbchoco.Location = new System.Drawing.Point(14, 123);
            this.chkbchoco.Name = "chkbchoco";
            this.chkbchoco.Size = new System.Drawing.Size(90, 20);
            this.chkbchoco.TabIndex = 9;
            this.chkbchoco.Text = "Chocolate";
            this.chkbchoco.UseVisualStyleBackColor = true;
            this.chkbchoco.CheckedChanged += new System.EventHandler(this.chkbchoco_CheckedChanged);
            // 
            // chkbsuco
            // 
            this.chkbsuco.AutoSize = true;
            this.chkbsuco.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbsuco.Location = new System.Drawing.Point(14, 39);
            this.chkbsuco.Name = "chkbsuco";
            this.chkbsuco.Size = new System.Drawing.Size(58, 20);
            this.chkbsuco.TabIndex = 7;
            this.chkbsuco.Text = "Suco";
            this.chkbsuco.UseVisualStyleBackColor = true;
            this.chkbsuco.CheckedChanged += new System.EventHandler(this.chkbsuco_CheckedChanged);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Info;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Escova",
            "Tintura",
            "Hidratação",
            "Penteado",
            "Luzes"});
            this.listBox1.Location = new System.Drawing.Point(229, 62);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(209, 228);
            this.listBox1.TabIndex = 7;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // LstBox2
            // 
            this.LstBox2.BackColor = System.Drawing.SystemColors.Info;
            this.LstBox2.FormattingEnabled = true;
            this.LstBox2.ItemHeight = 16;
            this.LstBox2.Location = new System.Drawing.Point(449, 62);
            this.LstBox2.Name = "LstBox2";
            this.LstBox2.Size = new System.Drawing.Size(567, 228);
            this.LstBox2.TabIndex = 8;
            this.LstBox2.SelectedIndexChanged += new System.EventHandler(this.LstBox2_SelectedIndexChanged);
            // 
            // rdbpee
            // 
            this.rdbpee.AutoSize = true;
            this.rdbpee.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbpee.Location = new System.Drawing.Point(6, 30);
            this.rdbpee.Name = "rdbpee";
            this.rdbpee.Size = new System.Drawing.Size(43, 20);
            this.rdbpee.TabIndex = 9;
            this.rdbpee.TabStop = true;
            this.rdbpee.Text = "Pé";
            this.rdbpee.UseVisualStyleBackColor = true;
            this.rdbpee.CheckedChanged += new System.EventHandler(this.rdbpee_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1028, 501);
            this.Controls.Add(this.LstBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupbox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnexcluir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupbox2.ResumeLayout(false);
            this.groupbox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.RadioButton rdbmaoo;
        private System.Windows.Forms.RadioButton rdbpeemaoo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupbox2;
        private System.Windows.Forms.CheckBox chkbcafe;
        private System.Windows.Forms.CheckBox chkbchoco;
        private System.Windows.Forms.CheckBox chkbsuco;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox LstBox2;
        private System.Windows.Forms.RadioButton rdbpee;
    }
}

