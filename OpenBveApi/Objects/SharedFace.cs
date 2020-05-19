using System;

namespace OpenBveApi.Objects
{
	/// <summary>Represents a face used in a shared mesh.</summary>
	public struct SharedFace
	{
		// --- members ---
		/// <summary>The vertices of this face.</summary>
		public SharedVertex[] Vertices;
		/// <summary>The material used by this face.</summary>
		public AbstractMaterial Material;
		// --- functions ---
		/// <summary>Flips the face.</summary>
		public void Flip()
		{
			Array.Reverse(this.Vertices);
		}
	}
}