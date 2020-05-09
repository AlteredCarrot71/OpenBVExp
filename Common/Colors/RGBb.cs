namespace Common.Colors
{
	/// <summary>Represents an RGB color with 8-bit precision per channel.</summary>
	public struct RGBb
	{
		// --- members ---
		/// <summary>The red component.</summary>
		public byte R;
		/// <summary>The green component.</summary>
		public byte G;
		/// <summary>The blue component.</summary>
		public byte B;
		// --- constructors ---
		/// <summary>Creates a new color.</summary>
		/// <param name="r">The red component.</param>
		/// <param name="g">The green component.</param>
		/// <param name="b">The blue component.</param>
		public RGBb(byte r, byte g, byte b)
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
		public static bool operator ==(RGBb a, RGBb b)
		{
			return a.R == b.R & a.G == b.G & a.B == b.B;
		}
		/// <summary>Checks whether two colors are unequal.</summary>
		/// <param name="a">The first color.</param>
		/// <param name="b">The second color.</param>
		/// <returns>Whether the two colors are unequal.</returns>
		public static bool operator !=(RGBb a, RGBb b)
		{
			return a.R != b.R | a.G != b.G | a.B != b.B;
		}
		// --- read-only fields ---
		/// <summary>Represents a black color.</summary>
		public static readonly RGBb Black = new RGBb(0, 0, 0);
		/// <summary>Represents a red color.</summary>
		public static readonly RGBb Red = new RGBb(255, 0, 0);
		/// <summary>Represents a green color.</summary>
		public static readonly RGBb Green = new RGBb(0, 255, 0);
		/// <summary>Represents a blue color.</summary>
		public static readonly RGBb Blue = new RGBb(0, 0, 255);
		/// <summary>Represents a cyan color.</summary>
		public static readonly RGBb Cyan = new RGBb(0, 255, 255);
		/// <summary>Represents a magenta color.</summary>
		public static readonly RGBb Magenta = new RGBb(255, 0, 255);
		/// <summary>Represents a yellow color.</summary>
		public static readonly RGBb Yellow = new RGBb(255, 255, 0);
		/// <summary>Represents a white color.</summary>
		public static readonly RGBb White = new RGBb(255, 255, 255);
	}
}