
namespace Logic
{
    public class Direction
    {
        // Predefined directions for convenience.
        public static readonly Direction Up = new Direction(-1, 0);
        public static readonly Direction Down = new Direction(1, 0);
        public static readonly Direction Left = new Direction(0, -1);
        public static readonly Direction Right = new Direction(0, 1);
        public static readonly Direction UpLeft = Up + Left;
        public static readonly Direction UpRight = Up + Right;
        public static readonly Direction DownLeft = Down + Left;
        public static readonly Direction DownRight = Down + Right;

        public int RowChange { get; }
        public int ColumnChange { get; }

        public Direction (int rowChange, int columnChange)
        {
            RowChange = rowChange;
            ColumnChange = columnChange;
        }

        // Adds two directions together.
        public static Direction operator +(Direction firstDirection, Direction secondDirection)
        {
            return new Direction(firstDirection.RowChange + secondDirection.RowChange,
                firstDirection.ColumnChange + secondDirection.ColumnChange);
        }

        // Multiplies the direction by a scalar value.
        public static Direction operator *(Direction direction, int multiplier)
        {
            return new Direction(direction.RowChange * multiplier,
                direction.ColumnChange * multiplier);
        }
    }
}
