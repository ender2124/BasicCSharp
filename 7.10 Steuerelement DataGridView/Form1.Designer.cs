
namespace _7._10_Steuerelement_DataGridView
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
            this.DgvPersonen = new System.Windows.Forms.DataGridView();
            this.CmdInfoSpalte = new System.Windows.Forms.Button();
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.CmdMittelwert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPersonen)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvPersonen
            // 
            this.DgvPersonen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPersonen.Location = new System.Drawing.Point(35, 36);
            this.DgvPersonen.Name = "DgvPersonen";
            this.DgvPersonen.Size = new System.Drawing.Size(843, 277);
            this.DgvPersonen.TabIndex = 0;
            this.DgvPersonen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPersonen_CellContentClick);
            // 
            // CmdInfoSpalte
            // 
            this.CmdInfoSpalte.Location = new System.Drawing.Point(35, 322);
            this.CmdInfoSpalte.Margin = new System.Windows.Forms.Padding(6);
            this.CmdInfoSpalte.Name = "CmdInfoSpalte";
            this.CmdInfoSpalte.Size = new System.Drawing.Size(138, 42);
            this.CmdInfoSpalte.TabIndex = 22;
            this.CmdInfoSpalte.Text = "Info Spalte";
            this.CmdInfoSpalte.UseVisualStyleBackColor = true;
            this.CmdInfoSpalte.Click += new System.EventHandler(this.CmdInfoSpalte_Click);
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.Location = new System.Drawing.Point(257, 331);
            this.LblAnzeige.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(30, 13);
            this.LblAnzeige.TabIndex = 21;
            this.LblAnzeige.Text = "(leer)";
            // 
            // CmdMittelwert
            // 
            this.CmdMittelwert.Location = new System.Drawing.Point(35, 375);
            this.CmdMittelwert.Margin = new System.Windows.Forms.Padding(6);
            this.CmdMittelwert.Name = "CmdMittelwert";
            this.CmdMittelwert.Size = new System.Drawing.Size(138, 42);
            this.CmdMittelwert.TabIndex = 20;
            this.CmdMittelwert.Text = "Mittelwert";
            this.CmdMittelwert.UseVisualStyleBackColor = true;
            this.CmdMittelwert.Click += new System.EventHandler(this.CmdMittelwert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 455);
            this.Controls.Add(this.CmdInfoSpalte);
            this.Controls.Add(this.LblAnzeige);
            this.Controls.Add(this.CmdMittelwert);
            this.Controls.Add(this.DgvPersonen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvPersonen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvPersonen;
        internal System.Windows.Forms.Button CmdInfoSpalte;
        internal System.Windows.Forms.Label LblAnzeige;
        internal System.Windows.Forms.Button CmdMittelwert;
    }
}

