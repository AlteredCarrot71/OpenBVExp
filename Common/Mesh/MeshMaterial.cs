using Common.Colors;

namespace Common.Mesh
{
	/// <summary>Represents material properties.</summary>
	public struct MeshMaterial
	{
		/// <summary>A bit mask combining constants of the MeshMaterial structure.</summary>
		public byte Flags;
		public RGBAb Color;
		public RGBb TransparentColor;
		public RGBb EmissiveColor;
		public int DaytimeTextureIndex;
		public int NighttimeTextureIndex;
		/// <summary>A value between 0 (daytime) and 255 (nighttime).</summary>
		public byte DaytimeNighttimeBlend;
		public MaterialBlendMode BlendMode;
		/// <summary>A bit mask specifying the glow properties. Use GetGlowAttenuationData to create valid data for this field.</summary>
		public ushort GlowAttenuationData;
		public const int EmissiveColorMask = 1;
		public const int TransparentColorMask = 2;

		// operators
		public static bool operator ==(MeshMaterial A, MeshMaterial B)
		{
			if (A.Flags != B.Flags) return false;
			if (A.Color.R != B.Color.R | A.Color.G != B.Color.G | A.Color.B != B.Color.B | A.Color.A != B.Color.A) return false;
			if (A.TransparentColor.R != B.TransparentColor.R | A.TransparentColor.G != B.TransparentColor.G | A.TransparentColor.B != B.TransparentColor.B) return false;
			if (A.EmissiveColor.R != B.EmissiveColor.R | A.EmissiveColor.G != B.EmissiveColor.G | A.EmissiveColor.B != B.EmissiveColor.B) return false;
			if (A.DaytimeTextureIndex != B.DaytimeTextureIndex) return false;
			if (A.NighttimeTextureIndex != B.NighttimeTextureIndex) return false;
			if (A.BlendMode != B.BlendMode) return false;
			if (A.GlowAttenuationData != B.GlowAttenuationData) return false;
			return true;
		}
		public static bool operator !=(MeshMaterial A, MeshMaterial B)
		{
			if (A.Flags != B.Flags) return true;
			if (A.Color.R != B.Color.R | A.Color.G != B.Color.G | A.Color.B != B.Color.B | A.Color.A != B.Color.A) return true;
			if (A.TransparentColor.R != B.TransparentColor.R | A.TransparentColor.G != B.TransparentColor.G | A.TransparentColor.B != B.TransparentColor.B) return true;
			if (A.EmissiveColor.R != B.EmissiveColor.R | A.EmissiveColor.G != B.EmissiveColor.G | A.EmissiveColor.B != B.EmissiveColor.B) return true;
			if (A.DaytimeTextureIndex != B.DaytimeTextureIndex) return true;
			if (A.NighttimeTextureIndex != B.NighttimeTextureIndex) return true;
			if (A.BlendMode != B.BlendMode) return true;
			if (A.GlowAttenuationData != B.GlowAttenuationData) return true;
			return false;
		}
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}
	}
}
