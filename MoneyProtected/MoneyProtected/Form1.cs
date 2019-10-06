using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyProtected
{
    public partial class Form1 : Form
    {
        Contabilidad total = new Contabilidad();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Declaraciones que no entiendo bien pero son nnecesarias
            Dinero d = new Dinero();
            int Billete;
            int cambio;

            // Asumo que el sensor detecta un billete de 10 sopes
            Billete = d.Identificar(10);

            // Genero un valor random para el total de caja chica hasta el momento
            Interfaz compra = new Interfaz();
            int total_general = total.TotalContabilidad;
            Total_Grande.Text = Convert.ToString(total_general);  //Muestro el valor para debuggear


            // Genero un valor random para el total que debe pagar el usuario
            Contabilidad T_U = new Contabilidad();
           int total_usuario = T_U.GenerarTotal();
            Total_Pequeno.Text = Convert.ToString(total_usuario); //Muestro el valor para debuggear

          // Asumir que billete es el valor total de plata que paga el cliente
          // En realidad se deberia usar otra varable que sume todas las entradas por si se ingresa mas de un billete
            compra.Entrada(Billete, ref total_general);

            //Calcula el cambio que se le debe dar al usuario basado en lo que tiene que pagar y la plata con la que pago
           cambio = compra.Cambio(total_usuario, Billete);
            Cambioo.Text = Convert.ToString(cambio); //Muestra el valor para debuggear

            // AQUI notifiquen cuanto es el cambio

            // Registra cuanta plata saca el cajero para dar el cambio
            compra.Salida(Billete, ref total_general);


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
