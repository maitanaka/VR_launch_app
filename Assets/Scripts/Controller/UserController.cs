using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class UserController : MonoBehaviour {

	Vector3 diff;
	public Camera camera;
	public Vector3 cameraPos;

	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit = new RaycastHit ();

			if (Physics.Raycast (ray, out hit)) {
				GameObject selectedRoom = hit.collider.gameObject;
//				print (selectedRoom);
				EnterRoom(selectedRoom);
			}
		}
	}

	public void EnterRoom(GameObject selectedRoom){
		Transform centerPosition = selectedRoom.gameObject.GetComponent<RoomsController> ().centerPosition;
		Vector3 center = new Vector3(
			centerPosition.transform.position.x, 
			centerPosition.transform.position.y - 1.5f, 
			centerPosition.transform.position.z);
		
//		print (selectedRoom.name);
		print (centerPosition);
		camera.transform.Translate (center.x, center.y, center.z);
	}
	// Use this for initialization
	void Start () {
		
	}
}