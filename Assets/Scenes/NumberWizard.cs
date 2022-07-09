using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
        int max = 1000;
        int min = 1;
        int guess = 500;

    void Start()
    {
        Debug.Log("Welcome to Number Wizard, yo!");
        Debug.Log("Pick a number, don't tell me what it is...");
        Debug.Log("The highest number you may choose is: " + max);
        Debug.Log("The lowest number you may choose is: " + min);

        Debug.Log("Tell me if your number is higher or lower than mu number");
        Debug.Log("Push Up = Higher, Push Down = Lower, Push Return or Enter = Correct");
    }

    void Update()
    {
        //Unity docs Player Input - KeyCode
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Up arrow key pressed");
            min = guess;
            Debug.Log(guess);
        }

        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Down arrow key pressed");
            max = guess;
            Debug.Log(guess);
        }

        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Enter key pressed");
            
            Debug.Log(guess);
        }
    }
}
