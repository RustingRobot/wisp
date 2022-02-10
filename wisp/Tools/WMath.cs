using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace wisp.Tools
{
    public static class WMath
    {
        public static float GetDistance(Vector2 P1, Vector2 P2)
        {
            return (float)Math.Sqrt(Math.Pow(P1.X - P2.X, 2) + Math.Pow(P1.Y - P2.Y, 2));
        }

        public static bool BoxCollision(Vector2 P1, Vector2 D1, Vector2 P2, Vector2 D2) //basic AABB
        {
            return P1.X < P2.X + D2.X && P1.X + D1.X > P2.X && P1.Y < P2.Y + D2.Y && P1.Y + D1.Y > P2.Y;
        }
    }
}
