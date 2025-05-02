using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio7 : MonoBehaviour
{
    public int partenza = 2;
    void Stampa2Precedenti()
    {
        Debug.Log(partenza);
        Debug.Log(partenza - 1);
        Debug.Log(partenza - 2);
    }

    // Start is called before the first frame update
    void Start()
    {
        Stampa2Precedenti();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
