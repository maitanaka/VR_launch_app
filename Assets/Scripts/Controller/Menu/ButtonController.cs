using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;
using System.Collections.Generic;

public class ButtonController : MonoBehaviour {

	//各パネル
	public GameObject StoryPanel;
	public GameObject TagsPanel;
	public GameObject CategoryPanel;

	//Category
	public RoomData.RoomCategory category;
	public GameObject newRoom;

	//Story
	public InputField inputField;
	public Text text;
	private String content;


	//showItemDetails
	public GameObject itemObj;
	public int price;
	public string itemName;
	public string creatorName;
	public string comment;
//	public Transform SetChild(GameObject parent,GameObject child, string name = null)
//	{
//		GameObject obj = Instantiate (child);
//
//		obj.transform.SetParent (parent.transform);
//
//		obj.transform.localPosition = new Vector3 (0f, 0f, 0f);
//		obj.transform.localScale = new Vector3 (1f, 1f, 1f);
//
//		obj.name = (name != null) ? name : child.name;
//
//		return obj.transform;
//	}

	public void ChooseCategory(int category) {
		newRoom.GetComponent<RoomController> ().roomData.roomCategory = (RoomData.RoomCategory)category;
	}

	public void SetTags(string tag) {
		newRoom.GetComponent<RoomController> ().roomData.tagLists.Add (tag);
	}

	public void SaveStory(){
		string content = text.text;
		Debug.Log (content);
		Debug.Log ("aaaaa");
		newRoom.GetComponent<RoomController> ().roomData.story = content;
	}



}