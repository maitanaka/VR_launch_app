using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;
using System.Collections.Generic;

public class ItemButtonController : MonoBehaviour {

	public GameObject ItemInfoPanel;
	public GameObject itemPrefab;

	public Image itemImage;
	public Text itemName;

	void Start() 
	{

		ItemController item =  itemPrefab.GetComponent<ItemController> ();
		itemImage.sprite = item.itemData.itemImage;
		itemName.text = item.itemData.itemName;
	}

	//showItemDetails
	public void ShowItemDetails() 

	{
		ItemController item =  itemPrefab.GetComponent<ItemController> ();
		ItemInfoController itemInfo = ItemInfoPanel.GetComponent<ItemInfoController> ();

		itemInfo.ItemImageField.sprite = item.itemData.itemImage;
		itemInfo.itemNameField.text = item.itemData.itemName;
		itemInfo.priceField.text = item.itemData.price + "円(税込)";
		itemInfo.creatorNameField.text = item.itemData.creatorName;
		itemInfo.commentField.text = item.itemData.comment;

		String likecCount = item.itemData.likeCount.ToString();
		itemInfo.likeCountField.text = likecCount;

	}

}