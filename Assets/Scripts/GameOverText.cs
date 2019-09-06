using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class GameOverText : MonoBehaviour {

	public GameObject treasure;
	private Text text;

	// Use this for initialization
	void Start () {
		text = GetComponent<Text>();

		// start text off as completely transparent black
		text.color = new Color(0, 0, 0, 0);
	}

	// Update is called once per frame
	void Update () {
		if (treasure == null) {
			// reveal text only when helicopter is null (destroyed)
			text.color = new Color(0, 0, 0, 1);
			text.text = "You Won! Press enter to play again.";
			
			// jump is space bar by default
			if (Input.GetButtonDown("Jump")) {
				// reload entire scene, starting music over again, refreshing score, etc.
				SceneManager.LoadScene("ProBuilderScene");
			}
		}
	}
}
