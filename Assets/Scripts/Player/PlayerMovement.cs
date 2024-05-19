using UnityEngine;

/// <summary>
/// Base class, handles player movement.
/// </summary>
public abstract class PlayerMovement : MonoBehaviour
{
	private void Update()
	{
		Vector2 position2D = transform.position;
		float heading = transform.eulerAngles.z;

        position2D += ComputeMovementDelta(Time.deltaTime);
		heading += ComputeRotationDelta(Time.deltaTime);

		transform.position = position2D;
		transform.rotation = Quaternion.Euler(transform.eulerAngles.x, transform.eulerAngles.y, heading);
	}

	/// <summary>
	/// Classes need to implement movement delta
	/// </summary>
	protected abstract Vector2 ComputeMovementDelta(float deltaTime);
	protected abstract float ComputeRotationDelta(float deltaTime);
}
