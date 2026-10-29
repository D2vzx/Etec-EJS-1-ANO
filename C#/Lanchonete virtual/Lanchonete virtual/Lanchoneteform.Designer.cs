namespace Lanchonete_virtual
{
    partial class Lanchoneteform
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
            this.gpbox1 = new System.Windows.Forms.GroupBox();
            this.radioxalli = new System.Windows.Forms.RadioButton();
            this.radioxbacon = new System.Windows.Forms.RadioButton();
            this.radioxsalada = new System.Windows.Forms.RadioButton();
            this.gpbox2 = new System.Windows.Forms.GroupBox();
            this.checkmilk = new System.Windows.Forms.CheckBox();
            this.checkbatata = new System.Windows.Forms.CheckBox();
            this.checksprite = new System.Windows.Forms.CheckBox();
            this.listbox = new System.Windows.Forms.ListBox();
            this.cmbox = new System.Windows.Forms.ComboBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picbox5 = new System.Windows.Forms.PictureBox();
            this.picbox3 = new System.Windows.Forms.PictureBox();
            this.picbox6 = new System.Windows.Forms.PictureBox();
            this.picbox4 = new System.Windows.Forms.PictureBox();
            this.picbox2 = new System.Windows.Forms.PictureBox();
            this.picbox1 = new System.Windows.Forms.PictureBox();
            this.btnSAIR = new System.Windows.Forms.Button();
            this.gpbox1.SuspendLayout();
            this.gpbox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbox1
            // 
            this.gpbox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gpbox1.Controls.Add(this.radioxalli);
            this.gpbox1.Controls.Add(this.radioxbacon);
            this.gpbox1.Controls.Add(this.radioxsalada);
            this.gpbox1.Location = new System.Drawing.Point(16, 69);
            this.gpbox1.Margin = new System.Windows.Forms.Padding(4);
            this.gpbox1.Name = "gpbox1";
            this.gpbox1.Padding = new System.Windows.Forms.Padding(4);
            this.gpbox1.Size = new System.Drawing.Size(267, 123);
            this.gpbox1.TabIndex = 0;
            this.gpbox1.TabStop = false;
            this.gpbox1.Text = "Lanches";
            this.gpbox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioxalli
            // 
            this.radioxalli.AutoSize = true;
            this.radioxalli.Location = new System.Drawing.Point(9, 84);
            this.radioxalli.Margin = new System.Windows.Forms.Padding(4);
            this.radioxalli.Name = "radioxalli";
            this.radioxalli.Size = new System.Drawing.Size(122, 20);
            this.radioxalli.TabIndex = 2;
            this.radioxalli.Text = "X-Mohamed Alli";
            this.radioxalli.UseVisualStyleBackColor = true;
            this.radioxalli.CheckedChanged += new System.EventHandler(this.radioxalli_CheckedChanged);
            // 
            // radioxbacon
            // 
            this.radioxbacon.AutoSize = true;
            this.radioxbacon.Location = new System.Drawing.Point(9, 54);
            this.radioxbacon.Margin = new System.Windows.Forms.Padding(4);
            this.radioxbacon.Name = "radioxbacon";
            this.radioxbacon.Size = new System.Drawing.Size(78, 20);
            this.radioxbacon.TabIndex = 1;
            this.radioxbacon.Text = "X-bacon";
            this.radioxbacon.UseVisualStyleBackColor = true;
            this.radioxbacon.CheckedChanged += new System.EventHandler(this.radioxbacon_CheckedChanged);
            // 
            // radioxsalada
            // 
            this.radioxsalada.AutoSize = true;
            this.radioxsalada.Location = new System.Drawing.Point(9, 25);
            this.radioxsalada.Margin = new System.Windows.Forms.Padding(4);
            this.radioxsalada.Name = "radioxsalada";
            this.radioxsalada.Size = new System.Drawing.Size(82, 20);
            this.radioxsalada.TabIndex = 0;
            this.radioxsalada.Text = "X-salada";
            this.radioxsalada.UseVisualStyleBackColor = true;
            this.radioxsalada.CheckedChanged += new System.EventHandler(this.radioxsalada_CheckedChanged);
            // 
            // gpbox2
            // 
            this.gpbox2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gpbox2.Controls.Add(this.checkmilk);
            this.gpbox2.Controls.Add(this.checkbatata);
            this.gpbox2.Controls.Add(this.checksprite);
            this.gpbox2.Location = new System.Drawing.Point(328, 69);
            this.gpbox2.Margin = new System.Windows.Forms.Padding(4);
            this.gpbox2.Name = "gpbox2";
            this.gpbox2.Padding = new System.Windows.Forms.Padding(4);
            this.gpbox2.Size = new System.Drawing.Size(267, 123);
            this.gpbox2.TabIndex = 1;
            this.gpbox2.TabStop = false;
            this.gpbox2.Text = "Acompanhamentos";
            // 
            // checkmilk
            // 
            this.checkmilk.AutoSize = true;
            this.checkmilk.Location = new System.Drawing.Point(9, 84);
            this.checkmilk.Margin = new System.Windows.Forms.Padding(4);
            this.checkmilk.Name = "checkmilk";
            this.checkmilk.Size = new System.Drawing.Size(90, 20);
            this.checkmilk.TabIndex = 2;
            this.checkmilk.Text = "Milkshake";
            this.checkmilk.UseVisualStyleBackColor = true;
            this.checkmilk.CheckedChanged += new System.EventHandler(this.checkmilk_CheckedChanged);
            // 
            // checkbatata
            // 
            this.checkbatata.AutoSize = true;
            this.checkbatata.Location = new System.Drawing.Point(9, 54);
            this.checkbatata.Margin = new System.Windows.Forms.Padding(4);
            this.checkbatata.Name = "checkbatata";
            this.checkbatata.Size = new System.Drawing.Size(98, 20);
            this.checkbatata.TabIndex = 1;
            this.checkbatata.Text = "Batata-Frita";
            this.checkbatata.UseVisualStyleBackColor = true;
            this.checkbatata.CheckedChanged += new System.EventHandler(this.checkbatata_CheckedChanged);
            // 
            // checksprite
            // 
            this.checksprite.AutoSize = true;
            this.checksprite.Location = new System.Drawing.Point(9, 25);
            this.checksprite.Margin = new System.Windows.Forms.Padding(4);
            this.checksprite.Name = "checksprite";
            this.checksprite.Size = new System.Drawing.Size(64, 20);
            this.checksprite.TabIndex = 0;
            this.checksprite.Text = "Sprite";
            this.checksprite.UseVisualStyleBackColor = true;
            this.checksprite.CheckedChanged += new System.EventHandler(this.checksprite_CheckedChanged);
            // 
            // listbox
            // 
            this.listbox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listbox.FormattingEnabled = true;
            this.listbox.ItemHeight = 16;
            this.listbox.Items.AddRange(new object[] {
            "AÇAI",
            "CASQUINHA BAUNILHA",
            "CASQUINHA DE CHOCOLATE"});
            this.listbox.Location = new System.Drawing.Point(645, 69);
            this.listbox.Margin = new System.Windows.Forms.Padding(4);
            this.listbox.Name = "listbox";
            this.listbox.Size = new System.Drawing.Size(209, 116);
            this.listbox.TabIndex = 2;
            this.listbox.SelectedIndexChanged += new System.EventHandler(this.listbox_SelectedIndexChanged);
            // 
            // cmbox
            // 
            this.cmbox.FormattingEnabled = true;
            this.cmbox.Items.AddRange(new object[] {
            "CARTÃO",
            "PIX",
            "DINHEIRO"});
            this.cmbox.Location = new System.Drawing.Point(876, 89);
            this.cmbox.Margin = new System.Windows.Forms.Padding(4);
            this.cmbox.Name = "cmbox";
            this.cmbox.Size = new System.Drawing.Size(209, 24);
            this.cmbox.TabIndex = 9;
            this.cmbox.SelectedIndexChanged += new System.EventHandler(this.cmbox_SelectedIndexChanged);
            // 
            // lbl1
            // 
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(385, 11);
            this.lbl1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(285, 41);
            this.lbl1.TabIndex = 10;
            this.lbl1.Text = "LANCHONETE ++";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl1.Click += new System.EventHandler(this.lbl1_Click);
            // 
            // lbl2
            // 
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(109, 421);
            this.lbl2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(137, 25);
            this.lbl2.TabIndex = 11;
            this.lbl2.Text = "Pagamento";
            this.lbl2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(679, 46);
            this.lbl3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(103, 20);
            this.lbl3.TabIndex = 12;
            this.lbl3.Text = "Sobremesa";
            this.lbl3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(884, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 27);
            this.label1.TabIndex = 13;
            this.label1.Text = "Pagamento";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // picbox5
            // 
            this.picbox5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.picbox5.Location = new System.Drawing.Point(760, 272);
            this.picbox5.Margin = new System.Windows.Forms.Padding(4);
            this.picbox5.Name = "picbox5";
            this.picbox5.Size = new System.Drawing.Size(188, 95);
            this.picbox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox5.TabIndex = 8;
            this.picbox5.TabStop = false;
            // 
            // picbox3
            // 
            this.picbox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.picbox3.Location = new System.Drawing.Point(407, 272);
            this.picbox3.Margin = new System.Windows.Forms.Padding(4);
            this.picbox3.Name = "picbox3";
            this.picbox3.Size = new System.Drawing.Size(157, 86);
            this.picbox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox3.TabIndex = 7;
            this.picbox3.TabStop = false;
            // 
            // picbox6
            // 
            this.picbox6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.picbox6.Location = new System.Drawing.Point(85, 449);
            this.picbox6.Margin = new System.Windows.Forms.Padding(4);
            this.picbox6.Name = "picbox6";
            this.picbox6.Size = new System.Drawing.Size(180, 111);
            this.picbox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox6.TabIndex = 6;
            this.picbox6.TabStop = false;
            // 
            // picbox4
            // 
            this.picbox4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.picbox4.Location = new System.Drawing.Point(572, 272);
            this.picbox4.Margin = new System.Windows.Forms.Padding(4);
            this.picbox4.Name = "picbox4";
            this.picbox4.Size = new System.Drawing.Size(156, 86);
            this.picbox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox4.TabIndex = 5;
            this.picbox4.TabStop = false;
            // 
            // picbox2
            // 
            this.picbox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.picbox2.Location = new System.Drawing.Point(240, 272);
            this.picbox2.Margin = new System.Windows.Forms.Padding(4);
            this.picbox2.Name = "picbox2";
            this.picbox2.Size = new System.Drawing.Size(159, 86);
            this.picbox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox2.TabIndex = 4;
            this.picbox2.TabStop = false;
            // 
            // picbox1
            // 
            this.picbox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.picbox1.Location = new System.Drawing.Point(16, 272);
            this.picbox1.Margin = new System.Windows.Forms.Padding(4);
            this.picbox1.Name = "picbox1";
            this.picbox1.Size = new System.Drawing.Size(164, 86);
            this.picbox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox1.TabIndex = 3;
            this.picbox1.TabStop = false;
            // 
            // btnSAIR
            // 
            this.btnSAIR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSAIR.Location = new System.Drawing.Point(955, 400);
            this.btnSAIR.Name = "btnSAIR";
            this.btnSAIR.Size = new System.Drawing.Size(144, 59);
            this.btnSAIR.TabIndex = 15;
            this.btnSAIR.Text = "SAIR";
            this.btnSAIR.UseVisualStyleBackColor = true;
            this.btnSAIR.Click += new System.EventHandler(this.btnSAIR_Click);
            // 
            // Lanchoneteform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1111, 572);
            this.Controls.Add(this.btnSAIR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.cmbox);
            this.Controls.Add(this.picbox5);
            this.Controls.Add(this.picbox3);
            this.Controls.Add(this.picbox6);
            this.Controls.Add(this.picbox4);
            this.Controls.Add(this.picbox2);
            this.Controls.Add(this.picbox1);
            this.Controls.Add(this.listbox);
            this.Controls.Add(this.gpbox2);
            this.Controls.Add(this.gpbox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Lanchoneteform";
            this.Text = "Lanchonete";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpbox1.ResumeLayout(false);
            this.gpbox1.PerformLayout();
            this.gpbox2.ResumeLayout(false);
            this.gpbox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbox1;
        private System.Windows.Forms.GroupBox gpbox2;
        private System.Windows.Forms.ListBox listbox;
        private System.Windows.Forms.PictureBox picbox1;
        private System.Windows.Forms.PictureBox picbox2;
        private System.Windows.Forms.PictureBox picbox4;
        private System.Windows.Forms.PictureBox picbox6;
        private System.Windows.Forms.PictureBox picbox3;
        private System.Windows.Forms.PictureBox picbox5;
        private System.Windows.Forms.ComboBox cmbox;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.CheckBox checkmilk;
        private System.Windows.Forms.CheckBox checkbatata;
        private System.Windows.Forms.CheckBox checksprite;
        private System.Windows.Forms.RadioButton radioxalli;
        private System.Windows.Forms.RadioButton radioxbacon;
        private System.Windows.Forms.RadioButton radioxsalada;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSAIR;
    }
}

