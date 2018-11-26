using UnityEngine;

namespace Joints2DTest.Scripts
{
	public class Ball : MonoBehaviour 
	{

		private Vector3 _pos;                // Ball initial position

		// Use this for initialization
		private void Start () 
		{
			// Save ball position
			_pos = transform.position;
		}
	
		// Update is called once per frame
		private void Update () 
		{
			// If the ball gets off the screen
			if (transform.position.y < -8)
			{
				// stop forces affecting the RigidBody
				this.GetComponent<Rigidbody2D>().isKinematic = true;
				// reset position
				transform.position = _pos;
				// activate forces affecting the RigidBody
				this.GetComponent<Rigidbody2D>().isKinematic = false;
			}
		}
	}
}
