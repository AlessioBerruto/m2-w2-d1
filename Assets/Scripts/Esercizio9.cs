using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio9 : MonoBehaviour
{
    public int a = 2;
    public int b = 3;

    void MinoreTra2()
    {
        if (a < b)
        {
            Debug.Log(a);
        }
        else
        {
            Debug.Log(b);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        MinoreTra2 ();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
