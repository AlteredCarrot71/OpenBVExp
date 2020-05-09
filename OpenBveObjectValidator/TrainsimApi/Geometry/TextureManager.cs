using Common.Colors;
using System.Drawing;

namespace TrainsimApi.Geometry {
 	public abstract class TextureManager 
	{
		// --- functions ---
		public abstract Texture Add(string file);
		
		public abstract Texture Add(string file, RGBb transparentColor);
		
		public abstract Texture Add(Bitmap bitmap);
	}
}
