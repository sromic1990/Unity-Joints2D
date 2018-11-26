using UnityEngine;

namespace Joints2DTest.Scripts
{
	public class JointsSample : MonoBehaviour 
	{
	
		// Use this for initialization
		private void Start () {

		}

		// Update is called once per frame

		private void OnGUI()
		{
			GUI.Label(new Rect(2, 2, 300, 300), "Distance Joint 2D\nUse the mouse to move");
			GUI.Label(new Rect(300, 2, 300, 300), "Spring Joint 2D\nUse the mouse to move");
			GUI.Label(new Rect(550, 10, 300, 300), "Wheel Joint 2D");
			GUI.Label(new Rect(200, 250, 300, 300), "Hinge Joint 2D");
			GUI.Label(new Rect(570, 270, 300, 300), "Slider Joint 2D");
		}
	}
}
