using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    public Animation playerInjured;
    public Animation monsterInjured;
    public Text monsterInjureText;
    public Text playerInjureText;

    private int monsterDamageDealt;
    private int playerDamageDealt;

    // Use this for initialization
    void Start () {
        playerInjureText.text = "";
        monsterInjureText.text = "";
    }
	
	// Update is called once per frame
	void Update () {
        /*
        if (Input.GetKeyDown(KeyCode.A))
        {
            playerInjured.Play();
            monsterInjured.Play();
            playerInjureText.text = "155155";
            monsterInjureText.text = "155555";
        }
        */
	}
}
