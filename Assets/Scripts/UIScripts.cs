using  System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScripts : MonoBehaviour {

    //Coming Soon Text only until feature is complete
    public GameObject comingSoonGameobject;

    //Back Button
    public GameObject backButton;

    //Main Screen Buttons
    public GameObject attackButton;
    public GameObject petButton;
    public GameObject specialButton;
    public GameObject retreatButton;

    //Attack Buttons
    public GameObject attackButtons;

    // Use this for initialization
    void Start () {
		
	}

    public void OnAttackClick()
    {
        attackButton.SetActive(false);
        petButton.SetActive(false);
        specialButton.SetActive(false);
        retreatButton.SetActive(false);

        attackButtons.SetActive(true);
        backButton.SetActive(true);
    }

    public void OnSpecialClick()
    {
        attackButton.SetActive(false);
        petButton.SetActive(false);
        specialButton.SetActive(false);
        retreatButton.SetActive(false);

        comingSoonGameobject.SetActive(true);
        backButton.SetActive(true);
    }

    public void OnPetClick()
    {
        attackButton.SetActive(false);
        petButton.SetActive(false);
        specialButton.SetActive(false);
        retreatButton.SetActive(false);

        comingSoonGameobject.SetActive(true);
        backButton.SetActive(true);
    }

    public void OnRetreatClick()
    {
        attackButton.SetActive(false);
        petButton.SetActive(false);
        specialButton.SetActive(false);
        retreatButton.SetActive(false);

        comingSoonGameobject.SetActive(true);
        backButton.SetActive(true);
    }

    public void OnBackClick()
    {
        attackButton.SetActive(true);
        petButton.SetActive(true);
        specialButton.SetActive(true);
        retreatButton.SetActive(true);

        attackButtons.SetActive(false);
        comingSoonGameobject.SetActive(false);
        backButton.SetActive(false);
    }
}
