using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class NumberWizard : MonoBehaviour
{
    int min ;
    int max ;
    int guess;
    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame(){
        max = 1000;
        min = 1;
        guess = 500;
        max = max + 1;
        print ("============= Welcome to Number Wizard=============");
        print (" Pick a number in your head and do not tell me ");
        
        
        print (" The highest number you can pick :" + max);
        print (" The lowest number you can pick :" + min);
        
        print (" Is the numver higher or lowe than "+guess+"?");
        print (" Up arrow for higher down arrow for lower");

        print ("===================================================");
    
    }
    void NextGuess(){

        guess = ( max + min ) /2;
        print ("Higher or lower than " + guess);
        print ("Up arrow for higher and Low arrow for lower");


    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow)){
            min = guess; 
            NextGuess();            
        } else if(Input.GetKeyDown(KeyCode.DownArrow)){
            //print("down arrow pressed");
            max = guess;
            NextGuess();
        } else if(Input.GetKeyDown(KeyCode.Return)){
            print("I won!");
            StartGame();
        }         
    }
}
