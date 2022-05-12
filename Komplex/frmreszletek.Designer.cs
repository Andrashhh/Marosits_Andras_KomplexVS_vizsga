namespace Komplex
{
    partial class frmreszletek
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_nev = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tB_nyertes = new System.Windows.Forms.TextBox();
            this.lB_foglalkozas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Firebrick;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(18, 162);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(539, 19);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Fő foglalkozásai:";
            // 
            // label_nev
            // 
            this.label_nev.AutoSize = true;
            this.label_nev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label_nev.Location = new System.Drawing.Point(267, 78);
            this.label_nev.Name = "label_nev";
            this.label_nev.Size = new System.Drawing.Size(45, 20);
            this.label_nev.TabIndex = 2;
            this.label_nev.Text = "NÉV";
            this.label_nev.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(14, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "A díjat nyerte:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tB_nyertes
            // 
            this.tB_nyertes.BackColor = System.Drawing.Color.IndianRed;
            this.tB_nyertes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tB_nyertes.Location = new System.Drawing.Point(140, 354);
            this.tB_nyertes.Name = "tB_nyertes";
            this.tB_nyertes.Size = new System.Drawing.Size(100, 19);
            this.tB_nyertes.TabIndex = 4;
            this.tB_nyertes.Text = "Példa, példa";
            // 
            // lB_foglalkozas
            // 
            this.lB_foglalkozas.BackColor = System.Drawing.Color.Firebrick;
            this.lB_foglalkozas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lB_foglalkozas.FormattingEnabled = true;
            this.lB_foglalkozas.ItemHeight = 20;
            this.lB_foglalkozas.Items.AddRange(new object[] {
            "példa",
            "példa"});
            this.lB_foglalkozas.Location = new System.Drawing.Point(18, 202);
            this.lB_foglalkozas.Name = "lB_foglalkozas";
            this.lB_foglalkozas.Size = new System.Drawing.Size(540, 140);
            this.lB_foglalkozas.TabIndex = 5;
            // 
            // frmreszletek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(570, 423);
            this.Controls.Add(this.lB_foglalkozas);
            this.Controls.Add(this.tB_nyertes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_nev);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmreszletek";
            this.Text = "frmreszletek";
            this.Load += new System.EventHandler(this.frmreszletek_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_nev;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tB_nyertes;
        private System.Windows.Forms.ListBox lB_foglalkozas;
    }
}