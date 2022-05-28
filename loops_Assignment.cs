using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loops_Assignment : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {

        // for(int i= -5;i<=5;i++)
        // {
        //     print(i);
        // }
        
        // for(int i=10;i<=50;i++){
            
        //     if(i%2==0)
        //     {
        //         print(i);
        //     }
        //     // else
        //     // {
        //     //     print(i + " is a odd number");
        //     // }
        // }
        for(int i=1;i<=100;i=i+1)
        {
            if(i%5==0 && i % 3 == 0) 
            {
                print(i);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
