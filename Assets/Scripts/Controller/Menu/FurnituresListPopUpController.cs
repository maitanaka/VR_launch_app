using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class FurnituresListPopUpController : SingletonMonoBehaviour<FurnituresListPopUpController>{
	public ItemDescriptionPanelController itemDescriptionPanel;
	public GameObject furnitureSelectCellPrefab;
	public Transform cellScrollPanelOrigin;
	public SelectItemController itemController;

	private List<FurnitureSelectCellController> furnitureSelectCells = new List<FurnitureSelectCellController>();

	//クリックしたcategoryタブと一致したitemのデータを取得
	public void SetItemList(Const.ItemCategory category)
	{
		foreach (var cell in furnitureSelectCells) 
		{
			Destroy (cell.gameObject, 0.001f);
		}

		furnitureSelectCells = new List<FurnitureSelectCellController>();

		var itemList = (
			from d in GameManager.instance.itemDataList
			where d.itemCategory == category
		 	select d
		).ToList ();

		foreach (var item in itemList) 
		{
			var obj = (GameObject)Instantiate(furnitureSelectCellPrefab);
			obj.transform.SetParent (cellScrollPanelOrigin);
			obj.transform.localPosition = Vector3.zero;
			obj.transform.localScale = Vector3.one;
			obj.transform.localEulerAngles = Vector3.zero;
			var cell = obj.GetComponent<FurnitureSelectCellController> ();
			cell.SetValue (item);
			furnitureSelectCells.Add (cell);
		}
	}

	//plusボタンを押した時のitemDescriptionPanelのitemNameと一致したitemのデータを取得
	public void SetItemPrefab(string prefabName)
	{
		var itemPrefab = (
			from d in GameManager.instance.itemDataList
			where d.itemName == prefabName
			select d).ToList();

		foreach (var item in itemPrefab) {
			itemController.SetValue (item);
		}
	}
}
