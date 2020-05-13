namespace Common.Geometry
{
	/// <summary>Represents a vertex consisting of 3D coordinates and 2D texture coordinates.</summary>
	internal struct Vertex
	{
		internal Vector3d Coordinates;
		internal Vector2f TextureCoordinates;
		internal Vertex(double X, double Y, double Z)
		{
			this.Coordinates = new Vector3d(X, Y, Z);
			this.TextureCoordinates = new Vector2f(0.0f, 0.0f);
		}
		internal Vertex(Vector3d Coordinates, Vector2f TextureCoordinates)
		{
			this.Coordinates = Coordinates;
			this.TextureCoordinates = TextureCoordinates;
		}
		internal static bool Equals(Vertex A, Vertex B)
		{
			if (A.Coordinates.X != B.Coordinates.X | A.Coordinates.Y != B.Coordinates.Y | A.Coordinates.Z != B.Coordinates.Z) return false;
			if (A.TextureCoordinates.X != B.TextureCoordinates.X | A.TextureCoordinates.Y != B.TextureCoordinates.Y) return false;
			return true;
		}
		// operators
		public static bool operator ==(Vertex A, Vertex B)
		{
			if (A.Coordinates.X != B.Coordinates.X | A.Coordinates.Y != B.Coordinates.Y | A.Coordinates.Z != B.Coordinates.Z) return false;
			if (A.TextureCoordinates.X != B.TextureCoordinates.X | A.TextureCoordinates.Y != B.TextureCoordinates.Y) return false;
			return true;
		}
		public static bool operator !=(Vertex A, Vertex B)
		{
			if (A.Coordinates.X != B.Coordinates.X | A.Coordinates.Y != B.Coordinates.Y | A.Coordinates.Z != B.Coordinates.Z) return true;
			if (A.TextureCoordinates.X != B.TextureCoordinates.X | A.TextureCoordinates.Y != B.TextureCoordinates.Y) return true;
			return false;
		}
	}
}