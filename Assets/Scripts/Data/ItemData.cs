using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System;

[System.SerializableAttribute]

public class ItemData{

	public Sprite itemImage;
	public string price;
	public string itemName;
	public string creatorName;
	public string comment;
	public int LikeCount;


	public enum ItemCategory
	{
		Furniture = 1,
		Good = 2,
		Light = 3,
		Building = 4,
		Scene = 5,
		WallAndWindows = 5
	}
			
}
