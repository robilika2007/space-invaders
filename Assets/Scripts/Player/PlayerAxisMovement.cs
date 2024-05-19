using UnityEngine;

/// <summary>
/// Implementation of PlayerMovement. Uses Axis to change player position.
/// </summary>
public class PlayerAxisMovement : PlayerMovement
{
	[SerializeField] private float speed = 5;
	[SerializeField] private float rotationSpeed = 100;
	
	/// <summary>
	/// Calculate movement delta based on horizontal & vertical keys
	/// </summary>
	protected override Vector2 ComputeMovementDelta(float deltaTime)
	{
		Vector2 movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
		movement *= speed * deltaTime;
		return movement;
	}

	protected override float ComputeRotationDelta(float deltaTime)
	{
        float rotation = (Input.GetKey(KeyCode.Q) ? 1 : 0) - (Input.GetKey(KeyCode.E) ? 1 : 0);
		rotation *= rotationSpeed * deltaTime;
		return rotation;
	}
}
