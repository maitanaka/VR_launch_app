using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneChangeController {
	public Const.SceneName sceneName;

	public void toSelectedScene (Const.SceneName name) {
//		sceneName = Const.SceneName.Create;
		SceneManager.LoadScene (name.ToString());
	}
}
