using Common.Geometry;

namespace OpenBveApi.Math 
{
	/// <summary>Represents an orientation in three-dimensional space.</summary>
	public struct Orientation3 
	{
		// --- members ---
		/// <summary>The vector pointing right.</summary>
		public Vector3d X;
		
		/// <summary>The vector pointing up.</summary>
		public Vector3d Y;
		
		/// <summary>The vector pointing forward.</summary>
		public Vector3d Z;
		
		// --- constructors ---
		/// <summary>Creates a new orientation in three-dimensional space.</summary>
		/// <param name="x">The vector pointing right.</param>
		/// <param name="y">The vector pointing up.</param>
		/// <param name="z">The vector pointing forward.</param>
		public Orientation3(Vector3d x, Vector3d y, Vector3d z) {
			this.X = x;
			this.Y = y;
			this.Z = z;
		}
		
		// --- read-only fields ---
		/// <summary>Represents a null orientation.</summary>
		public static readonly Orientation3 Null = new Orientation3(Vector3d.Null, Vector3d.Null, Vector3d.Null);
		
		/// <summary>Represents the default orientation with X = {1, 0, 0}, Y = {0, 1, 0} and Z = {0, 0, 1}.</summary>
		public static readonly Orientation3 Default = new Orientation3(Vector3d.Right, Vector3d.Up, Vector3d.Forward);

		/// <summary>Rotates the vector from the default orientation into a specified orientation.</summary>
		/// <param name="orientation">The orientation.</param>
		/// <remarks>The default orientation is X = {1, 0, 0), Y = {0, 1, 0} and Z = {0, 0, 1}.</remarks>
		public static Vector3d Rotate(Vector3d vector, Orientation3 orientation)
		{
			double x = orientation.X.X * vector.X + orientation.Y.X * vector.Y + orientation.Z.X * vector.Z;
			double y = orientation.X.Y * vector.X + orientation.Y.Y * vector.Y + orientation.Z.Y * vector.Z;
			double z = orientation.X.Z * vector.X + orientation.Y.Z * vector.Y + orientation.Z.Z * vector.Z;
			return new Vector3d(x, y, z);
		}

		/// <summary>Translates the vector by a specified offset that is measured in a specified orientation.</summary>
		/// <param name="orientation">The orientation.</param>
		/// <param name="offset">The offset measured in the specified orientation.</param>
		public static void Translate(Vector3d vector, Orientation3 orientation, Vector3d offset)
		{
			vector.X += orientation.X.X * offset.X + orientation.Y.X * offset.Y + orientation.Z.X * offset.Z;
			vector.Y += orientation.X.Y * offset.X + orientation.Y.Y * offset.Y + orientation.Z.Y * offset.Z;
			vector.Z += orientation.X.Z * offset.X + orientation.Y.Z * offset.Y + orientation.Z.Z * offset.Z;
		}
	}
}