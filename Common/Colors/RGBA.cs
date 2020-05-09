﻿namespace Common.Colors
{
	/// <summary>Represents a 32-bit color with red, green, blue and alpha channels at 8 bits each.</summary>
	public struct RGBA
	{
		// --- members ---
		/// <summary>The red component.</summary>
		public byte R;
		/// <summary>The green component.</summary>
		public byte G;
		/// <summary>The blue component.</summary>
		public byte B;
		/// <summary>The alpha component.</summary>
		public byte A;
		// --- constructors ---
		/// <summary>Creates a new color.</summary>
		/// <param name="r">The red component.</param>
		/// <param name="g">The green component.</param>
		/// <param name="b">The blue component.</param>
		/// <param name="a">The alpha component.</param>
		public RGBA(byte r, byte g, byte b, byte a)
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
		public RGBA(byte r, byte g, byte b)
		{
			this.R = r;
			this.G = g;
			this.B = b;
			this.A = 255;
		}
		/// <summary>Creates a new color.</summary>
		/// <param name="color">The solid color.</param>
		/// <param name="a">The alpha component.</param>
		public RGBA(RGB color, byte a)
		{
			this.R = color.R;
			this.G = color.G;
			this.B = color.B;
			this.A = a;
		}
		/// <summary>Creates a new color.</summary>
		/// <param name="color">The solid color.</param>
		/// <remarks>The alpha component is set to full opacity.</remarks>
		public RGBA(RGB color)
		{
			this.R = color.R;
			this.G = color.G;
			this.B = color.B;
			this.A = 255;
		}
		// --- operators ---
		/// <summary>Checks whether two colors are equal.</summary>
		/// <param name="a">The first color.</param>
		/// <param name="b">The second color.</param>
		/// <returns>Whether the two colors are equal.</returns>
		public static bool operator ==(RGBA a, RGBA b)
		{
			return a.R == b.R & a.G == b.G & a.B == b.B & a.A == b.A;
		}
		/// <summary>Checks whether two colors are unequal.</summary>
		/// <param name="a">The first color.</param>
		/// <param name="b">The second color.</param>
		/// <returns>Whether the two colors are unequal.</returns>
		public static bool operator !=(RGBA a, RGBA b)
		{
			return a.R != b.R | a.G != b.G | a.B != b.B | a.A != b.A;
		}
		// --- read-only fields ---
		/// <summary>Represents a black color.</summary>
		public static readonly RGBA Black = new RGBA(0, 0, 0);
		/// <summary>Represents a red color.</summary>
		public static readonly RGBA Red = new RGBA(255, 0, 0);
		/// <summary>Represents a green color.</summary>
		public static readonly RGBA Green = new RGBA(0, 255, 0);
		/// <summary>Represents a blue color.</summary>
		public static readonly RGBA Blue = new RGBA(0, 0, 255);
		/// <summary>Represents a cyan color.</summary>
		public static readonly RGBA Cyan = new RGBA(0, 255, 255);
		/// <summary>Represents a magenta color.</summary>
		public static readonly RGBA Magenta = new RGBA(255, 0, 255);
		/// <summary>Represents a yellow color.</summary>
		public static readonly RGBA Yellow = new RGBA(255, 255, 0);
		/// <summary>Represents a white color.</summary>
		public static readonly RGBA White = new RGBA(255, 255, 255);
		/// <summary>Represents a transparent black color.</summary>
		public static readonly RGBA Transparent = new RGBA(0, 0, 0, 0);
		// --- conversions ---
		/// <summary>Performs a widening conversion from Color24 to Color32.</summary>
		/// <param name="value">The Color24 value.</param>
		/// <returns>The Color32 value.</returns>
		public static implicit operator RGBA(RGB value)
		{
			return new RGBA(value.R, value.G, value.B);
		}
		/// <summary>Performs a narrowing conversion from Color32 to Color24.</summary>
		/// <param name="value">The Color32 value.</param>
		/// <returns>The Color24 value.</returns>
		public static explicit operator RGB(RGBA value)
		{
			return new RGB(value.R, value.G, value.B);
		}
	}
}