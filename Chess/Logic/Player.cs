namespace Logic
{
    public enum Player
    {
        None,
        White,
        Black
    }

    public static class PlayerExtensions
    {
        // Returns the opponent of the given player.
        public static Player Opponent(this Player player)
        {
            return player switch
            {
                Player.White => Player.Black,
                Player.Black => Player.White,
                _ => Player.None,
            };
        }
    }
}
