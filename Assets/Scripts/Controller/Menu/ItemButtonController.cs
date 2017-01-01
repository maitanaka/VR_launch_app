using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;
using System.Collections.Generic;

public class ItemButtonController : MonoBehaviour {

	public GameObject ItemInfoPanel;
	public GameObject itemPrefab;


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

		String likecCount = item.itemData.LikeCount.ToString();
		itemInfo.likeCountField.text = likecCount;

	}

}