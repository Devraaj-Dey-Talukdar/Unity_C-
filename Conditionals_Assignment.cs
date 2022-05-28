using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditionals_Assignment : MonoBehaviour
{

    public int number1;
    public int number2;
    [Range(0, 100)]
    public int score;
    // Start is called before the first frame update
    void Start()
    {

        if(number1 > number2){
            print(number1+" is greater than "+number2);
        }
        else{
            print(number2+" is greater than "+number1);
        }

        if(score>=90 && score<=100)
        {
            print("Grade A");
            print("Your student have done preety well");
        }
        else if(score>=80 && score<90)
        {
            print("Grade B");
            print("Better but it can be good");
        }
        else if(score>=70 && score<80)
        {
            print("Grade C");
            print("He/she has the potential but is not utilising it.");
        }
        else if(score>=65 && score<70)
        {
            print("Grade D");
            print("Stop wasting your time playing video games focus on study");
        }
        else if(score>100)
        {
            print("Damn bitch! How can your student score more than hundred");
        }
        else{
            print("Grade E");
            print("Bitch! Stop trying to impress girls all day try to open the book and study ");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
