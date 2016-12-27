using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class RayControl : MonoBehaviour {
	private SceneChangeController sceneChange = new SceneChangeController();
	private Const.SceneName sceneName;
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit = new RaycastHit ();

			if (Physics.Raycast (ray, out hit)) {
				var button = hit.transform.GetComponent<SceneChangeButtonController>();
				sceneChange.toSelectedScene (button.scene);
			}
		}
	}
}

