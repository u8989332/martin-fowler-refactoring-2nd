namespace RPWO.Core
{
    public class Player
    {
        private Level _level;
        public string Name { get; }

        public string LevelString
        {
            get => _level.ToString();
            set => _level = new Level(value);
        }

        public Level Level => _level;

        public Player(string name, Guild guild)
        {
            Name = name;
            _level = new Level(guild.Level);
        }
    }
}