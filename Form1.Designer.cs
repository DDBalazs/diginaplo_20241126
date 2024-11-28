namespace diginaplo
{
    partial class Form1
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
            this.dgnaplo = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rtbatlagalattiak = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.tbnev = new System.Windows.Forms.TextBox();
            this.tbotosok = new System.Windows.Forms.TextBox();
            this.tbnegyesek = new System.Windows.Forms.TextBox();
            this.tbharmasok = new System.Windows.Forms.TextBox();
            this.tbkettesek = new System.Windows.Forms.TextBox();
            this.tbegyesek = new System.Windows.Forms.TextBox();
            this.btmentes = new System.Windows.Forms.Button();
            this.lbatlagpontszam = new System.Windows.Forms.Label();
            this.nev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otosok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.negyesek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harmasok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kettesek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.egyesek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atlag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pontszam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.osztondij = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgnaplo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgnaplo
            // 
            this.dgnaplo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgnaplo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nev,
            this.otosok,
            this.negyesek,
            this.harmasok,
            this.kettesek,
            this.egyesek,
            this.atlag,
            this.pontszam,
            this.osztondij});
            this.dgnaplo.Location = new System.Drawing.Point(4, 68);
            this.dgnaplo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgnaplo.Name = "dgnaplo";
            this.dgnaplo.Size = new System.Drawing.Size(621, 346);
            this.dgnaplo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(628, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Név:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(628, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ötösök száma:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(628, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Négyesek száma:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(628, 163);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Hármasok száma:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(628, 191);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Kettesek száma:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(628, 222);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Egyesek száma:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.lbatlagpontszam);
            this.panel1.Controls.Add(this.rtbatlagalattiak);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lb);
            this.panel1.Location = new System.Drawing.Point(633, 245);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 169);
            this.panel1.TabIndex = 7;
            // 
            // rtbatlagalattiak
            // 
            this.rtbatlagalattiak.Location = new System.Drawing.Point(25, 48);
            this.rtbatlagalattiak.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rtbatlagalattiak.Name = "rtbatlagalattiak";
            this.rtbatlagalattiak.Size = new System.Drawing.Size(192, 106);
            this.rtbatlagalattiak.TabIndex = 2;
            this.rtbatlagalattiak.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 32);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Átlagos pontszám alatt lévők:";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(22, 9);
            this.lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(110, 13);
            this.lb.TabIndex = 0;
            this.lb.Text = "Átlagos pontszám:";
            // 
            // tbnev
            // 
            this.tbnev.Location = new System.Drawing.Point(687, 68);
            this.tbnev.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbnev.Name = "tbnev";
            this.tbnev.Size = new System.Drawing.Size(216, 20);
            this.tbnev.TabIndex = 8;
            // 
            // tbotosok
            // 
            this.tbotosok.Location = new System.Drawing.Point(736, 103);
            this.tbotosok.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbotosok.Name = "tbotosok";
            this.tbotosok.Size = new System.Drawing.Size(116, 20);
            this.tbotosok.TabIndex = 9;
            this.tbotosok.TextChanged += new System.EventHandler(this.tbotosok_TextChanged);
            // 
            // tbnegyesek
            // 
            this.tbnegyesek.Location = new System.Drawing.Point(736, 129);
            this.tbnegyesek.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbnegyesek.Name = "tbnegyesek";
            this.tbnegyesek.Size = new System.Drawing.Size(116, 20);
            this.tbnegyesek.TabIndex = 10;
            this.tbnegyesek.TextChanged += new System.EventHandler(this.tbnegyesek_TextChanged);
            // 
            // tbharmasok
            // 
            this.tbharmasok.Location = new System.Drawing.Point(736, 160);
            this.tbharmasok.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbharmasok.Name = "tbharmasok";
            this.tbharmasok.Size = new System.Drawing.Size(116, 20);
            this.tbharmasok.TabIndex = 11;
            this.tbharmasok.TextChanged += new System.EventHandler(this.tbharmasok_TextChanged);
            // 
            // tbkettesek
            // 
            this.tbkettesek.Location = new System.Drawing.Point(736, 188);
            this.tbkettesek.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbkettesek.Name = "tbkettesek";
            this.tbkettesek.Size = new System.Drawing.Size(116, 20);
            this.tbkettesek.TabIndex = 12;
            this.tbkettesek.TextChanged += new System.EventHandler(this.tbkettesek_TextChanged);
            // 
            // tbegyesek
            // 
            this.tbegyesek.Location = new System.Drawing.Point(734, 219);
            this.tbegyesek.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbegyesek.Name = "tbegyesek";
            this.tbegyesek.Size = new System.Drawing.Size(116, 20);
            this.tbegyesek.TabIndex = 13;
            this.tbegyesek.TextChanged += new System.EventHandler(this.tbegyesek_TextChanged);
            // 
            // btmentes
            // 
            this.btmentes.Location = new System.Drawing.Point(860, 106);
            this.btmentes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btmentes.Name = "btmentes";
            this.btmentes.Size = new System.Drawing.Size(88, 57);
            this.btmentes.TabIndex = 14;
            this.btmentes.Text = "mentés";
            this.btmentes.UseVisualStyleBackColor = true;
            this.btmentes.Click += new System.EventHandler(this.btmentes_Click);
            // 
            // lbatlagpontszam
            // 
            this.lbatlagpontszam.AutoSize = true;
            this.lbatlagpontszam.Location = new System.Drawing.Point(139, 9);
            this.lbatlagpontszam.Name = "lbatlagpontszam";
            this.lbatlagpontszam.Size = new System.Drawing.Size(41, 13);
            this.lbatlagpontszam.TabIndex = 3;
            this.lbatlagpontszam.Text = "label7";
            // 
            // nev
            // 
            this.nev.HeaderText = "Név";
            this.nev.Name = "nev";
            this.nev.ReadOnly = true;
            this.nev.Width = 150;
            // 
            // otosok
            // 
            this.otosok.HeaderText = "5 [db]";
            this.otosok.Name = "otosok";
            this.otosok.ReadOnly = true;
            this.otosok.Width = 50;
            // 
            // negyesek
            // 
            this.negyesek.HeaderText = "4[db]";
            this.negyesek.Name = "negyesek";
            this.negyesek.ReadOnly = true;
            this.negyesek.Width = 50;
            // 
            // harmasok
            // 
            this.harmasok.HeaderText = "3[db]";
            this.harmasok.Name = "harmasok";
            this.harmasok.ReadOnly = true;
            this.harmasok.Width = 50;
            // 
            // kettesek
            // 
            this.kettesek.HeaderText = "2[db]";
            this.kettesek.Name = "kettesek";
            this.kettesek.ReadOnly = true;
            this.kettesek.Width = 50;
            // 
            // egyesek
            // 
            this.egyesek.HeaderText = "1[db]";
            this.egyesek.Name = "egyesek";
            this.egyesek.ReadOnly = true;
            this.egyesek.Width = 50;
            // 
            // atlag
            // 
            this.atlag.HeaderText = "Átlag";
            this.atlag.Name = "atlag";
            this.atlag.ReadOnly = true;
            this.atlag.Width = 50;
            // 
            // pontszam
            // 
            this.pontszam.HeaderText = "Pontszám";
            this.pontszam.Name = "pontszam";
            this.pontszam.ReadOnly = true;
            this.pontszam.Width = 70;
            // 
            // osztondij
            // 
            this.osztondij.HeaderText = "Ösztondíj";
            this.osztondij.Name = "osztondij";
            this.osztondij.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 450);
            this.Controls.Add(this.btmentes);
            this.Controls.Add(this.tbegyesek);
            this.Controls.Add(this.tbkettesek);
            this.Controls.Add(this.tbharmasok);
            this.Controls.Add(this.tbnegyesek);
            this.Controls.Add(this.tbotosok);
            this.Controls.Add(this.tbnev);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgnaplo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgnaplo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgnaplo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox rtbatlagalattiak;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.TextBox tbnev;
        private System.Windows.Forms.TextBox tbotosok;
        private System.Windows.Forms.TextBox tbnegyesek;
        private System.Windows.Forms.TextBox tbharmasok;
        private System.Windows.Forms.TextBox tbkettesek;
        private System.Windows.Forms.TextBox tbegyesek;
        private System.Windows.Forms.Button btmentes;
        private System.Windows.Forms.Label lbatlagpontszam;
        private System.Windows.Forms.DataGridViewTextBoxColumn nev;
        private System.Windows.Forms.DataGridViewTextBoxColumn otosok;
        private System.Windows.Forms.DataGridViewTextBoxColumn negyesek;
        private System.Windows.Forms.DataGridViewTextBoxColumn harmasok;
        private System.Windows.Forms.DataGridViewTextBoxColumn kettesek;
        private System.Windows.Forms.DataGridViewTextBoxColumn egyesek;
        private System.Windows.Forms.DataGridViewTextBoxColumn atlag;
        private System.Windows.Forms.DataGridViewTextBoxColumn pontszam;
        private System.Windows.Forms.DataGridViewTextBoxColumn osztondij;
    }
}

