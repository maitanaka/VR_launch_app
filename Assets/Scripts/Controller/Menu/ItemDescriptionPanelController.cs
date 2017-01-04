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
	public string itemCategory;

	private ItemData itemData;

	public void SetDescription(ItemData data)
	{
		itemData = data;
		itemCategory = data.itemCategory + "";
		priceField.text = data.price + "円(税込み)";
		itemNameField.text = data.itemName;
		creatorNameField.text = data.creatorName;
		likeCountField.text = data.likeCount + "";
		commentField.text = data.comment;
		ItemImageField.sprite = Resources.Load<Sprite>("Images/Items/" + data.itemCategory.ToString () + "/" + data.itemName);
	}

}
