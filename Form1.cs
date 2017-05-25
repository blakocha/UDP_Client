using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets; 

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_wyslij_Click(object sender, EventArgs e)
        {
            string host = Adres.Text;
            int port = Convert.ToUInt16(PortNumber.Value);

            try
            {
                UdpClient klient = new UdpClient(host, port);
                Byte[] dane = Encoding.ASCII.GetBytes(Wiadomosci.Text);
                klient.Send(dane, dane.Length);
                info_o_polaczeniu.Items.Add("Wysyłanie wiadomości do hosta " + host + ": " + port);
                klient.Close();
            } 

            catch (Exception ex)
            {
                info_o_polaczeniu.Items.Add("Błąd. Nie udało się wysłać wiadomości! ");
                MessageBox.Show(ex.ToString(), "Błąd");
            }
        }
    }
}
