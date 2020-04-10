using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;

namespace PruebaHash
{
    public partial class Form1 : Form
    {
        Conexion miConexion = new Conexion();

        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(textBoxPass.Text);
            //MessageBox.Show(BCrypt. textBoxPass.Text);

            //string myPassword = "1234";
            //string mySalt = BCrypt.Net.BCrypt.GenerateSalt();
            //Console.WriteLine(mySalt);
            //string myHash = BCrypt.Net.BCrypt.HashPassword(myPassword, mySalt);
            //Console.WriteLine(myHash);
            //bool doesPasswordMatch = BCrypt.Net.BCrypt.Verify(myPassword, myHash);
            //Console.WriteLine(doesPasswordMatch);

           String resultado =  miConexion.insertaUsuario(textBoxDNI.Text, textBoxUsuario.Text, textBoxPass.Text);

            MessageBox.Show(resultado);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String resultado = miConexion.loginVeterinario(textBoxDNI.Text, textBoxPass.Text);

            MessageBox.Show(resultado);
        }
    }
}
