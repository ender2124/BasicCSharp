using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7._10_Steuerelement_DataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void Form1_Load(object sender, EventArgs e)
        {
            
            /* Spalten hinzufügen */
            DgvPersonen.Columns.Add("SpName", "Name");
            DgvPersonen.Columns.Add("SpVorname", "Vorname");
            DgvPersonen.Columns.Add("SpPersonalnummer", "Personalnummer");
            DgvPersonen.Columns.Add("SpGehalt", "Gehalt");
            DgvPersonen.Columns.Add("SpGeburtstag", "Geburtstag");

            /* Breite einstellen */
            foreach (DataGridViewTextBoxColumn c in DgvPersonen.Columns)
                c.Width = 100;

            /* Zeilen hinzufügen */
            DgvPersonen.Rows.Add(
            "Maier", "Hans", 6714, 3500.0, "15.03.1962");
            DgvPersonen.Rows.Add(
            "Schmitz", "Peter", 81343, 3750.0, "12.04.1958");
            DgvPersonen.Rows.Add(
            "Mertens", "Julia", 2297, 3621.5, "30.12.1959");
            DgvPersonen.Rows.Add(
           "Felipe", "Lopez", 92000346 , 4539, DateTime.Now.ToShortDateString());
        }

        private void CmdInfoSpalte_Click(object sender, EventArgs e)
        {
            /* Name und Headertext */
            LblAnzeige.Text = "Name: "
            + DgvPersonen.Columns["SpName"].Name + ", Header: "
            + DgvPersonen.Columns["SpName"].HeaderText + "\n";
            for (int i = 1; i < DgvPersonen.Columns.Count; i++)
                LblAnzeige.Text += "Name: "
                + DgvPersonen.Columns[i].Name + ", Header: "
                + DgvPersonen.Columns[i].HeaderText + "\n";
        }

        private void CmdMittelwert_Click(object sender, EventArgs e)
        {
            double summe = 0, mw;
            /* Zellen auswerten */
            LblAnzeige.Text = "";
            foreach (DataGridViewRow r in DgvPersonen.Rows)
                summe += Convert.ToDouble(r.Cells[3].Value); //Pillo el valor de la columna 3
            mw = summe / (DgvPersonen.Rows.Count - 1);
            LblAnzeige.Text = "Gehalt, Mittelwert: " + mw;
        }

        private void DgvPersonen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /* Klick auswerten */
            LblAnzeige.Text = "Row: " + e.RowIndex + "\n" +
            "Colum: " + e.ColumnIndex + "\n";
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                LblAnzeige.Text += "Inhalt: " +
                DgvPersonen.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
        }
    }
}
