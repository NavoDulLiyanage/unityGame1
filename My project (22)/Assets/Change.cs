using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Change : MonoBehaviour

{
    public static int value1;
    public static int value2;
    public static int value3;
    public static int value4;
    public static int value5;
    public static int random2;
    public Text firstnum;
    public Text secondnum;
    public Text evaluate;
    public Text sign;
    public Text answer;
    public Button button1;                    //used to attach Unity button component to script
    public Button button2;
    public Button button3;
    public Button button4;

    // Start is called before the first frame update
    void Start()
    {
        RandQuest();
    }

    // Update is called once per frame
    void Update()
    {

    }

 


public void RandQuest()
    {
        int firstDigit = Random.Range(0, 10);
        int secondDigit = Random.Range(0, 10);
        // Get a reference to the text component
        firstnum.text = firstDigit.ToString();
        secondnum.text = secondDigit.ToString();
        random2 = Random.Range(0, 4);
        answer.text = (firstDigit + secondDigit).ToString();
        value1 = Random.Range(0, 101);            //give random values for question and answers
        value2 = Random.Range(0, 101);
        value3 = secondDigit + firstDigit;
        value4 = Random.Range(0, 201);
        value5 = Random.Range(0, 201);
        button1.GetComponentInChildren<Text>().text = value1.ToString();    //used to display random values in the text
        button2.GetComponentInChildren<Text>().text = value2.ToString();     //attached to a button
        button3.GetComponentInChildren<Text>().text = value5.ToString();
        button4.GetComponentInChildren<Text>().text = value4.ToString();
        switch (random2)                                                                //randomise which button answer attached
        {
            case 0:
                button1.GetComponentInChildren<Text>().text = value3.ToString();
                
                break;
            case 1:
                button2.GetComponentInChildren<Text>().text = value3.ToString();
                break;
            case 2:
                button3.GetComponentInChildren<Text>().text = value3.ToString();
                break;
            case 3:
                button4.GetComponentInChildren<Text>().text = value3.ToString();
                break;
        }

        button1.onClick.AddListener(CheckAnswer1);
        button2.onClick.AddListener(CheckAnswer2);
        button3.onClick.AddListener(CheckAnswer3);
        button4.onClick.AddListener(CheckAnswer4);
    }
    public void CheckAnswer1()
    {
        if (button1.GetComponentInChildren<Text>().text == value3.ToString())
        {
             
            evaluate.text = "yay";
    
        }
        else
        {
            evaluate.text = "boo";
        }
    }
    public void CheckAnswer3()
    {
        if (button3.GetComponentInChildren<Text>().text == value3.ToString())
        {

            evaluate.text = "yay";

        }
        else
        {
            evaluate.text = "boo";
        }
    }
    public void CheckAnswer2()
    {
        if (button2.GetComponentInChildren<Text>().text == value3.ToString())
        {

            evaluate.text = "yay";

        }
        else
        {
            evaluate.text = "boo";
        }
    }
    public void CheckAnswer4()
    {
        if (button4.GetComponentInChildren<Text>().text == value3.ToString())
        {

            evaluate.text = "yay";

        }
        else
        {
            evaluate.text = "boo";
        }
    }

    public void GenNewQ()
    {
        RandQuest();
    }
}