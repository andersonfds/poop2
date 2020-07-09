using System.Windows.Forms;

namespace POOP2.Classes.Ex06
{
    public class Player
    {
        private string _name;
        private int _age;
        private string _position;
        private int _goals;

        public string Name { get => _name; set => _name = value; }
        public int Age { get => _age; set => _age = value; }
        public string Position { get => _position; set => _position = value; }
        public int Goals { get => _goals; set => _goals = value; }


        public void Print()
        {
            MessageBox.Show($"Nome do jogador: {_name}\n" +
                $"Idade: {_age}\n" +
                $"Posição: {_position}\n" +
                $"Gols: {_goals}"
            );
        }

        public void Score()
        {
            this.Goals++;
            GoalSound();
            MessageBox.Show("Gooooooool!", "GOL");
        }

        private void GoalSound()
        {
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = "fox_gol.mp3";
            wplayer.controls.play();
        }
    }
}
