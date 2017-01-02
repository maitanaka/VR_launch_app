using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System;

public class ItemController : MonoBehaviour {

	public ItemData itemData;
	public Const.ItemCategory itemCategory;

	public void SetData(ItemData data)
	{
		itemData = data;
		var obj = (GameObject)Instantiate (Resources.Load ("Items/Furnitures/" + data.prefabName));
		obj.transform.SetParent (transform);

		obj.transform.localPosition = Vector3.zero;
		obj.transform.localScale = Vector3.one;
		obj.transform.localEulerAngles = Vector3.zero;

	}
}
