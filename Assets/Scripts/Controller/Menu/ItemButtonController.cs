using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;
using System.Collections.Generic;

public class ItemButtonController : MonoBehaviour {

//	private ItemData itemData;
	public GameObject ItemInfoPanel;
	public GameObject itemPrefab;

	//itemInfo側
//	public Image ItemImageField;
//	public Text priceField;
//	public Text itemNameField;
//	public Text creatorNameField;
//	public Text commentField;
//
	//itemButton側



	//showItemDetails
	public void ShowItemDetails() 

	{
		ItemController item =  itemPrefab.GetComponent<ItemController> ();
		ItemInfoController itemInfo = ItemInfoPanel.GetComponent<ItemInfoController> ();

		itemInfo.ItemImageField.sprite = item.itemData.itemImage;
		itemInfo.itemNameField.text = item.itemData.itemName;
		itemInfo.priceField.text = item.itemData.price;
		itemInfo.creatorNameField.text = item.itemData.creatorName;
		itemInfo.commentField.text = item.itemData.comment;

		
//		itemInfo.ItemImageField.GetComponent<Image> ().sprite = itemData.itemImage;
//		itemInfo.priceField.GetComponent<Text> ().text = price;
//		itemInfo.itemNameField.GetComponent<Text> ().text = itemName.text;
//		itemInfo.creatorNameField.GetComponent<Text> ().text = creatorName;
//		itemInfo.commentField.GetComponent<Text> ().text = comment;
//		ItemInfo.GetComponent<IteTextmData> ().ItemImage.GetComponent<Image> ().material.mainTexture = itemImage;
	}
}
