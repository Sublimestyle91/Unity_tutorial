using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]
/* This will create an asset that we can pick in the menu
 * The asset will be a scriptable object
 */
public class State : ScriptableObject 
    /* We originally had MonoBehaviour where Scriptable oject is
     * We did this so we can create a scriptable oject for our text files
     */
   
{
   [TextArea(10,14)] [SerializeField] string storyText; // serializefield puts this variable in the inspector. Makes a variale we can edit in inspector
   // TextArea makes the variale have a box. It will be 10 spaces big, and we will be able to scroll after 14
   [SerializeField] State[] nextStates;

    public string GetStateStory()  // These are just getter methods
    {
        return storyText;
    }
    public State[] GetNextState() // getter method to access variables
    {
        return nextStates;
    }
}
