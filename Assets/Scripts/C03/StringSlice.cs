using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StringSlice : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string greeting = "Good Morning";

        Debug.Log(greeting.Substring(0, 5));
        Debug.Log(greeting.Substring(5));

        string[] arr = greeting.Split(new string[] {" "}, System.StringSplitOptions.None);

        foreach (string element in arr)
            Debug.Log($"{element}");
    }


}
