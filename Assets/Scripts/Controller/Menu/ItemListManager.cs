using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Collections;

public class ItemListManager : MonoBehaviour {
	public ItemData itemData;

	public void ChangeDetail(){
		
	}
//
//	//ItemList内コンテンツオブジェクト
//	[SerializeField]
//	private GameObject _itemListContent = null;
//
//	//ItemNodeオブジェクト
//	[SerializeField]
//	private GameObject _itemNode = null;
//
//
//	//ItemNode内オブジェクト
//	private Image _itemImage = null;
//	private Text _itemName = null;
//
//	//Contents内オブジェクト
//	private Image _userItemImage = null;
//	private Text _itemDetail = null;
//
//	private ButtonController buttonController;
//
//	//アイテムマスタStruct
//	private struct ItemListMaster
//	{
//		public int itemId;
//		public Image Image;
//		public string brandName;
//		public string name;
//		public int Price;
//		public string Comment;
//	}
//
//	private struct Details
//	{
//		public int itemId;
//		public string ItemName;
//		public Image image;
//	}
//
//	//アイテムマスタリスト
//	private List<ItemListMaster> _itemListMst = new List<ItemListMaster>();
//
//	//
//	private List<Details> _itemData = new List<Details>();
//
//	private bool _isLoad = false;
//
//
//	private void DebugDataLoad()
//	{
//		//ItemMasterデータロード
//		_itemListMst.Clear();
//		for (int itemMstCnt = 0; itemMstCnt < 50; itemMstCnt++) 
//		{
//			ItemListMaster itemMstData = new ItemListMaster ();
//			itemMstData.itemId = itemMstCnt;
//			itemMstData.brandName = "テストアイテム" + itemMstCnt;
//			itemMstData.name = "テストを行うアイテム" + itemMstCnt;
//			itemMstData.Price = itemMstCnt * 20;
//			itemMstData.Comment = "ヽ(=´▽`=)ﾉ";
//
//			_itemListMst.Add (itemMstData);
//		}
//
//		_itemData.Clear ();
//		for (int itemCnt = 0; itemCnt < 50; itemCnt++) 
//		{
//			if (itemCnt % 3 != 0) 
//			{
//				Details details = new Details ();
//				details.itemId = itemCnt;
//				details.ItemName = "aaaa";
//
//				_itemData.Add (details);
//			}
//		}
//			
//	}
//	//
//
//
//	// Use this for initialization
//	void Start ()
//	{
//		DebugDataLoad ();
//
//		_itemImage = _itemNode.transform.FindChild ("ItemImage").GetComponent<Image> ();
//		_itemName = _itemNode.transform.FindChild ("ItemName").GetComponent<Text> ();
//
//		_userItemImage = transform.FindChild ("ItemInfo/DetailedItemImage").GetComponent<Image> ();
//		_itemDetail = transform.FindChild ("ItemInfo/InfoText/BrandName").GetComponent<Text> ();
//
//		CreateItemList ();
//
//	}
//
//	private void CreateItemList()
//	{
//		bool isFirst = true;
//
//		if (!_isLoad) 
//		{
//			foreach (Details Details in _itemData) {
//				ItemListMaster itemData = _itemListMst.Find (local => local.itemId == Details.itemId);
//				if (itemData.itemId != null) 
//				{
//					_itemName.text = itemData.name;
//
//					if (isFirst) 
//					{
//						_userItemImage = itemData.Image;
//						_itemDetail.text = Details.ItemName;
//						isFirst = false;
//					}
//
//					Button node = buttonController.SetChild (_itemListContent, _itemNode).GetComponent<Button> ();
//
//					ItemListMaster data = itemData;
//					node.onClick.AddListener (() => ItemSetting (data));
//				}
//			}
//		}
//	}
//
//	private void ItemSetting(ItemListMaster data)
//	{
//		_itemDetail.text = data.brandName;
//	}
}