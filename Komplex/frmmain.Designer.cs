namespace Komplex
{
    partial class frmmain
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
            this.dgv_szemelyek = new System.Windows.Forms.DataGridView();
            this.Év = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Személy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_szemelyek)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_szemelyek
            // 
            this.dgv_szemelyek.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_szemelyek.BackgroundColor = System.Drawing.Color.LightCoral;
            this.dgv_szemelyek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_szemelyek.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Év,
            this.Személy});
            this.dgv_szemelyek.GridColor = System.Drawing.Color.LightCoral;
            this.dgv_szemelyek.Location = new System.Drawing.Point(13, 66);
            this.dgv_szemelyek.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_szemelyek.Name = "dgv_szemelyek";
            this.dgv_szemelyek.Size = new System.Drawing.Size(656, 472);
            this.dgv_szemelyek.TabIndex = 0;
            // 
            // Év
            // 
            this.Év.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Év.FillWeight = 25F;
            this.Év.HeaderText = "Év";
            this.Év.Name = "Év";
            // 
            // Személy
            // 
            this.Személy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Személy.HeaderText = "Személy";
            this.Személy.Name = "Személy";
            // 
            // frmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(682, 552);
            this.Controls.Add(this.dgv_szemelyek);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmmain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmmain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_szemelyek)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_szemelyek;
        private System.Windows.Forms.DataGridViewTextBoxColumn Év;
        private System.Windows.Forms.DataGridViewTextBoxColumn Személy;
    }
}

