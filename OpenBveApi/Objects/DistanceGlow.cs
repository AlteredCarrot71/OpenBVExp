using Common.Geometry;
using OpenBveApi.Math;

namespace OpenBveApi.Objects
{
	/// <summary>Represents a glow where the intensity is inversely proportional to the distance between the object and the camera.</summary>
	public class DistanceGlow : OrientationalGlow
	{
		// --- members ---
		/// <summary>The square of the distance at which the intensity is exactly 50%.</summary>
		private double HalfDistanceSquared;
		// --- constructors ---
		/// <summary>Creates a new distance glow.</summary>
		/// <param name="halfDistance">The distance at which the intensity is exactly 50%.</param>
		public DistanceGlow(double halfDistance)
		{
			this.HalfDistanceSquared = halfDistance * halfDistance;
		}
		// --- functions ---
		/// <summary>Gets the intensity of the glow.</summary>
		/// <param name="cameraPosition">The position of the camera.</param>
		/// <param name="cameraOrientation">The orientation of the camera.</param>
		/// <param name="objectPosition">The position of the object.</param>
		/// <param name="objectOrientation">The orientation of the object.</param>
		/// <returns>The intensity of the glow expressed as a value between 0 and 1.</returns>
		public override double GetIntensity(Vector3d cameraPosition, Orientation3 cameraOrientation, Vector3d objectPosition, Vector3d objectOrientation)
		{
			/* The underlying formula for the intensity is
			 *    i = d^2 / (d^2 + h^2)
			 * where
			 *    i = intensity
			 *    d = distance between object and camera
			 *    h = distance at which intensity is 50% */
			double distanceSquared = (objectPosition - cameraPosition).NormSquared();
			return distanceSquared / (distanceSquared + this.HalfDistanceSquared);
		}
	}
}