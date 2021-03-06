using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
        int max;
        int min;
        int guess;

    void Start()
    {
        StartGame();
    }


    void Update()
    {
        //Unity docs Player Input - KeyCode
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();
        }

        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
        }

        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("You number am: " + guess);   
            Debug.Log("You start game again!");   
            StartGame();         
        }
    }
    
    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;

        Debug.Log("You play Number Wizard now!");
        Debug.Log("Pick number, don't tell number...");
        Debug.Log("Most big number you pick am: " + max);
        Debug.Log("Most small number you pick am: " + min);
        Debug.Log("Tell if number more big or more small am: " + guess);
        Debug.Log("Push Up = More big, Push Down = More small, Push Enter = Yes number");

        max = max + 1;
    }

    void NextGuess()
    {
            guess = (max + min) / 2;
            Debug.Log("You number more big or more small am: " + guess);
    }


}
