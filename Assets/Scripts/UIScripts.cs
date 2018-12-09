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

    //Question Array
    private string[] questions;

    //Other String Things
    private string prefix = "What is ";
    private string suffix = "?";

    //Declarations Outside of Methods
    int rightChoiceButton;

    //Wrong And Right Answer Animations
    public Animation incorrectAnimation;
    public Animation correctAnimation;

    public GameObject incorrectGamobject;
    public GameObject correctGameobject;

    public AudioSource wrongSound;
    public AudioSource correctSound;

    //Player Controller Reference
    public GameObject playerController;

    // Use this for initialization
    void Start ()
    {
        questions = new string[30];
        incorrectGamobject.SetActive(false);
        correctGameobject.SetActive(false);
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
        incorrectGamobject.SetActive(false);
        correctGameobject.SetActive(false);
    }

    public void MultipleChoice()
    {
        string[] operators = new string[4];
        operators[0] = " + ";
        operators[1] = " - ";
        operators[2] = " * ";
        operators[3] = " / ";
        int firstNumber = Random.Range(-50,101);
        int secondNumber = Random.Range(-50, 101);
        int operatorNumber = Random.Range(0, 4);

        rightChoiceButton = Random.Range(1,5);
        int choice1Num = 0;
        int choice2Num = 0;
        int choice3Num = 0;
        int choice4Num = 0;

        questions[0] = prefix + firstNumber + operators[operatorNumber] + secondNumber + suffix;

        if(rightChoiceButton == 1)
        {
            if(operatorNumber == 0)
            {
                choice1Num = firstNumber + secondNumber;
                choice2Num = choice1Num + Random.Range(-20, 20);
                choice3Num = choice1Num - Random.Range(-20, 20);
                choice4Num = choice1Num * Random.Range(-20, 20);
            }
            else if (operatorNumber == 1)
            {
                choice1Num = firstNumber - secondNumber;
                choice2Num = choice1Num + Random.Range(-20, 20);
                choice3Num = choice1Num - Random.Range(-20, 20);
                choice4Num = choice1Num * Random.Range(-20, 20);
            }
            else if (operatorNumber == 2)
            {
                choice1Num = firstNumber * secondNumber;
                choice2Num = choice1Num + Random.Range(-20, 20);
                choice3Num = choice1Num - Random.Range(-20, 20);
                choice4Num = choice1Num * Random.Range(-20, 20);
            }
            else if (operatorNumber == 3)
            {
                choice1Num = firstNumber / secondNumber;
                choice2Num = choice1Num + Random.Range(-20, 20);
                choice3Num = choice1Num - Random.Range(-20, 20);
                choice4Num = choice1Num * Random.Range(-20, 20);
            }
            choice1.text = choice1Num.ToString();
            choice2.text = choice2Num.ToString();
            choice3.text = choice3Num.ToString();
            choice4.text = choice4Num.ToString();
        }
        else if(rightChoiceButton == 2)
        {
            if (operatorNumber == 0)
            {
                choice2Num = firstNumber + secondNumber;
                choice1Num = choice2Num + Random.Range(-20, 20);
                choice3Num = choice2Num - Random.Range(-20, 20);
                choice4Num = choice2Num * Random.Range(-20, 20);
            }
            else if (operatorNumber == 1)
            {
                choice2Num = firstNumber - secondNumber;
                choice1Num = choice2Num + Random.Range(-20, 20);
                choice3Num = choice2Num - Random.Range(-20, 20);
                choice4Num = choice2Num * Random.Range(-20, 20);
            }
            else if (operatorNumber == 2)
            {
                choice2Num = firstNumber * secondNumber;
                choice1Num = choice2Num + Random.Range(-20, 20);
                choice3Num = choice2Num - Random.Range(-20, 20);
                choice4Num = choice2Num * Random.Range(-20, 20);
            }
            else if (operatorNumber == 3)
            {
                choice2Num = firstNumber / secondNumber;
                choice1Num = choice2Num + Random.Range(-20, 20);
                choice3Num = choice2Num - Random.Range(-20, 20);
                choice4Num = choice2Num * Random.Range(-20, 20);
            }
            choice1.text = choice1Num.ToString();
            choice2.text = choice2Num.ToString();
            choice3.text = choice3Num.ToString();
            choice4.text = choice4Num.ToString();
        }
        else if (rightChoiceButton == 3)
        {
            if (operatorNumber == 0)
            {
                choice3Num = firstNumber + secondNumber;
                choice1Num = choice3Num + Random.Range(-20, 20);
                choice2Num = choice3Num - Random.Range(-20, 20);
                choice4Num = choice3Num * Random.Range(-20, 20);
            }
            else if (operatorNumber == 1)
            {
                choice3Num = firstNumber - secondNumber;
                choice1Num = choice3Num + Random.Range(-20, 20);
                choice2Num = choice3Num - Random.Range(-20, 20);
                choice4Num = choice3Num * Random.Range(-20, 20);
            }
            else if (operatorNumber == 2)
            {
                choice3Num = firstNumber * secondNumber;
                choice1Num = choice3Num + Random.Range(-20, 20);
                choice2Num = choice3Num - Random.Range(-20, 20);
                choice4Num = choice3Num * Random.Range(-20, 20);
            }
            else if (operatorNumber == 3)
            {
                choice3Num = firstNumber / secondNumber;
                choice1Num = choice3Num + Random.Range(-20, 20);
                choice2Num = choice3Num - Random.Range(-20, 20);
                choice4Num = choice3Num * Random.Range(-20, 20);
            }
            choice1.text = choice1Num.ToString();
            choice2.text = choice2Num.ToString();
            choice3.text = choice3Num.ToString();
            choice4.text = choice4Num.ToString();
        }
        else if (rightChoiceButton == 4)
        {
            if (operatorNumber == 0)
            {
                choice4Num = firstNumber + secondNumber;
                choice1Num = choice4Num + Random.Range(-20, 20);
                choice2Num = choice4Num - Random.Range(-20, 20);
                choice3Num = choice4Num * Random.Range(-20, 20);
            }
            else if (operatorNumber == 1)
            {
                choice4Num = firstNumber - secondNumber;
                choice1Num = choice4Num + Random.Range(-20, 20);
                choice2Num = choice4Num - Random.Range(-20, 20);
                choice3Num = choice4Num * Random.Range(-20, 20);
            }
            else if (operatorNumber == 2)
            {
                choice4Num = firstNumber * secondNumber;
                choice1Num = choice4Num + Random.Range(-20, 20);
                choice2Num = choice4Num - Random.Range(-20, 20);
                choice3Num = choice4Num * Random.Range(-20, 20);
            }
            else if (operatorNumber == 3)
            {
                choice4Num = firstNumber / secondNumber;
                choice1Num = choice4Num + Random.Range(-20, 20);
                choice2Num = choice4Num - Random.Range(-20, 20);
                choice3Num = choice4Num * Random.Range(-20, 20);
            }
            choice1.text = choice1Num.ToString();
            choice2.text = choice2Num.ToString();
            choice3.text = choice3Num.ToString();
            choice4.text = choice4Num.ToString();
        }

        //mathQuestionNumber = Random.Range(0,31);
        mathQuestionNumber = 0;

        for (int i = 0; i <= mathQuestionNumber; i++)
        {
            if (i == mathQuestionNumber)
            {
                questionText.text = questions[i];
            }
        }
    }

    public void Button1Pressed()
    {
        if(rightChoiceButton == 1)
        {
            Debug.Log("Correct");
            correctAnimation.Play();
            correctGameobject.SetActive(true);
            correctSound.Play();
            DamageMonster();
        }
        else
        {
            Debug.Log("Wrong Answer");
            incorrectAnimation.Play();
            incorrectGamobject.SetActive(true);
            wrongSound.Play();
        }
    }

    public void Button2Pressed()
    {
        if (rightChoiceButton == 2)
        {
            Debug.Log("Correct");
            correctAnimation.Play();
            correctGameobject.SetActive(true);
            correctSound.Play();
            DamageMonster();
        }
        else
        {
            Debug.Log("Wrong Answer");
            incorrectAnimation.Play();
            incorrectGamobject.SetActive(true);
            wrongSound.Play();
        }
    }

    public void Button3Pressed()
    {
        if (rightChoiceButton == 3)
        {
            Debug.Log("Correct");
            correctAnimation.Play();
            correctGameobject.SetActive(true);
            correctSound.Play();
            DamageMonster();
        }
        else
        {
            Debug.Log("Wrong Answer");
            incorrectAnimation.Play();
            incorrectGamobject.SetActive(true);
            wrongSound.Play();
        }
    }

    public void Button4Pressed()
    {
        if (rightChoiceButton == 4)
        {
            Debug.Log("Correct");
            correctAnimation.Play();
            correctGameobject.SetActive(true);
            correctSound.Play();
            DamageMonster();
        }
        else
        {
            Debug.Log("Wrong Answer");

            incorrectAnimation.Play();
            incorrectGamobject.SetActive(true);
            wrongSound.Play();
        }
    }

    public void DamageMonster()
    {
        int damageDone = Random.Range(1, 51);
        playerController.GetComponent<PlayerController>().OnMonsterInjure(damageDone);
    }

}
