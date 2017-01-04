using UnityEngine;
using UnityEngine.UI;

public class CategorySelectCellController : MonoBehaviour {
	public Const.ItemCategory category;
	private Button categorySelectButton;

	public void PushButton()
	{
		FurnituresListPopUpController.instance.SetItemList (category);
	}

	// Use this for initialization
	void Start () {
		categorySelectButton = GetComponent<Button> ();
		categorySelectButton.onClick.AddListener (PushButton);
	}
}
