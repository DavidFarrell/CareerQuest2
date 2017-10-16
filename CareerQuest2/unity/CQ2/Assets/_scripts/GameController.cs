using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

	public GameObject[] panelList;

	public GameObject splashPanel;
	public GameObject homePanel;


	public GameObject gameOverPanel;
	public Text gameOverText;
	public GameObject restartButton;


	public void Awake() {
		HideScreens (splashPanel);
	}

	public void HideScreens(GameObject activeScreen = null){ 
		for (int i = 0; i < panelList.Length; i++) {
			if ( panelList[i].Equals(activeScreen) ) {
				panelList[i].SetActive(true);
			} else {
				panelList[i].SetActive (false);
			}
		}
	}

	public void handleInput( GameObject referer ) {
		if (referer.Equals (splashPanel)) {
			HideScreens (homePanel);
		}
	}
}
