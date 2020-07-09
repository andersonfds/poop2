using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POOP2.Classes.Ex06
{
    public class Club
    {
        private string _name;
        private string _coach;
        private int _wins;
        private int _defeats;
        private int _draws;
        private Player _player;

        public string Name { get => _name; set => _name = value; }
        public string Coach { get => _coach; set => _coach = value; }
        public int Wins { get => _wins; set => _wins = value; }
        public int Defeats { get => _defeats; set => _defeats = value; }
        public int Draws { get => _draws; set => _draws = value; }
        public Player Player { get => _player; set => _player = value; }

        public Club()
        {
            this.Player = new Player();
        }

        public void Print()
        {
            MessageBox.Show($"Nome do clube: {_name}\n" +
                $"Técnico: {_coach}\n" +
                $"Vitórias: {_wins}\n" +
                $"Derrotas: {_defeats}\n" +
                $"Empates: {_draws}"
            );
        }

        public void Win()
        {
            this.Wins++;
            MessageBox.Show("Vitória adicionada com sucesso!");
        }

        public void Lose()
        {
            this.Defeats++;
            MessageBox.Show("Derrota adicionada com sucesso!");
        }

        public void Draw()
        {
            this.Draws++;
            MessageBox.Show("Empate adicionado com sucesso!");
        }
    }
}
