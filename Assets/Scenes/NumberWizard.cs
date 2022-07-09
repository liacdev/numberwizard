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
        Debug.Log("You play Number Wizard now!");
        Debug.Log("Pick number, don't tell number...");
        Debug.Log("Most big number you pick am: " + max);
        Debug.Log("Most small number you pick am: " + min);
        Debug.Log("Tell if number more big or more small am: " + guess);
        Debug.Log("Push Up = More big, Push Down = More small, Push Enter = Yes number");

        max = max + 1;
    }

    void Update()
    {
        //Unity docs Player Input - KeyCode
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            guess = (max + min) / 2;
            Debug.Log("You number more big or more small am: " + guess);
        }

        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            guess = (max + min) / 2;
            Debug.Log("You number more big or more small am: " + guess);
        }

        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("You number am: " + guess);            
        }
    }
}
