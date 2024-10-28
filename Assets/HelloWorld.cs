using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {   int max = 1000;
        int min = 1;

        print("Develop By Pranto!");
        Debug.Log("Welcome to Number Wizard, yo!");//debug and print are same pretty much;
        Debug.Log("Pick a number in your head, and don't tell anyone!");
        Debug.Log($"the hightest number you can pick is : {max}");
        Debug.Log($"The lowest number you can pick is : {min}");
        Debug.Log("Think you want to say : ");
        Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow) ){
            Debug.Log("Up Arrow key was pressed.");
        }
        else if(Input.GetKeyDown(KeyCode.DownArrow) ){
            Debug.Log("Down Arrow key was pressed.");
        }
        else if(Input.GetKeyDown(KeyCode.Return)){
            Debug.Log("Enter Key Pressed.");
        }
    }
}
