using MoneyProtected;
using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace SafetyTech
{
    public partial class Form2 : Form
    {
        string dato;
        string puertoseleccionado;
        Contabilidad total = new Contabilidad();
        public Form2()
        {
            InitializeComponent();
            string[] puertos = SerialPort.GetPortNames();
            foreach (string mostrar in puertos) { comboBox1.Items.Add(mostrar); }
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            serialPort1.Dispose();
            Close();

        }

        

        private void SerialPort1_DataReceived_1(object sender, SerialDataReceivedEventArgs e)
        {
            dato = serialPort1.ReadLine();
            label7.Text = dato.ToString();
        }

        private void ComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            serialPort1.Close();
            serialPort1.Dispose();
            puertoseleccionado = comboBox1.Text;
            serialPort1.PortName = puertoseleccionado;
            serialPort1.Open();
            CheckForIllegalCrossThreadCalls = false;
            if (serialPort1.IsOpen == true) { label2.Text = "Puerto Encontrado"; }
            else return;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Random rdn = new Random();
            int a = rdn.Next(0, 1000);
            a = a * 20;
            label9.Text = a.ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Declaraciones que no entiendo bien pero son nnecesarias
            Dinero d = new Dinero();
            int Billete;
            int cambio;
            

            // Asumo que el sensor detecta un billete de 10 sopes
            Billete = d.Identificar(Convert.ToInt32(dato));

            // Genero un valor random para el total de caja chica hasta el momento
            Interfaz compra = new Interfaz();
            int total_general = total.TotalContabilidad;
            label4.Text = Convert.ToString(total_general);  //Muestro el valor para debuggear


            // Genero un valor random para el total que debe pagar el usuario
            Contabilidad T_U = new Contabilidad();
            int total_usuario = T_U.GenerarTotal();
            label5.Text = Convert.ToString(total_usuario); //Muestro el valor para debuggear

            // Asumir que billete es el valor total de plata que paga el cliente
            // En realidad se deberia usar otra varable que sume todas las entradas por si se ingresa mas de un billete
           // compra.Entrada(Billete, ref total_general);

            //Calcula el cambio que se le debe dar al usuario basado en lo que tiene que pagar y la plata con la que pago
            cambio = compra.Cambio(total_usuario, Billete);
            if (cambio < 0) { MessageBox.Show("El cambio no es el correcto", "Error Cambio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else { label6.Text = Convert.ToString(cambio); } //Muestra el valor para debuggear

            // AQUI notifiquen cuanto es el cambio

            // Registra cuanta plata saca el cajero para dar el cambio
            compra.Salida(Billete, ref total_general);
            if (label9.Text == dato) { MessageBox.Show("La caja cuadra", "Arqueo Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else { MessageBox.Show("La caja NO cuadra", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

    }
}