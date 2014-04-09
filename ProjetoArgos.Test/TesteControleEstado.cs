using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO.Ports;
using ProjetoArgos.Model;
using System.Linq;

namespace ProjetoArgos.Test
{
    [TestClass]
    public class TesteControleEstado
    {
        [TestMethod]
        public void DeveEnviarComandoParaAtualizarEstado()
        {
            var porta = new SerialPort("COM3", 9600);
            var controle = new ControleEstado(porta);

            var primeiro = new Dispositivo("1");
            var resultado = controle.AtualizarStatus(primeiro, Estado.Ligado);

            Assert.IsTrue(resultado);
        }
    }
}