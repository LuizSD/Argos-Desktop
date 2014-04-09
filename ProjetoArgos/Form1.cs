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
        private ControleEstado _controle;

        public Form1()
        {
            InitializeComponent();
            //Inicializa o Arduino

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _controle = new ControleEstado(new SerialPort("COM5", 9600));

            VerificaEstados();
        }

        private void VerificaEstados()
        {
            //Verifica os Estados
            var primeiro = new Dispositivo("1");
            var estadoPrimeira = _controle.VerificaEstado(primeiro);

            var segundo = new Dispositivo("2");
            var estadoSegunda = _controle.VerificaEstado(segundo);

            var terceiro = new Dispositivo("3");
            var estadoTerceira = _controle.VerificaEstado(terceiro);

            Lampada1.Text = estadoPrimeira.ToString();
            Lampada2.Text = estadoSegunda.ToString();
            Lampada3.Text = estadoTerceira.ToString();    
        }

        private void Lampada1_Click(object sender, EventArgs e)
        {
            AlterarEstadoLampada("1", Lampada1);
            
        }        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Lampada2_Click(object sender, EventArgs e)
        {
            AlterarEstadoLampada("2", Lampada2);
        }

        private void Lampada3_Click(object sender, EventArgs e)
        {
            AlterarEstadoLampada("3", Lampada3);
        }

        private void AlterarEstadoLampada(string dispositivo, Button botao)
        {
            var primeiro = new Dispositivo(dispositivo);
            var estadoLampada = _controle.VerificaEstado(primeiro);

            if (estadoLampada.ToString() == botao.Text)
            {
                var estadoNovo = estadoLampada.Equals(Estado.Ligado) ? Estado.Desligado : Estado.Ligado;
                var resultado = _controle.AtualizarStatus(primeiro, estadoNovo);
                botao.Text = estadoNovo.ToString();
            }
            else
            {
                MessageBox.Show("A Lâmpada já está no estado: " + estadoLampada);
                botao.Text = estadoLampada.ToString();
            }
        }
    }
}
