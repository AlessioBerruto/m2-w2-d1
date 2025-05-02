using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio5 : MonoBehaviour
{
    public int a = 7;
    private string Frase;

    // Start is called before the first frame update
    void Start()
    {
        if (a % 2 == 0)
        {
            Frase = "a   pari";
        }
        else
        {
            Frase = "a   dispari";
        }

        if (a > 10)
        {
            Frase = Frase + " e a   maggiore di 10";
        }
        else
        {
            Frase += " e a   minore di 10";
        }

        Debug.Log(Frase);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
