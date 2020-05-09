namespace Common.Colors
{
	/// <summary>Represents a 96-bit color with red, green and blue channels at 32 bits each.</summary>
	public struct RGBf
	{
		// --- members ---
		/// <summary>The red component.</summary>
		public float R;
		/// <summary>The green component.</summary>
		public float G;
		/// <summary>The blue component.</summary>
		public float B;
		// --- constructors ---
		/// <summary>Creates a new color.</summary>
		/// <param name="r">The red component.</param>
		/// <param name="g">The green component.</param>
		/// <param name="b">The blue component.</param>
		public RGBf(float r, float g, float b)
		{
			this.R = r;
			this.G = g;
			this.B = b;
		}
		// --- operators ---
		/// <summary>Checks whether two colors are equal.</summary>
		/// <param name="a">The first color.</param>
		/// <param name="b">The second color.</param>
		/// <returns>Whether the two colors are equal.</returns>
		public static bool operator ==(RGBf a, RGBf b)
		{
			return a.R == b.R & a.G == b.G & a.B == b.B;
		}
		/// <summary>Checks whether two colors are unequal.</summary>
		/// <param name="a">The first color.</param>
		/// <param name="b">The second color.</param>
		/// <returns>Whether the two colors are unequal.</returns>
		public static bool operator !=(RGBf a, RGBf b)
		{
			return a.R != b.R | a.G != b.G | a.B != b.B;
		}
		// --- read-only fields ---
		/// <summary>Represents a black color.</summary>
		public static readonly RGBf Black = new RGBf(0.0f, 0.0f, 0.0f);
		/// <summary>Represents a red color.</summary>
		public static readonly RGBf Red = new RGBf(1.0f, 0.0f, 0.0f);
		/// <summary>Represents a green color.</summary>
		public static readonly RGBf Green = new RGBf(0.0f, 1.0f, 0.0f);
		/// <summary>Represents a blue color.</summary>
		public static readonly RGBf Blue = new RGBf(0.0f, 0.0f, 1.0f);
		/// <summary>Represents a cyan color.</summary>
		public static readonly RGBf Cyan = new RGBf(0.0f, 1.0f, 1.0f);
		/// <summary>Represents a magenta color.</summary>
		public static readonly RGBf Magenta = new RGBf(1.0f, 0.0f, 1.0f);
		/// <summary>Represents a yellow color.</summary>
		public static readonly RGBf Yellow = new RGBf(1.0f, 1.0f, 0.0f);
		/// <summary>Represents a white color.</summary>
		public static readonly RGBf White = new RGBf(1.0f, 1.0f, 1.0f);
	}
}