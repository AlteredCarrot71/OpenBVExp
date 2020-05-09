using Common.Geometry;
using TrainsimApi.Vectors;

namespace CsvB3dDecoder {
	internal class MeshBuilderVertex {
		
		
		// --- members ---
		
		internal Vector3d Position;
		
		internal Vector3d Normal;
		
		internal Vector2d Texture;
		
		
		// --- constructors ---
		
		internal MeshBuilderVertex(Vector3d position) {
			this.Position = position;
			this.Normal = Vector3d.Zero;
			this.Texture = Vector2d.Null;
		}
		
		internal MeshBuilderVertex(Vector3d position, Vector3d normal, Vector2d texture) {
			this.Position = position;
			this.Normal = normal;
			this.Texture = texture;
		}
		
		
	}
}
