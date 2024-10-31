using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{   
        int max, min, guess;
    
    // Start is called before the first frame update
    void Start()
    {   
        StartGame();
    }
    void StartGame(){
        max = 1000;
        min = 1;
        guess = 500;
        print("Develop By Pranto!");
        Debug.Log("Welcome to Number Wizard, yo!");//debug and print are same pretty much;
        Debug.Log("Pick a number in your head, and don't tell anyone!");
        Debug.Log($"the hightest number you can pick is : {max}");
        Debug.Log($"The lowest number you can pick is : {min}");
        Debug.Log("Think you want to say : ");
        Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct");
        max = max + 1;
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow) ){
            min = guess; // min  = 500;
            NextGuess();
        }
        else if(Input.GetKeyDown(KeyCode.DownArrow) ){
            max = guess;
            NextGuess();
        }
        else if(Input.GetKeyDown(KeyCode.Return)){
            Debug.Log("!!!!!!!!! YOU WIN !!!!!!!!!!");
            StartGame();
        }
    }
    void NextGuess(){
        guess = (max + min) / 2;
        Debug.Log("Is the number is higher or lower then..." + guess);
    }
}
