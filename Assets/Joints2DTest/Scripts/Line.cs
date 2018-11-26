using UnityEngine;
using UnityEngine.Serialization;

namespace Joints2DTest.Scripts
{
	public class Line : MonoBehaviour {

		public GameObject GameObject1;          // Reference to the first GameObject
		public GameObject GameObject2;          // Reference to the second GameObject

		private LineRenderer _line;  						 // Line Renderer

		// Use this for initialization
		private void Start () 
		{
			// Add a Line Renderer to the GameObject
			_line = this.gameObject.AddComponent<LineRenderer>();
			// Set the width of the Line Renderer
//			_line.SetWidth(0.05F, 0.05F);
			_line.startWidth = 0.05f;
			_line.endWidth = 0.05f;
			// Set the number of vertex fo the Line Renderer
//			_line.SetVertexCount(2);
			_line.positionCount = 2;
		}
	
		// Update is called once per frame
		public void Update () 
		{
			// Check if the GameObjects are not null
			if (GameObject1 != null && GameObject2 != null)
			{
				// Update position of the two vertex of the Line Renderer
				_line.SetPosition(0, GameObject1.transform.position);
				_line.SetPosition(1, GameObject2.transform.position);
			}
		}
	}
}
