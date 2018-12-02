using  System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScripts : MonoBehaviour {

    //Coming Soon Text only until feature is complete
    public GameObject comingSoonGameobject;

    //Back Button
    public GameObject backButton;

    //Main Options Text
    public GameObject mainScreenText;

    //Main Screen Buttons
    public GameObject attackButton;
    public GameObject petButton;
    public GameObject specialButton;
    public GameObject retreatButton;

    //Attack Buttons
    public GameObject attackButtons;

    //Multiple Choice Buttons and Text
    public GameObject MultipleChoiceButtons;

    public Text choice1;
    public Text choice2;
    public Text choice3;
    public Text choice4;

    //Question Text
    public Text questionText;

    public GameObject questionGameobject;

    //Math Question
    private int mathQuestionNumber;
    
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

    public void OnMultipleChoiceClick()
    {
        MultipleChoice();
        attackButtons.SetActive(false);
        mainScreenText.SetActive(false);

        backButton.SetActive(true);
        MultipleChoiceButtons.SetActive(true);
        questionGameobject.SetActive(true);
    }

    public void OnShortAnswerClick()
    {
        attackButtons.SetActive(false);
        mainScreenText.SetActive(false);

        backButton.SetActive(true);
        questionGameobject.SetActive(true);
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
        mainScreenText.SetActive(true);

        attackButtons.SetActive(false);
        comingSoonGameobject.SetActive(false);
        backButton.SetActive(false);
        MultipleChoiceButtons.SetActive(false);
        questionGameobject.SetActive(false);
    }

    public void MultipleChoice()
    {
        int firstNumber;
        int secondNumber;

        mathQuestionNumber = Random.Range(1,31);

        for (int i = 0; i < mathQuestionNumber; i++)
        {
            if (i == mathQuestionNumber)
            {
                
            }
            else return;
        }
    }
}
