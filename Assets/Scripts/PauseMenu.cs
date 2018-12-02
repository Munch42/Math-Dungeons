using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

    public GameObject pauseMenu;
    public bool isActive;

	// Use this for initialization
	void Start () {
        pauseMenu.SetActive(false);
        isActive = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape) && isActive == false)
        {
            pauseMenu.SetActive(true);
            isActive = true;
        }else if(Input.GetKeyDown(KeyCode.Escape) && isActive == true)
        {
            pauseMenu.SetActive(false);
            isActive = false;
        }
	}

    public void onResume()
    {
        pauseMenu.SetActive(false);
        isActive = false;
    }

    public void onQuit()
    {
        Application.Quit();
    }

    public void onQuitToMain()
    {
        SceneManager.LoadScene("TitleScreen", LoadSceneMode.Single);
    }
}
