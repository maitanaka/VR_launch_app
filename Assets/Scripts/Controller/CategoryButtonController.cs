using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;

public class CategoryButtonController : MonoBehaviour {
	public Const.RoomCategory category;
	public GameObject newRoom;

	public void ChooseCategory(int category) {
		newRoom.GetComponent<RoomController> ().roomData.roomCategory = (Const.RoomCategory)category;
	}
}
