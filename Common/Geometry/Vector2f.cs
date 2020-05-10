﻿using System;

namespace Common.Geometry
{
	/// <summary>Represents a two-dimensional vector.</summary>
	public struct Vector2f : IComparable<Vector2f>, IEquatable<Vector2f>
	{
		// --- members ---
		/// <summary>The x-coordinate.</summary>
		public float X;

		/// <summary>The y-coordinate.</summary>
		public float Y;

		// --- constructors ---
		/// <summary>Creates a new two-dimensional vector.</summary>
		/// <param name="angle">The angle of the vector.</param>
		public Vector2f(float angle)
		{
			this.X = (float)Math.Cos(angle);
			this.Y = (float)Math.Sin(angle);
		}

		/// <summary>Creates a new two-dimensional vector.</summary>
		/// <param name="x">The x-coordinate.</param>
		/// <param name="y">The y-coordinate.</param>
		public Vector2f(float x, float y)
		{
			this.X = x;
			this.Y = y;
		}

		// --- arithmetic operators ---
		/// <summary>Adds two vectors.</summary>
		/// <param name="a">The first vector.</param>
		/// <param name="b">The second vector.</param>
		/// <returns>The sum of the two vectors.</returns>
		public static Vector2f operator +(Vector2f a, Vector2f b)
		{
			return new Vector2f(a.X + b.X, a.Y + b.Y);
		}

		/// <summary>Adds a vector and a scalar.</summary>
		/// <param name="a">The vector.</param>
		/// <param name="b">The scalar.</param>
		/// <returns>The sum of the vector and the scalar.</returns>
		public static Vector2f operator +(Vector2f a, float b)
		{
			return new Vector2f(a.X + b, a.Y + b);
		}

		/// <summary>Adds a scalar and a vector.</summary>
		/// <param name="a">The scalar.</param>
		/// <param name="b">The vector.</param>
		/// <returns>The sum of the scalar and the vector.</returns>
		public static Vector2f operator +(float a, Vector2f b)
		{
			return new Vector2f(a + b.X, a + b.Y);
		}

		/// <summary>Subtracts two vectors.</summary>
		/// <param name="a">The first vector.</param>
		/// <param name="b">The second vector.</param>
		/// <returns>The difference of the two vectors.</returns>
		public static Vector2f operator -(Vector2f a, Vector2f b)
		{
			return new Vector2f(a.X - b.X, a.Y - b.Y);
		}

		/// <summary>Subtracts a scalar from a vector.</summary>
		/// <param name="a">The vector.</param>
		/// <param name="b">The scalar.</param>
		/// <returns>The difference of the vector and the scalar.</returns>
		public static Vector2f operator -(Vector2f a, float b)
		{
			return new Vector2f(a.X - b, a.Y - b);
		}

		/// <summary>Subtracts a vector from a scalar.</summary>
		/// <param name="a">The scalar.</param>
		/// <param name="b">The vector.</param>
		/// <returns>The difference of the scalar and the vector.</returns>
		public static Vector2f operator -(float a, Vector2f b)
		{
			return new Vector2f(a - b.X, a - b.Y);
		}

		/// <summary>Negates a vector.</summary>
		/// <param name="vector">The vector.</param>
		/// <returns>The negation of the vector.</returns>
		public static Vector2f operator -(Vector2f vector)
		{
			return new Vector2f(-vector.X, -vector.Y);
		}

		/// <summary>Multiplies two vectors.</summary>
		/// <param name="a">The first vector.</param>
		/// <param name="b">The second vector.</param>
		/// <returns>The product of the two vectors.</returns>
		public static Vector2f operator *(Vector2f a, Vector2f b)
		{
			return new Vector2f(a.X * b.X, a.Y * b.Y);
		}
		/// <summary>Multiplies a vector and a scalar.</summary>
		/// <param name="a">The vector.</param>
		/// <param name="b">The scalar.</param>
		/// <returns>The product of the vector and the scalar.</returns>
		public static Vector2f operator *(Vector2f a, float b)
		{
			return new Vector2f(a.X * b, a.Y * b);
		}

		/// <summary>Multiplies a scalar and a vector.</summary>
		/// <param name="a">The scalar.</param>
		/// <param name="b">The vector.</param>
		/// <returns>The product of the scalar and the vector.</returns>
		public static Vector2f operator *(float a, Vector2f b)
		{
			return new Vector2f(a * b.X, a * b.Y);
		}

		/// <summary>Divides two vectors.</summary>
		/// <param name="a">The first vector.</param>
		/// <param name="b">The second vector.</param>
		/// <returns>The quotient of the two vectors.</returns>
		/// <exception cref="System.DivideByZeroException">Raised when any member of the second vector is zero.</exception>
		public static Vector2f operator /(Vector2f a, Vector2f b)
		{
			if (b.X == 0.0 | b.Y == 0.0)
			{
				throw new DivideByZeroException();
			}
			else
			{
				return new Vector2f(a.X / b.X, a.Y / b.Y);
			}
		}

