using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Func_Assignment : MonoBehaviour
{
    bool is_Even = false;
    public int num;
    public float number1;
    public float number2;
    public string name;
    [Range(0,100)]
    public int numberOfTimeLoop;
    public int factorialNumber;
    // Start is called before the first frame update
    void Start()
    {

        isEven(num);
        whatIsBigger(number1,number2);
        repeat(name , numberOfTimeLoop);
        factorial(factorialNumber);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void isEven(int a)
    {
        if(a%2==0){
            is_Even = true;
            print(is_Even);
        }
        else if(a%2==1){
            is_Even = false;
            print(is_Even);
        }

    }

    // bool IsEven (int a)
    // {
    //     if(a%2 == 0)
    //     {
    //         return true;
    //     }
    //     else
    //     {
    //         return false;
    //     }
    // }

    void whatIsBigger(float a,float b)
    {
        if(a>b)
        {
            print(a + " is greater than number "+b);
        }
        else
        {
            print(b + " is greater than number "+a);
        }
    }

    // int whatIsBigger (float a, float b)
    // {
    //     if (number1 > number2)
    //     {
    //         return number1;
    //     }
    //     else 
    //     {
    //         return number2;
    //     }
    // }

    void repeat(string toPrint , int noOfTimes)
    {
        for(int i=0;i<noOfTimes;i++)
        {
            print(toPrint);
        }
    }



    int factorial (int number)
    {
        int result =1;

        for(int i=0; i<=number;i++)
        {
            result *= i;
        }
        return result;
    }
}
