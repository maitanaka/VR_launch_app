using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class PlusItemButtonController : MonoBehaviour {	
	public ItemDescriptionPanelController itemDescriptionPanel;
	public ItemData itemData;

	void Start () {
		Button plusButton = GetComponent<Button> ();
		plusButton.onClick.AddListener (PushPlusButton);
	}

	void PushPlusButton()
	{
		string prefabName = itemDescriptionPanel.itemNameField.text;
		string prefabCategory = itemDescriptionPanel.itemCategory;
		RoomController.instance.PlaceItem (prefabName, prefabCategory);
	}
}