		/// <summary>Divides a vector by a scalar.</summary>
		/// <param name="a">The vector.</param>
		/// <param name="b">The scalar.</param>
		/// <returns>The quotient of the vector and the scalar.</returns>
		/// <exception cref="System.DivideByZeroException">Raised when the scalar is zero.</exception>
		public static Vector2f operator /(Vector2f a, float b)
		{
			if (b == 0.0)
			{
				throw new DivideByZeroException();
			}
			else
			{
				float factor = 1.0f / b;
				return new Vector2f(a.X * factor, a.Y * factor);
			}
		}

		/// <summary>Divides a scalar by a vector.</summary>
		/// <param name="a">The scalar.</param>
		/// <param name="b">The vector.</param>
		/// <returns>The quotient of the scalar and the vector.</returns>
		/// <exception cref="DivideByZeroException">Raised when any member of the vector is zero.</exception>
		public static Vector2f operator /(float a, Vector2f b)
		{
			if (b.X == 0.0 | b.Y == 0.0)
			{
				throw new DivideByZeroException();
			}
			else
			{
				return new Vector2f(a / b.X, a / b.Y);
			}
		}

		// --- comparisons ---
		/// <summary>Checks whether the two specified vectors are equal.</summary>
		/// <param name="a">The first vector.</param>
		/// <param name="b">The second vector.</param>
		/// <returns>Whether the two vectors are equal.</returns>
		public static bool operator ==(Vector2f a, Vector2f b)
		{
			if (a.X != b.X) return false;
			if (a.Y != b.Y) return false;
			return true;
		}

		/// <summary>Checks whether the two specified vectors are unequal.</summary>
		/// <param name="a">The first vector.</param>
		/// <param name="b">The second vector.</param>
		/// <returns>Whether the two vectors are unequal.</returns>
		public static bool operator !=(Vector2f a, Vector2f b)
		{
			if (a.X != b.X) return true;
			if (a.Y != b.Y) return true;
			return false;
		}

		public static explicit operator Vector2f(Vector2d vector)
		{
			return new Vector2f((float)vector.X, (float)vector.Y);
		}

		// --- instance functions ---
		/// <summary>Normalizes the vector.</summary>
		/// <exception cref="System.DivideByZeroException">Raised when the vector is a null vector.</exception>
		public void Normalize()
		{
			float norm = (this.X * this.X) + (this.Y * this.Y);
			if (norm == 0.0)
			{
				throw new DivideByZeroException();
			}
			else
			{
				float factor = 1.0f / (float)System.Math.Sqrt(norm);
				this.X *= factor;
				this.Y *= factor;
			}
		}

		/// <summary>Translates the vector by a specified offset.</summary>
		/// <param name="offset">The offset.</param>
		public void Translate(Vector2f offset)
		{
			this.X += offset.X;
			this.Y += offset.Y;
		}

		/// <summary>Scales the vector by a specified factor.</summary>
		/// <param name="factor">The factor.</param>
		public void Scale(Vector2f factor)
		{
			this.X *= factor.X;
			this.Y *= factor.Y;
		}

		/// <summary>Rotates the vector by the specified angle.</summary>
		/// <param name="cosineOfAngle">The cosine of the angle.</param>
		/// <param name="sineOfAngle">The sine of the angle.</param>
		public void Rotate(float cosineOfAngle, float sineOfAngle)
		{
			float x = (cosineOfAngle * this.X) - (sineOfAngle * this.Y);
			float y = (sineOfAngle * this.X) + (cosineOfAngle * this.Y);
			this = new Vector2f(x, y);
		}

		/// <summary>Checks whether the vector is a null vector.</summary>
		/// <returns>A boolean indicating whether the vector is a null vector.</returns>
		public bool IsNullVector()
		{
			return this.X == 0.0 & this.Y == 0.0;
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
			return true;
		}

		/// <summary>Gets the euclidean norm.</summary>
		/// <returns>The euclidean norm.</returns>
		public float Norm()
		{
			return (float)System.Math.Sqrt((this.X * this.X) + (this.Y * this.Y));
		}

		/// <summary>Gets the square of the euclidean norm.</summary>
		/// <returns>The square of the euclidean norm.</returns>
		public float NormSquared()
		{
			return (this.X * this.X) + (this.Y * this.Y);
		}

		// --- static functions ---
		/// <summary>Gives the dot product of two vectors.</summary>
		/// <param name="a">The first vector.</param>
		/// <param name="b">The second vector.</param>
		/// <returns>The dot product of the two vectors.</returns>
		public static float Dot(Vector2f a, Vector2f b)
		{
			return (a.X * b.X) + (a.Y * b.Y);
		}

		/// <summary>Normalizes a vector.</summary>
		/// <param name="vector">The vector.</param>
		/// <returns>The normalized vector.</returns>
		/// <exception cref="System.DivideByZeroException">Raised when the vector is a null vector.</exception>
		public static Vector2f Normalize(Vector2f vector)
		{
			float norm = (vector.X * vector.X) + (vector.Y * vector.Y);
			if (norm == 0.0)
			{
				throw new DivideByZeroException();
			}
			else
			{
				float factor = 1.0f / (float)System.Math.Sqrt(norm);
				return new Vector2f(vector.X * factor, vector.Y * factor);
			}
		}

