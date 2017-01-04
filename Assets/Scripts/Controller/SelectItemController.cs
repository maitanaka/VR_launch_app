using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System;

public class SelectItemController : SingletonMonoBehaviour<SelectItemController> {
	public Transform floor;
	public Button plusItemButton;
	private ItemData itemData;

	public ItemController itemController;

	 public void SetValue(ItemData data)
	{
		itemData = data;
		var obj = (GameObject)Instantiate (Resources.Load ("Items/" + data.itemCategory + "/" + data.itemName));
		obj.transform.SetParent (floor);
//		obj.transform.localPosition = Vector3.zero;
		obj.GetComponent<ItemController> ().pivot.transform.localScale = Vector3.zero;
		obj.transform.localScale = new Vector3( 0.3f, 0.3f, 0.3f );
		obj.transform.localEulerAngles = Vector3.zero;

//		Instantiate(floor.GetComponent<Renderer>().bounds.center, transform.position,Quaternion.Euler(0,0,0));

	}
}