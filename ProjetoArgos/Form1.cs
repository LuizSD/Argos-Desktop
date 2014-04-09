using ProjetoArgos.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoArgos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Inicializa o Arduino
            var porta = new SerialPort("COM5", 9600);
            var controle = new ControleEstado(porta);

            //Verifica os Estados
            var primeiro = new Dispositivo("1");
            var estadoPrimeira = controle.VerificaEstado(primeiro);

            var segundo = new Dispositivo("2");
            var estadoSegunda = controle.VerificaEstado(segundo);

            var terceiro = new Dispositivo("3");
            var estadoTerceira = controle.VerificaEstado(terceiro);

            Lampada1.Text = estadoPrimeira.ToString();
            Lampada2.Text = estadoSegunda.ToString();
            Lampada3.Text = estadoTerceira.ToString(); 

           

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Lampada1_Click(object sender, EventArgs e)
        {
            var porta = new SerialPort("COM5", 9600);
            var controle = new ControleEstado(porta);

            var primeiro = new Dispositivo("1");
            var estadoLampada = controle.VerificaEstado(primeiro);

            if (estadoLampada.ToString() == Lampada1.Text) {
                var estadoNovo = estadoLampada.Equals(Estado.Ligado) ? Estado.Desligado : Estado.Ligado;
                var resultado = controle.AtualizarStatus(primeiro, estadoNovo);
                Lampada1.Text = estadoNovo.ToString();
            }
            else
            {
                MessageBox.Show("A Lâmpada já está no estado " + estadoLampada);
                Lampada1.Text = estadoLampada.ToString();
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Lampada2_Click(object sender, EventArgs e)
        {
            var porta = new SerialPort("COM5", 9600);
            var controle = new ControleEstado(porta);

            var segundo = new Dispositivo("2");
            var estadoLampada = controle.VerificaEstado(segundo);

            if (estadoLampada.ToString() == Lampada1.Text)
            {
                var estadoNovo = estadoLampada.Equals(Estado.Ligado) ? Estado.Desligado : Estado.Ligado;
                var resultado = controle.AtualizarStatus(segundo, estadoNovo);
                Lampada2.Text = estadoNovo.ToString();
            }
            else
            {
                MessageBox.Show("A Lâmpada já está no estado " + estadoLampada);
                Lampada2.Text = estadoLampada.ToString();
            }
        }

        private void Lampada3_Click(object sender, EventArgs e)
        {
            var porta = new SerialPort("COM5", 9600);
            var controle = new ControleEstado(porta);

            var terceiro = new Dispositivo("3");
            var estadoLampada = controle.VerificaEstado(terceiro);

            if (estadoLampada.ToString() == Lampada1.Text)
            {
                var estadoNovo = estadoLampada.Equals(Estado.Ligado) ? Estado.Desligado : Estado.Ligado;
                var resultado = controle.AtualizarStatus(terceiro, estadoNovo);
                Lampada3.Text = estadoNovo.ToString();
            }
            else
            {
                MessageBox.Show("A Lâmpada já está no estado " + estadoLampada);
                Lampada3.Text = estadoLampada.ToString();
            }
        }
    }
}
