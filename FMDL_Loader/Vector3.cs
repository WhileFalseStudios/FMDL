using System;
using System.Collections.Generic;
using System.Text;
#if FNA
using Microsoft.Xna.Framework;
#endif

namespace WhileFalse.FMDL
{
    /// <summary>
    /// FMDL Vector 3D
    /// </summary>
    public struct FVector3
    {
        public float X;
        public float Y;
        public float Z;

        /// <summary>
        /// Instantiates a new <see cref="FVector3"/> with the given component values
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        public FVector3(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public static FVector3 Zero => new FVector3(0, 0, 0);
        public static FVector3 One => new FVector3(1, 1, 1);
        public static FVector3 Forward => new FVector3(1, 0, 0);
        public static FVector3 Backward => new FVector3(-1, 0, 0);
        public static FVector3 Right => new FVector3(0, 1, 0);
        public static FVector3 Left => new FVector3(0, -1, 0);
        public static FVector3 Up => new FVector3(0, 0, 1);
        public static FVector3 Down => new FVector3(0, 0, -1);

        #region FNA Casting
#if FNA
        public static implicit operator Vector3(FVector3 vec)
        {
            return new Vector3(vec.X, vec.Y, vec.Z);
        }

        public static implicit operator FVector3(Vector3 vec)
        {
            return new FVector3(vec.X, vec.Y, vec.Z);
        }
#endif
        #endregion
    }
}
