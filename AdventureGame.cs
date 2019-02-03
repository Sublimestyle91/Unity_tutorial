using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  // makes it possible to use the class TEXT. We have to go to this namespace


public class AdventureGame : MonoBehaviour
{
    // Variables
    [SerializeField] Text textComponent;                // don't capitalize the variable name. The value of this is set by dragging in the textbox to it
    [SerializeField] State startingState;               // The SerializeField makes this variable visible in the inspector


    // classes
    State state;   // This will change with each new state. That is why we have two State variables

    // Start is called before the first frame update
    void Start()
    {
        state = startingState;
        textComponent.text = state.GetStateStory();
    }

    // Update is called once per frame
    void Update()
    {
        ManageNewState();
    }

    private void ManageNewState()
    {
        var nextState = state.GetNextState();
        for(int i = 0; i < nextState.Length; i ++ )
        {
            if(Input.GetKeyDown(KeyCode.Alpha1 + i))     // If a number is pressed, it goes signals true
            {
                state = nextState[i];
                textComponent.text = state.GetStateStory();
            }
        }
        
    }
}







 /* In GameOject, there is now a new area where we put startingoject in the inspector.
  * This is because of the SerializeField State... variable. The starting object was the 
 * scriptable object that was placed in this serializefield. We then set the state equal
 * to the starting state. We then used a method to get the variable in the starting state
 * that held the text. This variale went to the screen 
 * which is the variale 
 * textComponent.text
 */