using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System;

public class ItemController : SingletonMonoBehaviour<ItemController> {
	public Button plusItemButton;
	private ItemData itemData;


	 public void SetValue(ItemData data)
	{
		itemData = data;
		var obj = (GameObject)Instantiate (Resources.Load ("Items/" + data.itemCategory + "/" + data.itemName));
		obj.transform.SetParent (transform);
		obj.transform.localPosition = Vector3.zero;
		obj.transform.localScale = Vector3.one;
		obj.transform.localEulerAngles = Vector3.zero;
	}
}