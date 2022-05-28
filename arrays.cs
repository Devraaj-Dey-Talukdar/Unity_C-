using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrays : MonoBehaviour
{
    string [] playerNames = new string[5]
    {"Nick","Smith","Cheryl","Fred","Veronica"};
    // Start is called before the first frame update
    void Start()
    {
        arrayTrial();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void arrayTrial()
    {
        for(int i=0;i<playerNames.Length;i++)
        {
           print(playerNames[i]);
        }
    }
}
