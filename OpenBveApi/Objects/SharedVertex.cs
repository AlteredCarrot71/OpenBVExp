namespace OpenBveApi.Objects
{
	/// <summary>Represents a vertex used in a shared mesh.</summary>
	public struct SharedVertex
	{
		// --- members ---
		/// <summary>A reference to the list of spatial coordinates in the underlying shared mesh.</summary>
		public int SpatialCoordinates;
		/// <summary>A reference to the list of texture coordinates in the underlying shared mesh.</summary>
		public int TextureCoordinates;
		/// <summary>A reference to the list of normals in the underlying shared mesh.</summary>
		public int Normal;
	}
}