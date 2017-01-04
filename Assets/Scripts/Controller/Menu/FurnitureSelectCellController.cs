using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;
using System.Collections.Generic;

public class FurnitureSelectCellController : MonoBehaviour {

	public Image itemImage;
	public Text itemName;
	public Button selectButton;

	private ItemData itemData;

	private void Start()
	{
		selectButton.onClick.AddListener (PushCell);
	}

	public void SetValue(ItemData data)
	{
		itemData = data;
		itemName.text = data.itemName;
		itemImage.sprite = Resources.Load<Sprite>("Images/Items/" + data.itemCategory.ToString () + "/" + data.itemName);
	}

	public void PushCell()
	{
		FurnituresListPopUpController.instance.itemDescriptionPanel.SetDescription (itemData);
	}

}