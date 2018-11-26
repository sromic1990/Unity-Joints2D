using UnityEngine;

namespace Joints2DTest.Scripts
{
	public class Movement : MonoBehaviour 
	{

		private bool _drag;					// True if is being dragged
		private Rigidbody2D _myRigidbody;	// Reference to the GameObject's Rigidbody2D
		private bool _wasKinematic;			// Flag indicating whether or not the Ridigbody

		// Use this for initialization
		private void Start () {
			_myRigidbody = GetComponent<Rigidbody2D>();
			_wasKinematic = _myRigidbody.isKinematic;
		}

		// Update is called once per frame
		private void Update () {
			if (_drag == true) {
				DragFunction();
			}
		}
	
		// Checks if the mouse button is pressed
		private void OnMouseDown() {
			_drag = true;
			_myRigidbody.isKinematic = true;
		}
	
		// Checks if the mouse button is released
		private void OnMouseUp() {

			// Update flags
			if (_drag == true)
				_myRigidbody.isKinematic = _wasKinematic;
			_drag = false;
		}

		private void DragFunction() {
			// We are converting a 2D mouse coordinate to 3D
			if (Camera.main != null)
			{
				float distanceToScreen = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
				Vector3 posMove = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, distanceToScreen ));
				// Update GameObject position
				transform.position = new Vector3( posMove.x, posMove.y, posMove.z );
			}
		}

	}
}
