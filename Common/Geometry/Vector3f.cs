using System;

namespace Common.Geometry
{
	/// <summary>Represents a three-dimensional vector.</summary>
	public struct Vector3f : IComparable<Vector3f>, IEquatable<Vector3f>
	{
		// --- members ---
		/// <summary>The x-coordinate.</summary>
		public float X;

		/// <summary>The y-coordinate.</summary>
		public float Y;

		/// <summary>The z-coordinate.</summary>
		public float Z;

		// --- constructors ---
		/// <summary>Creates a new three-dimensional vector.</summary>
		/// <param name="x">The x-coordinate.</param>
		/// <param name="y">The y-coordinate.</param>
		/// <param name="z">The z-coordinate.</param>
		public Vector3f(float x, float y, float z)
		{
			this.X = x;
			this.Y = y;
			this.Z = z;
		}

		/// <summary>Returns a normalized vector based on a 2D vector in the XZ plane and an additional Y-coordinate.</summary>
		/// <param name="Vector">The vector in the XZ-plane. The X and Y components in Vector represent the X- and Z-coordinates, respectively.</param>
		/// <param name="Y">The Y-coordinate.</param>
		public Vector3f(Vector2f Vector, float Y)
		{
			float t = 1.0f / (float)Math.Sqrt((Vector.X * Vector.X) + (Vector.Y * Vector.Y) + (Y * Y));
			this.X = t * Vector.X;
			this.Y = t * Y;
			this.Z = t * Vector.Y;
		}

