using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace POOP2.Classes.Ex05
{
    public class Car
    {
        private string _model;
        private int _year;
        private double _gasAmount;
        private double _gasCapacity;
        private bool _started;

        public string Model { get => _model; set => _model = value; }
        public int Year { get => _year; set => _year = value; }
        public double GasAmount { get => _gasAmount; set => _gasAmount = value; }
        public double GasCapacity { get => _gasCapacity; set => _gasCapacity = value; }
        public bool Started { get => _started; set => _started = value; }

        public void Print()
        {
            MessageBox.Show($"Modelo do carro: {_model}\n" +
               $"Ano: {_year}\n" +
               $"Capacidade do tanque: {_gasCapacity} Litros\n" +
               $"Quantidade disponível: {_gasAmount} Litros");
        }

        public void Start()
        {
            WindowsMediaPlayer player = new WindowsMediaPlayer();
            player.URL = "engine.mp3";
            player.controls.play();

            Started = true;
            MessageBox.Show("Carro ligado! VRUMMMMM!", "VRUM");
        }

        public void FillGas()
        {
            GasAmount = GasCapacity;
            MessageBox.Show("Carro abastecido com sucesso!");
        }
    }
}
