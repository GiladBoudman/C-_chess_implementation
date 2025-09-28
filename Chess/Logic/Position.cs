namespace Logic
{
    public class Position
    {
        public int Row { get; }
        public int Column { get; }

        public Position(int row, int column)
        {
            Row = row;
            Column = column;
        }

        // Returns the color of the square at this position.
        public Player SquareColor()
        {
            return (Row + Column) % 2 == 0 ? Player.White : Player.Black;
        }


        // Override Equals and GetHashCode for proper comparison.
         public override bool Equals(object obj)
        {
            return obj is Position position &&
                   Row == position.Row &&
                   Column == position.Column;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Row, Column);
        }


        // Overload the == and != operators for easier comparison.
        public static bool operator ==(Position left, Position right)
        {
            return EqualityComparer<Position>.Default.Equals(left, right);
        }

        public static bool operator !=(Position left, Position right)
        {
            return !(left == right);
        }

        // Adds a direction to the current position and returns a new position.
        public static Position operator +(Position position, Direction direction)
        {
            return new Position(position.Row + direction.RowChange,
                position.Column + direction.ColumnChange);
        }
    }
}
