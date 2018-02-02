using System;

namespace SAM.HPCncForm.DataProcessing
{
    public class AScanTrack
    {
        public const int MAX = 2500;
        public readonly int Left;
        public readonly int Right;
        public AScanTrack()
        {
            Left = 500;
            Right = 2000;
            Direction = AScanDirection.LeftToRight;
            count = Left-1;
        }

        private int count;
        public AScanDirection Direction { get; private set; }
    
        public int Next()
        {
            if(Direction == AScanDirection.LeftToRight)
            {
                count++;
                if(count >= 1500)
                {
                    Direction = AScanDirection.RightToLeft;
                    count = Right + 1;
                    return -1;
                }
            }
            else
            {
                count--;
                if (count <= 1000)
                {
                    Direction = AScanDirection.LeftToRight;
                    count = Left - 1;
                    return -1;
                }
            }
            return count;
        }
    }

    public enum AScanDirection
    {
        LeftToRight,
        RightToLeft
    }
}