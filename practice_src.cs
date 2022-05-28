using System.Data;
using System.Reflection;
using System.Net.Http;
using System.Xml.Serialization;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.Metadata;
using System.Buffers;
using System.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class practice_src : MonoBehaviour
{
    int [] arr = {5,10,2};
    int sum;
    string [] arr1 = {"hello","my","name","is","Devraaj"};


    // Start is called before the first frame update
    void Start()
    {
        // for(int i=0;i<=arr.Length-1;i++)
        // {
        //     sum = sum + arr[i] ;
        // }
        // print("The sum of all array elements is :"+sum);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int sumArray (int[]arr){
        int sum =0;
        for(int i=0;i<=arr.Length-1;i++)
        {
            //sum = sum + arr[i] ;
            sum +=arr[i];
        }
        return sum;
    }

    void printRev (string[] arr){

        for(int i=arr.Length-1; i>=0 ; i--)
        {
            print(arr[i]);
        }

    }

    int max (int[]arr)
    {
        int max = arr[0];

        for(int i =1;i<arr.Length;i++)
        {
            if(arr[i]>max)
            {
            max = arr[i];
            }
        }

        return max;
    }

    bool IsUniform (string[]arr)
    {
        bool result = true;

        for(int i=0;i<arr.Length;i++)
        {
            if(arr[0] != arr[i])
            {
                result = false;
            }
        }

        return result;
    }
}
