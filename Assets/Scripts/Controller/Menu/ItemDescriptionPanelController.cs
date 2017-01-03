using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ItemDescriptionPanelController : MonoBehaviour {
	public Image ItemImageField;
	public Text priceField;
	public Text itemNameField;
	public Text creatorNameField;
	public Text commentField;
	public Text likeCountField;

	private ItemData itemData;

	public void SetDescription(ItemData data)
	{
		itemData = data;
		priceField.text = data.price + "円(税込み)";
		itemNameField.text = data.itemName;
		creatorNameField.text = data.creatorName;
		likeCountField.text = data.likeCount + "";
		commentField.text = data.comment;

//		ItemImageField = data.ima
	}
}
