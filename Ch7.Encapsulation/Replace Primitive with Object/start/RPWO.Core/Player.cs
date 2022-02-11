namespace RPWO.Core
{
    public class Player
    {
        private string _level;
        public string Name { get; }

        public string Level
        {
            get => _level;
            set => _level = value;
        }

        public Player(string name, Guild guild)
        {
            Name = name;
            _level = guild.Level;
        }
    }
}