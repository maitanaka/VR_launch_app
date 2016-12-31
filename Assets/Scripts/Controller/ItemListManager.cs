using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Collections;

public class ItemListManager : MonoBehaviour {

	//ItemList内コンテンツオブジェクト
	[SerializeField]
	private GameObject _itemListContent = null;

	//ItemNodeオブジェクト
	[SerializeField]
	private GameObject _itemNode = null;


	//ItemNode内オブジェクト
	private Image _itemImage = null;
	private Text _itemName = null;

	//Contents内オブジェクト
	private Image _userItemImage = null;
	private Text _brandName = null;
	private Text _userItemName = null;
	private Text _itemPrice = null;
	private Text _itemComment = null;

	//アイテムマスタStruct
	private struct ItemListMaster
	{
		public int itemId;
		public Image Image;
		public string brandName;
		public string Name;
		public int Price;
		public string Comment;
	}

	//アイテムマスタリスト
	private List<ItemListMaster> _itemListMst = new List<ItemListMaster>();


	private void DebugDataLoad()
	{
		//ItemMasterデータロード
		_itemListMst.Clear();
		for (int itemMstCnt = 0; itemMstCnt < 50; itemMstCnt++) 
		{
			ItemListMaster itemMstData = new ItemListMaster ();
			itemMstData.itemId = itemMstCnt;
			itemMstData.brandName = "テストアイテム" + itemMstCnt;
			itemMstData.Name = "テストを行うアイテム" + itemMstCnt;
			itemMstData.Price = itemMstCnt * 20;
			itemMstData.Comment = "ヽ(=´▽`=)ﾉ";

			_itemListMst.Add (itemMstData);
		}
			
	}
	//


	// Use this for initialization
	void Start ()
	{
		DebugDataLoad ();
	}
}
