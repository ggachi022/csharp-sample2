using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StringSearch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string greeting = "Good Morning";
        Debug.Log(greeting);

        //IndexOf()
        Debug.Log($"IndexOf: 'Good' : { greeting.IndexOf("Good")}");
        Debug.Log($"IndexOf: 'o' : { greeting.IndexOf('o')}");

        //LastIndexOf()
        Debug.Log($"LastIndexOf 'Good' : { greeting.IndexOf("Good")}");
        Debug.Log($"LastIndexOf 'g' : { greeting.IndexOf("g")}");

        //StartWith()
        Debug.Log($"StartWith 'Good' : { greeting.IndexOf("Good")}");
        Debug.Log($"StartWith 'Morning' : { greeting.IndexOf("Morning")}");

        //EndWith()
        Debug.Log($"EndWith 'Good' : { greeting.EndsWith("Good")}");
        Debug.Log($"EndWith 'Morning' : { greeting.EndsWith("Morning")}");

        //Contains()
        Debug.Log($"Contains 'Evening' : {greeting.Contains("Evening")}");
        Debug.Log($"Contains 'Morning' : {greeting.Contains("Morning")}");

        //Replace
        Debug.Log($"Replaced 'Moring' with 'Evening' : { greeting.Replace("Morning","Evening")}");

    }





}
