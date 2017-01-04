using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class PlusItemButtonController : MonoBehaviour {	
	public ItemDescriptionPanelController itemDescriptionPanel;
	public ItemData itemData;
	public SelectItemController item;

	void Start () {
		Button plusButton = GetComponent<Button> ();
		plusButton.onClick.AddListener (PushPlusButton);
	}

	//プラスボタンのクリック時のitemDescriptionPanelのitemNameの内容を引き渡す
	void PushPlusButton()
	{
		string prefabName = itemDescriptionPanel.itemNameField.text;
		FurnituresListPopUpController.instance.SetItemPrefab (prefabName);
	}
}
