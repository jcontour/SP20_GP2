using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckMyTyping : MonoBehaviour
{

    string myString;
    string targetString = "JUMP";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnGUI()
    {
        Event e = Event.current;
        if (e.isKey && e.type == EventType.KeyDown && e.keyCode != KeyCode.None)
        {
            //Debug.Log(e.keyCode);
            myString += e.keyCode;
            Debug.Log(myString);

            for (int i = 0; i < myString.Length; i++)
            {
                if (myString[i] == targetString[i])
                {
                    Debug.Log("you're typing the word!");
                } else {
                    Debug.Log("learn 2 type");
                    myString = "";
                }
            }

            if (myString == targetString)
            {
                Debug.Log("you win!");
                myString = "";
            }
        }

        

    }
}