		/// <summary>Translates a vector by a specified offset.</summary>
		/// <param name="vector">The vector.</param>
		/// <param name="offset">The offset.</param>
		/// <returns>The translated vector.</returns>
		public static Vector2f Translate(Vector2f vector, Vector2f offset)
		{
			float x = vector.X + offset.X;
			float y = vector.Y + offset.Y;
			return new Vector2f(x, y);
		}

		/// <summary>Scales a vector by a specified factor.</summary>
		/// <param name="vector">The vector.</param>
		/// <param name="factor">The factor.</param>
		/// <returns>The scaled vector.</returns>
		public static Vector2f Scale(Vector2f vector, Vector2f factor)
		{
			float x = vector.X * factor.X;
			float y = vector.Y * factor.Y;
			return new Vector2f(x, y);
		}

		/// <summary>Rotates a vector by a specified vector.</summary>
		/// <param name="vector">The vector.</param>
		/// <param name="angle">The angle vector.</param>
		/// <returns>The rotated vector.</returns>
		public static Vector2f Rotate(Vector2f vector, Vector2f angle)
		{
			float x = (angle.X * vector.X) - (angle.Y * vector.Y);
			float y = (angle.Y * vector.X) + (angle.X * vector.Y);
			return new Vector2f(x, y);
		}

		/// <summary>Rotates a vector by a specified angle.</summary>
		/// <param name="vector">The vector.</param>
		/// <param name="cosineOfAngle">The cosine of the angle.</param>
		/// <param name="sineOfAngle">The sine of the angle.</param>
		/// <returns>The rotated vector.</returns>
		public static Vector2f Rotate(Vector2f vector, float cosineOfAngle, float sineOfAngle)
		{
			float x = (cosineOfAngle * vector.X) - (sineOfAngle * vector.Y);
			float y = (sineOfAngle * vector.X) + (cosineOfAngle * vector.Y);
			return new Vector2f(x, y);
		}

		/// <summary>Checks whether a vector is a null vector.</summary>
		/// <returns>A boolean indicating whether the vector is a null vector.</returns>
		public static bool IsNullVector(Vector2f vector)
		{
			return vector.X == 0.0 & vector.Y == 0.0;
		}

		/// <summary>Gets the euclidean norm of the specified vector.</summary>
		/// <param name="vector">The vector.</param>
		/// <returns>The euclidean norm.</returns>
		public static float Norm(Vector2f vector)
		{
			return (float)System.Math.Sqrt((vector.X * vector.X) + (vector.Y * vector.Y));
		}

		/// <summary>Gets the square of the euclidean norm of the specified vector.</summary>
		/// <param name="vector">The vector.</param>
		/// <returns>The square of the euclidean norm.</returns>
		public static float NormSquared(Vector2f vector)
		{
			return (vector.X * vector.X) + (vector.Y * vector.Y);
		}

		public static Vector2f Cross(Vector2f a)
		{
			return new Vector2f(-a.Y, a.X);
		}

		// --- read-only fields ---
		/// <summary>Represents a null vector.</summary>
		public static readonly Vector2f Null = new Vector2f(0.0f, 0.0f);

		/// <summary>Represents a vector pointing left.</summary>
		public static readonly Vector2f Left = new Vector2f(-1.0f, 0.0f);

		/// <summary>Represents a vector pointing right.</summary>
		public static readonly Vector2f Right = new Vector2f(1.0f, 0.0f);

		/// <summary>Represents a vector pointing up.</summary>
		public static readonly Vector2f Up = new Vector2f(0.0f, -1.0f);

		/// <summary>Represents a vector pointing down.</summary>
		public static readonly Vector2f Down = new Vector2f(0.0f, 1.0f);

		// --- overrides and interface implementations ---
		public int CompareTo(Vector2f other)
		{
			if (this.X < other.X) return -1;
			if (this.X > other.X) return 1;
			if (this.Y < other.Y) return -1;
			if (this.Y > other.Y) return 1;
			return 0;
		}

		public bool Equals(Vector2f other)
		{
			if (this.X != other.X) return false;
			if (this.Y != other.Y) return false;
			return true;
		}

		public override bool Equals(object obj)
		{
			if (!(obj is Vector2f)) return false;
			Vector2f other = (Vector2f)obj;
			if (this.X != other.X) return false;
			if (this.Y != other.Y) return false;
			return true;
		}

		public override int GetHashCode()
		{
			int hashCode = 0;
			unchecked
			{
				hashCode += 1000000007 * X.GetHashCode();
				hashCode += 1000000009 * Y.GetHashCode();
			}
			return hashCode;
		}

		public override string ToString()
		{
			return '{' + this.X.ToString() + ',' + this.Y.ToString() + '}';
		}
	}
}