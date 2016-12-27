using System.Collections;
using UnityEngine;

public class ConnectionTest : MonoBehaviour {

	string url = "http://cdn-www.dailypuppy.com/media/dogs/anonymous/coffee_poodle01.jpg_w450.jpg";

	// Use this for initialization
	void Start () {
		StartCoroutine (Connect ());
	}

	// Update is called once per frame
	void Update () {

	}

	private IEnumerator Connect(){
		var www = new WWW (url);
		yield return www;
		GetComponent<Renderer> ().material.mainTexture = www.texture;
	}
}
