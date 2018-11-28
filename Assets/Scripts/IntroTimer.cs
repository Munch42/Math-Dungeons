using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroTimer : MonoBehaviour {

    public GameObject nacLogo;

    private int timer = 240;

	// Use this for initialization
	void Start () {
        nacLogo.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
		if(timer > 0)
        {
            timer--;
        }
        else if (timer <= 0)
        {
            nacLogo.SetActive(false);
            SceneManager.LoadScene("TitleScreen", LoadSceneMode.Single);
        }
	}
}
