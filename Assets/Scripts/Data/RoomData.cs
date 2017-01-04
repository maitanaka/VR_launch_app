using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using LitJson;

[System.SerializableAttribute]

public class RoomData {

	public Const.RoomCategory roomCategory;
	public List<string> tagLists = new List<string>();
	public GameObject currentWallSkin;
	public int id;
	public string title;
	public string story;
	public List<Transform> itemPosition = new List<Transform> ();
	public List<int> itemIds = new List<int>();
}
