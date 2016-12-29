using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;
using System.Collections.Generic;

public class ButtonController : MonoBehaviour {

	//Category
	public RoomData.RoomCategory category;
	public GameObject newRoom;

	//Story
	public InputField inputField;
	public Text text;
	private String content;

	public void ChooseCategory(int category) {
		Debug.Log (category);
		newRoom.GetComponent<RoomController> ().roomData.roomCategory = (RoomData.RoomCategory)category;
	}

	public void SetTags(string tag) {
		newRoom.GetComponent<RoomController> ().roomData.tagLists.Add (tag);
	}

	public void SaveStory(){
		content = inputField.text;
		newRoom.GetComponent<RoomController> ().roomData.story = content;
	}

}