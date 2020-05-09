using Common.Colors;
using TrainsimApi.Vectors;

namespace CsvB3dDecoder 
{
	internal class MeshBuilderFace 
	{
		// --- members ---
		internal int[] Vertices;

		internal MeshBuilderFaceNormals Normals;
		
		internal float Alpha;
		
		internal RGBf EmissiveColor;
		
		internal RGBf ReflectiveColor;
		
		internal int LineNumber;
		
		// --- constructors ---
		internal MeshBuilderFace(int offset, int[] vertices, int lineNumber) {
			this.Vertices = new int[vertices.Length];
			this.Normals = MeshBuilderFaceNormals.Default;
			for (int i = 0; i < vertices.Length; i++) {
				this.Vertices[i] = vertices[i] + offset;
			}
			this.Alpha = 1.0f;
			this.EmissiveColor = RGBf.Black;
			this.ReflectiveColor = RGBf.White;
			this.LineNumber = lineNumber;
		}
	}
}