using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio8 : MonoBehaviour
{
    public int a = 5;
    public int b = 4;

    void MaggioreTra2()
    {
        if (a > b)
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
        MaggioreTra2();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
