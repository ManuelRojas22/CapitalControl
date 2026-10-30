using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms; // Propiedades de Objetos y Formularios
using System.Drawing; // Manejo de los Colores

namespace CapitalControl //Nombre del Proyecto
{
    class Complementos
    {
        public static void PCEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) //comparamos si la tecla presionada es enter u otra
            {
                e.Handled = true; SendKeys.Send("{TAB}");//añadir la funcion de la tecla tab a la condicionada
            }
        }

        public static void RecibeFoco(object Sender, EventArgs e)
        {
            if (Sender is ComboBox) { ComboBox txt = Sender as ComboBox; txt.BackColor = Color.Gainsboro; }
            if (Sender is TextBox) { TextBox txt = Sender as TextBox; txt.BackColor = Color.Gainsboro; } 
        }

        public static void PerderFoco(object Sender, EventArgs e)
        {
            if (Sender is ComboBox) { ComboBox txt = Sender as ComboBox; txt.BackColor = Color.WhiteSmoke; txt.Text = txt.Text.Trim(); }
            if (Sender is TextBox) { TextBox txt = Sender as TextBox; txt.BackColor = Color.WhiteSmoke; txt.Text = txt.Text.Trim(); }
        }
        public static void SoloTxT(KeyPressEventArgs txtN)
        {
            if (Char.IsLetter(txtN.KeyChar)) { txtN.Handled = false; }
            else if (Char.IsSeparator(txtN.KeyChar)) { txtN.Handled = false; }
            else if (Char.IsControl(txtN.KeyChar)) { txtN.Handled = false; }
            else { txtN.Handled = true; }
        }

        public static void SoloNumE(KeyPressEventArgs txtN)
        {
            if (Char.IsDigit(txtN.KeyChar)) { txtN.Handled = false; }
            else if (Char.IsSeparator(txtN.KeyChar)) { txtN.Handled = false; }
            else if (Char.IsControl(txtN.KeyChar)) { txtN.Handled = false; }
            else { txtN.Handled = true; }
        }
        public static void SoloNumD(KeyPressEventArgs txtN)
        {
            if (!char.IsControl(txtN.KeyChar) && !char.IsDigit(txtN.KeyChar) && txtN.KeyChar != '.')
            {
                txtN.Handled = true;
            }

        }

        public static void FormatoMoneda(TextBox xTbox)
        {
            if (xTbox.Text == string.Empty)
            {
                return;
            }
            else
            {
                decimal Monto;

                Monto = Convert.ToDecimal(xTbox.Text);
                xTbox.Text = Monto.ToString("N0");
            }
        }
    }
}