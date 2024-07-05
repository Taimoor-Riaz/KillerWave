using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleClass : MonoBehaviour
{
    public static ExampleClass instance;

    public int a;
    private void Awake()
    {
        a = 30;
        instance = this;
    }

    public void DisplayA()
    {
        Debug.Log(a);
    }
}
