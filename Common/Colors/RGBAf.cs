namespace Common.Colors
{
	/// <summary>Represents a 128-bit color with red, green, blue and alpha channels at 32 bits each.</summary>
	public struct RGBAf
	{
		// --- members ---
		/// <summary>The red component.</summary>
		public float R;
		/// <summary>The green component.</summary>
		public float G;
		/// <summary>The blue component.</summary>
		public float B;
		/// <summary>The alpha component.</summary>
		public float A;
		// --- constructors ---
		/// <summary>Creates a new color.</summary>
		/// <param name="r">The red component.</param>
		/// <param name="g">The green component.</param>
		/// <param name="b">The blue component.</param>
		/// <param name="a">The alpha component.</param>
		public RGBAf(float r, float g, float b, float a)
		{
			this.R = r;
			this.G = g;
			this.B = b;
			this.A = a;
		}
		/// <summary>Creates a new color.</summary>
		/// <param name="r">The red component.</param>
		/// <param name="g">The green component.</param>
		/// <param name="b">The blue component.</param>
		/// <remarks>The alpha component is set to full opacity.</remarks>
		public RGBAf(float r, float g, float b)
		{
			this.R = r;
			this.G = g;
			this.B = b;
			this.A = 1.0f;
		}
		/// <summary>Creates a new color.</summary>
		/// <param name="color">The solid color.</param>
		/// <param name="a">The alpha component.</param>
		public RGBAf(RGBb color, float a)
		{
			this.R = color.R;
			this.G = color.G;
			this.B = color.B;
			this.A = a;
		}
		/// <summary>Creates a new color.</summary>
		/// <param name="color">The solid color.</param>
		/// <remarks>The alpha component is set to full opacity.</remarks>
		public RGBAf(RGBb color)
		{
			this.R = color.R;
			this.G = color.G;
			this.B = color.B;
			this.A = 1.0f;
		}
		// --- operators ---
		/// <summary>Checks whether two colors are equal.</summary>
		/// <param name="a">The first color.</param>
		/// <param name="b">The second color.</param>
		/// <returns>Whether the two colors are equal.</returns>
		public static bool operator ==(RGBAf a, RGBAf b)
		{
			return a.R == b.R & a.G == b.G & a.B == b.B & a.A == b.A;
		}
		/// <summary>Checks whether two colors are unequal.</summary>
		/// <param name="a">The first color.</param>
		/// <param name="b">The second color.</param>
		/// <returns>Whether the two colors are unequal.</returns>
		public static bool operator !=(RGBAf a, RGBAf b)
		{
			return a.R != b.R | a.G != b.G | a.B != b.B | a.A != b.A;
		}
		// --- read-only fields ---
		/// <summary>Represents a black color.</summary>
		public static readonly RGBAf Black = new RGBAf(0.0f, 0.0f, 0.0f);
		/// <summary>Represents a red color.</summary>
		public static readonly RGBAf Red = new RGBAf(1.0f, 0.0f, 0.0f);
		/// <summary>Represents a green color.</summary>
		public static readonly RGBAf Green = new RGBAf(0.0f, 1.0f, 0.0f);
		/// <summary>Represents a blue color.</summary>
		public static readonly RGBAf Blue = new RGBAf(0.0f, 0.0f, 1.0f);
		/// <summary>Represents a cyan color.</summary>
		public static readonly RGBAf Cyan = new RGBAf(0.0f, 1.0f, 1.0f);
		/// <summary>Represents a magenta color.</summary>
		public static readonly RGBAf Magenta = new RGBAf(1.0f, 0.0f, 1.0f);
		/// <summary>Represents a yellow color.</summary>
		public static readonly RGBAf Yellow = new RGBAf(1.0f, 1.0f, 0.0f);
		/// <summary>Represents a white color.</summary>
		public static readonly RGBAf White = new RGBAf(1.0f, 1.0f, 1.0f);
		/// <summary>Represents a transparent black color.</summary>
		public static readonly RGBAf Transparent = new RGBAf(0.0f, 0.0f, 0.0f, 0.0f);
		// --- conversions ---
		/// <summary>Performs a widening conversion from Color96 to Color128.</summary>
		/// <param name="value">The Color96 value.</param>
		/// <returns>The Color128 value.</returns>
		public static implicit operator RGBAf(RGBb value)
		{
			return new RGBAf(value.R, value.G, value.B);
		}
		/// <summary>Performs a narrowing conversion from Color128 to Color96.</summary>
		/// <param name="value">The Color128 value.</param>
		/// <returns>The Color96 value.</returns>
		public static explicit operator RGBf(RGBAf value)
		{
			return new RGBf(value.R, value.G, value.B);
		}
	}
}