using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class RoomController: SingletonMonoBehaviour<RoomController> {

	public RoomData roomData;
	public Vector3 defaultPosition;
	private Vector3 target;
	private List<RoomData> roomDataList = new List<RoomData>();

	public void PlaceItem(string prefabName, string prefabCategory) 
	{
		var itemPrefab = (GameObject)Instantiate (Resources.Load ("Items/" + prefabCategory + "/" + prefabName));
		itemPrefab.transform.localPosition = Vector3.zero;
		var itemController = itemPrefab.GetComponent<ItemController> ();
	}

}
