using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class DisplayController : MonoBehaviour {

	private RoomsController selectedRoom;
	public List<RoomsController> rooms = new List<RoomsController>();
	public Transform selectPosition;

	int row = 3;
	int col = 3;
	float posOffset = 2.0f;

	public void Start(){
		ShowRooms ();
	}

	public void ShowRooms () {
		int spawnNum = 1;
		for (int i = 0; i < row; i++) {
			for (int j = 0; j < col; j++) {
				GameObject prefab = (GameObject)Resources.Load("Rooms/" + spawnNum.ToString());
				Vector3 spawnPos = new Vector3(
					transform.position.x + (i * posOffset), 
					transform.position.y + (j * posOffset), 
					transform.position.z);
				GameObject room = Instantiate (prefab);
				room.transform.position = spawnPos;
				room.transform.SetParent(transform);
				RoomsController roomsController = room.GetComponent<RoomsController>();
				roomsController.SetDefaultPosition();
				roomsController.CancelSelect();
				rooms.Add( roomsController );
				spawnNum += 1;
			}
		}
	}


	public void SelectProduct (RoomsController selected) {
		if (selectedRoom != null) selectedRoom.CancelSelect();
		selectedRoom = rooms.Find(p => p.roomData.id == selected.roomData.id);
		selectedRoom.SetTargetPosition(selectPosition.position);
	}

}
