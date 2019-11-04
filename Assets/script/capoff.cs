using System.Collections;
using System.Collections.Generic;
    
using UnityEngine;

public class Example : MonoBehaviour
{
    // Creates a Label and prints CapsLock on/off
    // depending on the state of the capslock key.
    void OnGUI()
    {
        Event e = Event.current;
        if (e.capsLock)
        {
            GUI.Label(new Rect(10, 10, 100, 20), "CapsLock on.");
        }
        else
        {
            GUI.Label(new Rect(10, 10, 100, 20), "CapsLock off.");
        }
    }
}