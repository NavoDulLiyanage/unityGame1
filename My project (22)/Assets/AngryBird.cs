using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AngryBird : MonoBehaviour

{
    public static int value1;
    public static int value2;
    public static int value3;
    public static int value4;
    public static int value5;
    public static int random2;
    public Text evaluate;
    public Button button1x;                    //used to attach Unity button component to script
    public Button button2x;
    public Button button3x;
    public Button button4x;

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
        // Get a re 
        value1 = 1;       //give random values for question and answers
        value2 = 2;
        value3 = 3;
        value4 = 6;
        value5 = 5;
        button1x.GetComponentInChildren<Text>().text = value1.ToString();    //used to display random values in the text
        button2x.GetComponentInChildren<Text>().text = value2.ToString();     //attached to a button
        button3x.GetComponentInChildren<Text>().text = value3.ToString();
        button4x.GetComponentInChildren<Text>().text = value4.ToString();
        
        

        button1x.onClick.AddListener(CheckAnswer1);
        button2x.onClick.AddListener(CheckAnswer1);
        button3x.onClick.AddListener(CheckAnswer2);
        button4x.onClick.AddListener(CheckAnswer1);
    }
    public void CheckAnswer1()
    {
         
            evaluate.text = "your answer is wrong, dear..the correct answer is 3";

        
           
    }
    public void CheckAnswer2()
    {
       
            evaluate.text = "wow!!you won";
        }
    }
    
    
