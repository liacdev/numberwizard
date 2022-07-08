using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int max = 1000;
        int min = 1;
      //TODO: int myNumber;

        Debug.Log("Welcome to Number Wizard, yo");
        Debug.Log("Pick a number, don't tell me what it is...");
        Debug.Log("The highest number you may choose is: " + max);
        Debug.Log("The lowest number you may choose is: " + min);

       // Debug.Log("Tell me if your number is higher or lower than " + myNumber);
        Debug.Log("Push Up = Higher, Push Down = Lower, Push Return or Enter = Correct");
    }

    // Update is called once per frame
    void Update()
    {
        //If the player pushes a certain key, we want to display a certain message
        //Unity docs Player Input - KeyCode
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Up arrow key pressed");
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Down arrow key pressed");
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Enter key pressed");
        }
    }
}
