using System.Collections.Generic;
using System.IO.Ports;
using System.Text;

namespace ProjetoArgos.Model
{
    public enum TipoDispositivo
    {
        Porta,
        Lampada,
        Janela
    }

    public enum Estado
    {
        Desligado = 0,
        Ligado = 1
    }

    public class Dispositivo
    {
        public string Nome { get; private set; }
        public Estado Estado { get; private set; }
        public TipoDispositivo? Tipo { get; private set; }

        public Dispositivo(string nome)
        {
            Nome = nome;
            Estado = Model.Estado.Desligado;
            Tipo = null;
        }
    }

    public class ControleEstado
    {
        private SerialPort _porta;

        public ControleEstado(SerialPort porta)
        {
            _porta = porta;
        }

        public bool AtualizarStatus(Dispositivo dispositivo, Estado estado)
        {
            if (!_porta.IsOpen)
                _porta.Open();

            _porta.Write("a" + dispositivo.Nome + (int)estado);

            var resultado = LerDadosDaPorta();

            if (_porta.IsOpen)
                _porta.Close();

            return VerificaEstado(dispositivo) == estado;
        }

        public Estado VerificaEstado(Dispositivo dispositivo)
        {
            if (!_porta.IsOpen)
                _porta.Open();

            _porta.Write("l" + dispositivo.Nome);

            var resultado = LerDadosDaPorta();

            if (_porta.IsOpen)
                _porta.Close();

            return resultado.Equals("0") ? Estado.Desligado : Estado.Ligado;
        }

        private string LerDadosDaPorta()
        {
            var data = new byte[_porta.BytesToRead];
            _porta.Read(data, 0, data.Length);

            var resultado = Encoding.UTF8.GetString(data);
            return resultado;
        }
    }
}