		// --- arithmetic operators ---
		/// <summary>Adds two vectors.</summary>
		/// <param name="a">The first vector.</param>
		/// <param name="b">The second vector.</param>
		/// <returns>The sum of the two vectors.</returns>
		public static Vector3f operator +(Vector3f a, Vector3f b)
		{
			return new Vector3f(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
		}

		/// <summary>Adds a vector and a scalar.</summary>
		/// <param name="a">The vector.</param>
		/// <param name="b">The scalar.</param>
		/// <returns>The sum of the vector and the scalar.</returns>
		public static Vector3f operator +(Vector3f a, float b)
		{
			return new Vector3f(a.X + b, a.Y + b, a.Z + b);
		}

		/// <summary>Adds a scalar and a vector.</summary>
		/// <param name="a">The scalar.</param>
		/// <param name="b">The vector.</param>
		/// <returns>The sum of the scalar and the vector.</returns>
		public static Vector3f operator +(float a, Vector3f b)
		{
			return new Vector3f(a + b.X, a + b.Y, a + b.Z);
		}

		/// <summary>Subtracts two vectors.</summary>
		/// <param name="a">The first vector.</param>
		/// <param name="b">The second vector.</param>
		/// <returns>The difference of the two vectors.</returns>
		public static Vector3f operator -(Vector3f a, Vector3f b)
		{
			return new Vector3f(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
		}

		/// <summary>Subtracts a scalar from a vector.</summary>
		/// <param name="a">The vector.</param>
		/// <param name="b">The scalar.</param>
		/// <returns>The difference of the vector and the scalar.</returns>
		public static Vector3f operator -(Vector3f a, float b)
		{
			return new Vector3f(a.X - b, a.Y - b, a.Z - b);
		}

		/// <summary>Subtracts a vector from a scalar.</summary>
		/// <param name="a">The scalar.</param>
		/// <param name="b">The vector.</param>
		/// <returns>The difference of the scalar and the vector.</returns>
		public static Vector3f operator -(float a, Vector3f b)
		{
			return new Vector3f(a - b.X, a - b.Y, a - b.Z);
		}

		/// <summary>Negates a vector.</summary>
		/// <param name="vector">The vector.</param>
		/// <returns>The negation of the vector.</returns>
		public static Vector3f operator -(Vector3f vector)
		{
			return new Vector3f(-vector.X, -vector.Y, -vector.Z);
		}

		/// <summary>Multiplies two vectors.</summary>
		/// <param name="a">The first vector.</param>
		/// <param name="b">The second vector.</param>
		/// <returns>The product of the two vectors.</returns>
		public static Vector3f operator *(Vector3f a, Vector3f b)
		{
			return new Vector3f(a.X * b.X, a.Y * b.Y, a.Z * b.Z);
		}

		/// <summary>Multiplies a vector and a scalar.</summary>
		/// <param name="a">The vector.</param>
		/// <param name="b">The scalar.</param>
		/// <returns>The product of the vector and the scalar.</returns>
		public static Vector3f operator *(Vector3f a, float b)
		{
			return new Vector3f(a.X * b, a.Y * b, a.Z * b);
		}

		/// <summary>Multiplies a scalar and a vector.</summary>
		/// <param name="a">The scalar.</param>
		/// <param name="b">The vector.</param>
		/// <returns>The product of the scalar and the vector.</returns>
		public static Vector3f operator *(float a, Vector3f b)
		{
			return new Vector3f(a * b.X, a * b.Y, a * b.Z);
		}

		/// <summary>Divides two vectors.</summary>
		/// <param name="a">The first vector.</param>
		/// <param name="b">The second vector.</param>
		/// <returns>The quotient of the two vectors.</returns>
		/// <exception cref="System.DivideByZeroException">Raised when any member of the second vector is zero.</exception>
		public static Vector3f operator /(Vector3f a, Vector3f b)
		{
			if (b.X == 0.0 | b.Y == 0.0 | b.Z == 0.0)
			{
				throw new DivideByZeroException();
			}
			else
			{
				return new Vector3f(a.X / b.X, a.Y / b.Y, a.Z / b.Z);
			}
		}

		/// <summary>Divides a vector by a scalar.</summary>
		/// <param name="a">The vector.</param>
		/// <param name="b">The scalar.</param>
		/// <returns>The quotient of the vector and the scalar.</returns>
		/// <exception cref="System.DivideByZeroException">Raised when the scalar is zero.</exception>
		public static Vector3f operator /(Vector3f a, float b)
		{
			if (b == 0.0)
			{
				throw new DivideByZeroException();
			}
			else
			{
				float factor = 1.0f / b;
				return new Vector3f(a.X * factor, a.Y * factor, a.Z * factor);
			}
		}

		/// <summary>Divides a scalar by a vector.</summary>
		/// <param name="a">The scalar.</param>
		/// <param name="b">The vector.</param>
		/// <returns>The quotient of the scalar and the vector.</returns>
		/// <exception cref="DivideByZeroException">Raised when any member of the vector is zero.</exception>
		public static Vector3f operator /(float a, Vector3f b)
		{
			if (b.X == 0.0 | b.Y == 0.0 | b.Z == 0.0)
			{
				throw new DivideByZeroException();
			}
			else
			{
				return new Vector3f(a / b.X, a / b.Y, a / b.Z);
			}
		}

		// --- comparisons ---
		/// <summary>Checks whether the two specified vectors are equal.</summary>
		/// <param name="a">The first vector.</param>
		/// <param name="b">The second vector.</param>
		/// <returns>Whether the two vectors are equal.</returns>
		public static bool operator ==(Vector3f a, Vector3f b)
		{
			if (a.X != b.X) return false;
			if (a.Y != b.Y) return false;
			if (a.Z != b.Z) return false;
			return true;
		}

		/// <summary>Checks whether the two specified vectors are unequal.</summary>
		/// <param name="a">The first vector.</param>
		/// <param name="b">The second vector.</param>
		/// <returns>Whether the two vectors are unequal.</returns>
		public static bool operator !=(Vector3f a, Vector3f b)
		{
			if (a.X != b.X) return true;
			if (a.Y != b.Y) return true;
			if (a.Z != b.Z) return true;
			return false;
		}

		public static implicit operator Vector3d(Vector3f vector)
		{
			return new Vector3d(vector.X, vector.Y, vector.Z);
		}

		public static explicit operator Vector3f(Vector3d vector)
		{
			return new Vector3f((float)vector.X, (float)vector.Y, (float)vector.Z);
		}

		// --- instance functions ---
		public bool IsZero()
		{
			return this.X == 0.0 & this.Y == 0.0 & this.Z == 0.0;
		}

		/// <summary>Normalizes the vector.</summary>
		/// <exception cref="System.DivideByZeroException">Raised when the vector is a null vector.</exception>
		public void Normalize()
		{
			float norm = this.X * this.X + this.Y * this.Y + this.Z * this.Z;
			if (norm == 0.0)
			{
				throw new DivideByZeroException();
			}
			else
			{
				float factor = 1.0f / (float)System.Math.Sqrt(norm);
				this.X *= factor;
				this.Y *= factor;
				this.Z *= factor;
			}
		}

		/// <summary>Translates the vector by a specified offset.</summary>
		/// <param name="offset">The offset.</param>
		public void Translate(Vector3f offset)
		{
			this.X += offset.X;
			this.Y += offset.Y;
			this.Z += offset.Z;
		}

		/// <summary>Scales the vector by a specified factor.</summary>
		/// <param name="factor">The factor.</param>
		public void Scale(Vector3f factor)
		{
			this.X *= factor.X;
			this.Y *= factor.Y;
			this.Z *= factor.Z;
		}

		/// <summary>Rotates the vector on the plane perpendicular to a specified direction by a specified angle.</summary>
		/// <param name="direction">The direction perpendicular to the plane on which to rotate.</param>
		/// <param name="cosineOfAngle">The cosine of the angle.</param>
		/// <param name="sineOfAngle">The sine of the angle.</param>
		public void Rotate(Vector3f direction, float cosineOfAngle, float sineOfAngle)
		{
			float cosineComplement = 1.0f - cosineOfAngle;
			float x = (cosineOfAngle + cosineComplement * direction.X * direction.X) * this.X + (cosineComplement * direction.X * direction.Y - sineOfAngle * direction.Z) * this.Y + (cosineComplement * direction.X * direction.Z + sineOfAngle * direction.Y) * this.Z;
			float y = (cosineOfAngle + cosineComplement * direction.Y * direction.Y) * this.Y + (cosineComplement * direction.X * direction.Y + sineOfAngle * direction.Z) * this.X + (cosineComplement * direction.Y * direction.Z - sineOfAngle * direction.X) * this.Z;
			float z = (cosineOfAngle + cosineComplement * direction.Z * direction.Z) * this.Z + (cosineComplement * direction.X * direction.Z - sineOfAngle * direction.Y) * this.X + (cosineComplement * direction.Y * direction.Z + sineOfAngle * direction.X) * this.Y;
			this = new Vector3f(x, y, z);
		}

		public static Vector3f RotateXY(Vector3f vector, Vector2f angle)
		{
			float x = angle.X * vector.X - angle.Y * vector.Y;
			float y = angle.Y * vector.X + angle.X * vector.Y;
			float z = vector.Z;
			return new Vector3f(x, y, z);
		}

		public static Vector3f RotateXZ(Vector3f vector, Vector2f angle)
		{
			float x = angle.X * vector.X + angle.Y * vector.Z;
			float y = vector.Y;
			float z = angle.X * vector.Z - angle.Y * vector.X;
			return new Vector3f(x, y, z);
		}

		public static Vector3f RotateYZ(Vector3f vector, Vector2f angle)
		{
			float x = vector.X;
			float y = angle.X * vector.Y - angle.Y * vector.Z;
			float z = angle.Y * vector.Y + angle.X * vector.Z;
			return new Vector3f(x, y, z);
		}

		public static Vector3f Rotate(Vector3f vector, Vector3f direction, Vector2f angle)
		{
			float versin = 1.0f - angle.X;
			float x =
				(angle.X + versin * direction.X * direction.X) * vector.X +
				(versin * direction.X * direction.Y - angle.Y * direction.Z) * vector.Y +
				(versin * direction.X * direction.Z + angle.Y * direction.Y) * vector.Z;
			float y =
				(versin * direction.X * direction.Y + angle.Y * direction.Z) * vector.X +
				(angle.X + versin * direction.Y * direction.Y) * vector.Y +
				(versin * direction.Y * direction.Z - angle.Y * direction.X) * vector.Z;
			float z =
				(versin * direction.X * direction.Z - angle.Y * direction.Y) * vector.X +
				(versin * direction.Y * direction.Z + angle.Y * direction.X) * vector.Y +
				(angle.X + versin * direction.Z * direction.Z) * vector.Z;
			return new Vector3f(x, y, z);
		}

		/// <summary>Checks whether the vector is a null vector.</summary>
		/// <returns>A boolean indicating whether the vector is a null vector.</returns>
		public bool IsNullVector()
		{
			return this.X == 0.0 & this.Y == 0.0 & this.Z == 0.0;
		}

		/// <summary>Checks whether the vector is considered a null vector.</summary>
		/// <param name="tolerance">The highest absolute value that each component of the vector may have before the vector is not considered a null vector.</param>
		/// <returns>A boolean indicating whether the vector is considered a null vector.</returns>
		public bool IsNullVector(float tolerance)
		{
			if (this.X < -tolerance) return false;
			if (this.X > tolerance) return false;
			if (this.Y < -tolerance) return false;
			if (this.Y > tolerance) return false;
			if (this.Z < -tolerance) return false;
			if (this.Z > tolerance) return false;
			return true;
		}

		/// <summary>Gets the euclidean norm.</summary>
		/// <returns>The euclidean norm.</returns>
		public float Norm()
		{
			return (float)System.Math.Sqrt((this.X * this.X) + (this.Y * this.Y) + (this.Z * this.Z));
		}

		/// <summary>Gets the square of the euclidean norm.</summary>
		/// <returns>The square of the euclidean norm.</returns>
		public float NormSquared()
		{
			return this.X * this.X + this.Y * this.Y + this.Z * this.Z;
		}

		// --- static functions ---
		public static Vector3f Sign(Vector3f vector)
		{
			float t = vector.X * vector.X + vector.Y * vector.Y + vector.Z * vector.Z;
			if (t != 0.0)
			{
				t = 1.0f / (float)Math.Sqrt(t);
				return new Vector3f(vector.X * t, vector.Y * t, vector.Z * t);
			}
			else
			{
				return Vector3f.Null;
			}
		}

		/// <summary>Gives the dot product of two vectors.</summary>
		/// <param name="a">The first vector.</param>
		/// <param name="b">The second vector.</param>
		/// <returns>The dot product of the two vectors.</returns>
		public static float Dot(Vector3f a, Vector3f b)
		{
			return a.X * b.X + a.Y * b.Y + a.Z * b.Z;
		}

		/// <summary>Gives the cross product of two vectors.</summary>
		/// <param name="a">The first vector.</param>
		/// <param name="b">The second vector.</param>
		/// <returns>The cross product of the two vectors.</returns>
		public static Vector3f Cross(Vector3f a, Vector3f b)
		{
			return new Vector3f(a.Y * b.Z - a.Z * b.Y, a.Z * b.X - a.X * b.Z, a.X * b.Y - a.Y * b.X);
		}

		/// <summary>Normalizes a vector.</summary>
		/// <param name="vector">The vector.</param>
		/// <returns>The normalized vector.</returns>
		public static Vector3f Normalize(Vector3f vector)
		{
			return Vector3f.Sign(vector);
		}

		/// <summary>Translates a vector by a specified offset.</summary>
		/// <param name="vector">The vector.</param>
		/// <param name="offset">The offset.</param>
		/// <returns>The translated vector.</returns>
		public static Vector3f Translate(Vector3f vector, Vector3f offset)
		{
			float x = vector.X + offset.X;
			float y = vector.Y + offset.Y;
			float z = vector.Z + offset.Z;
			return new Vector3f(x, y, z);
		}

		/// <summary>Scales a vector by a specified factor.</summary>
		/// <param name="vector">The vector.</param>
		/// <param name="factor">The factor.</param>
		/// <returns>The scaled vector.</returns>
		public static Vector3f Scale(Vector3f vector, Vector3f factor)
		{
			float x = vector.X * factor.X;
			float y = vector.Y * factor.Y;
			float z = vector.Z * factor.Z;
			return new Vector3f(x, y, z);
		}

		/// <summary>Rotates a vector on the plane perpendicular to a specified direction by a specified angle.</summary>
		/// <param name="vector">The vector.</param>
		/// <param name="direction">The direction perpendicular to the plane on which to rotate.</param>
		/// <param name="cosineOfAngle">The cosine of the angle.</param>
		/// <param name="sineOfAngle">The sine of the angle.</param>
		/// <returns>The rotated vector.</returns>
		public static Vector3f Rotate(Vector3f vector, Vector3f direction, float cosineOfAngle, float sineOfAngle)
		{
			float cosineComplement = 1.0f - cosineOfAngle;
			float x = (cosineOfAngle + cosineComplement * direction.X * direction.X) * vector.X + (cosineComplement * direction.X * direction.Y - sineOfAngle * direction.Z) * vector.Y + (cosineComplement * direction.X * direction.Z + sineOfAngle * direction.Y) * vector.Z;
			float y = (cosineOfAngle + cosineComplement * direction.Y * direction.Y) * vector.Y + (cosineComplement * direction.X * direction.Y + sineOfAngle * direction.Z) * vector.X + (cosineComplement * direction.Y * direction.Z - sineOfAngle * direction.X) * vector.Z;
			float z = (cosineOfAngle + cosineComplement * direction.Z * direction.Z) * vector.Z + (cosineComplement * direction.X * direction.Z - sineOfAngle * direction.Y) * vector.X + (cosineComplement * direction.Y * direction.Z + sineOfAngle * direction.X) * vector.Y;
			return new Vector3f(x, y, z);
		}

		/// <summary>Creates a unit vector perpendicular to the plane described by three spatial coordinates, suitable for being a surface normal.</summary>
		/// <param name="a">The first spatial coordinate.</param>
		/// <param name="b">The second spatial coordinate.</param>
		/// <param name="c">The third spatial coordinate.</param>
		/// <param name="normal">On success, receives the vector perpendicular to the described plane. On failure, receives Vector3f.Up.</param>
		/// <returns>The success of the operation. This operation fails if the specified three vectors are colinear.</returns>
		public static bool CreateNormal(Vector3f a, Vector3f b, Vector3f c, out Vector3f normal)
		{
			normal = Vector3f.Cross(b - a, c - a);
			float norm = normal.X * normal.X + normal.Y * normal.Y + normal.Z * normal.Z;
			if (norm != 0.0)
			{
				normal *= 1.0f / (float)System.Math.Sqrt(norm);
				return true;
			}
			else
			{
				normal = Vector3f.Up;
				return false;
			}
		}

		/// <summary>Checks whether three spatial coordinates are colinear.</summary>
		/// <param name="a">The first spatial coordinate.</param>
		/// <param name="b">The second spatial coordinate.</param>
		/// <param name="c">The third spatial coordinate.</param>
		/// <returns>A boolean indicating whether the three spatial coordinates are colinear.</returns>
		public static bool AreColinear(Vector3f a, Vector3f b, Vector3f c)
		{
			Vector3f normal = Vector3f.Cross(b - a, c - a);
			return IsNullVector(normal);
		}

		/// <summary>Checks whether a vector is a null vector.</summary>
		/// <returns>A boolean indicating whether the vector is a null vector.</returns>
		public static bool IsNullVector(Vector3f vector)
		{
			return vector.X == 0.0 & vector.Y == 0.0 & vector.Z == 0.0;
		}

		/// <summary>Gets the euclidean norm of the specified vector.</summary>
		/// <param name="vector">The vector.</param>
		/// <returns>The euclidean norm.</returns>
		public static float Norm(Vector3f vector)
		{
			return (float)System.Math.Sqrt((vector.X * vector.X) + (vector.Y * vector.Y) + (vector.Z * vector.Z));
		}

		/// <summary>Gets the square of the euclidean norm of the specified vector.</summary>
		/// <param name="vector">The vector.</param>
		/// <returns>The square of the euclidean norm.</returns>
		public static float NormSquared(Vector3f vector)
		{
			return vector.X * vector.X + vector.Y * vector.Y + vector.Z * vector.Z;
		}

		// --- read-only fields ---
		/// <summary>Represents a null vector.</summary>
		public static readonly Vector3f Null = new Vector3f(0.0f, 0.0f, 0.0f);

		/// <summary>Represents a vector pointing left.</summary>
		public static readonly Vector3f Left = new Vector3f(-1.0f, 0.0f, 0.0f);

		/// <summary>Represents a vector pointing right.</summary>
		public static readonly Vector3f Right = new Vector3f(1.0f, 0.0f, 0.0f);

		/// <summary>Represents a vector pointing up.</summary>
		public static readonly Vector3f Up = new Vector3f(0.0f, -1.0f, 0.0f);

		/// <summary>Represents a vector pointing down.</summary>
		public static readonly Vector3f Down = new Vector3f(0.0f, 1.0f, 0.0f);

		/// <summary>Represents a vector pointing up.</summary>
		public static readonly Vector3f Backward = new Vector3f(0.0f, 0.0f, -1.0f);

		/// <summary>Represents a vector pointing down.</summary>
		public static readonly Vector3f Forward = new Vector3f(0.0f, 0.0f, 1.0f);

		// --- overrides and interface implementations ---
		public int CompareTo(Vector3f other)
		{
			if (this.X < other.X) return -1;
			if (this.X > other.X) return 1;
			if (this.Y < other.Y) return -1;
			if (this.Y > other.Y) return 1;
			if (this.Z < other.Z) return -1;
			if (this.Z > other.Z) return 1;
			return 0;
		}

		public bool Equals(Vector3f other)
		{
			if (this.X != other.X) return false;
			if (this.Y != other.Y) return false;
			if (this.Z != other.Z) return false;
			return true;
		}

		public override bool Equals(object obj)
		{
			if (!(obj is Vector3f)) return false;
			Vector3f other = (Vector3f)obj;
			if (this.X != other.X) return false;
			if (this.Y != other.Y) return false;
			if (this.Z != other.Z) return false;
			return true;
		}

		public override int GetHashCode()
		{
			int hashCode = 0;
			unchecked
			{
				hashCode += 1000000007 * X.GetHashCode();
				hashCode += 1000000009 * Y.GetHashCode();
				hashCode += 1000000021 * Z.GetHashCode();
			}
			return hashCode;
		}

		public override string ToString()
		{
			return '{' + this.X.ToString() + ',' + this.Y.ToString() + ',' + this.Z.ToString() + '}';
		}
	}
}