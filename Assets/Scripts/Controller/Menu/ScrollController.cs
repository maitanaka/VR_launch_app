using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class ScrollController : MonoBehaviour {
	public Transform Contents;
	public Transform ItemInfoPanel;

	// Use this for initialization
	void Start () {
		ShowItems ();
	}

	public void ShowItems(){
		int num = 1;
		for (int i = 0; i < 13; i++) {
			GameObject prefab = (GameObject)Resources.Load ("FurnituresNodes/" + num.ToString ());
			GameObject q = Instantiate (prefab) as GameObject;
			q.transform.SetParent (Contents.transform, false);
			num += 1;
		}
	}
}
