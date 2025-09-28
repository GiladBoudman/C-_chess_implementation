using System;
using System.Collections.Generic;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Logic;

namespace UI
{
    public static class Images
    {
        // Dictionaries to hold image sources for white and black pieces
        public static readonly Dictionary<PieceType, ImageSource> whiteSources = new()
        {
            {PieceType.Pawn, LoadImage("Assets/PawnW.png") },
            { PieceType.Rook, LoadImage("Assets/RookW.png") },
            { PieceType.Knight, LoadImage("Assets/KnightW.png") },
            { PieceType.Bishop, LoadImage("Assets/BishopW.png") },
            { PieceType.Queen, LoadImage("Assets/QueenW.png") },
            { PieceType.King, LoadImage("Assets/KingW.png") }
            };
        public static readonly Dictionary<PieceType, ImageSource> blackSources = new()
        {
            { PieceType.Pawn, LoadImage("Assets/PawnB.png") },
            { PieceType.Rook, LoadImage("Assets/RookB.png") },
            { PieceType.Knight, LoadImage("Assets/KnightB.png") },
            { PieceType.Bishop, LoadImage("Assets/BishopB.png") },
            { PieceType.Queen, LoadImage("Assets/QueenB.png") },
            { PieceType.King, LoadImage("Assets/KingB.png") }
        };

        // Helper method to load an image from a given path
        private static ImageSource LoadImage(string path)
        {
            return new BitmapImage(new Uri(path, UriKind.Relative));
        }

        // Method to get the appropriate image source based on player color and piece type
        public static ImageSource GetImage(Player Color, PieceType pieceType)
        {
            return Color == Player.White ? whiteSources[pieceType] : blackSources[pieceType];
        }

        // Overloaded method to get the image source directly from a Piece object
        public static ImageSource GetImage(Piece piece)
        {
            if (piece == null)
            {
                return null;
            }
            else
            {
                return GetImage(piece.Color, piece.Type);

            }
        }
    }
}
