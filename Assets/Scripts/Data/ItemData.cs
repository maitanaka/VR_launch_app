using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System;

[System.SerializableAttribute]

public class ItemData{

	public Sprite itemImage;
	public string itemImagePath;
	public int price;
	public string itemName;
	public string creatorName;
	public string comment;
	public int likeCount;
	public int id;

	public Const.ItemCategory itemCategory;

	public void SetData(string[] data)
	{
		itemName = data [0];
		id = int.Parse(data [1]);
		price = int.Parse(data [2]);
		comment = data [3];
		creatorName = data [4];
		itemImagePath = data [5];
		likeCount = int.Parse(data [6]);
		itemCategory = (Const.ItemCategory)int.Parse(data [7]);
	}
}
