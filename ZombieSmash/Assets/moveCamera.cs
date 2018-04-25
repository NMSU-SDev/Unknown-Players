using UnityEngine;

public class moveCamera : MonoBehaviour {
	public Transform target;
	public float smoothSpeed = 0.125f;
	public Vector3 offset;
	void LateUpdate ()
	{
		transform.position = target.position + offset;
	}
}
