using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables_Assignment : MonoBehaviour
{
    public string firstName = "Devraaj";
    public string lastName = "Talukdar";
    public int birthYear = 2006;
    // Start is called before the first frame update
    void Start()
    {
       print("Your name is "+ firstName+" "+lastName);

       print("Your initials are "+ firstName[0]+" "+lastName[0]);

       print("Your name length is "+(firstName+lastName).Length);

       int randomNumber = Random.Range(0, firstName.Length);
       print("Random alphabet from your first name is : " + firstName[randomNumber]);

       int age = 2022 - birthYear;
       print("Your were born in the year "+ birthYear +" that means you are "+ age +" old.");

       print("You have been alive for :"+(365+4)*16 +" days");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
