using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

[System.SerializableAttribute]

public class RoomData {

	public enum RoomCategory {
		Fashion = 1,
		Hobby = 2,
		Music = 3,
		Art = 4,
		Dream = 5,
		Love = 6
	}

	public RoomCategory roomCategory;

	public List<string> tagLists = new List<string>();

	public GameObject currentWallSkin;

	public int id;

	public string
		title,
	    story;

}
