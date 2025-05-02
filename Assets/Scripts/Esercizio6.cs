using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio6 : MonoBehaviour
{
    public int partenza = 0;
    void Stampa2Successivi()
    {
        Debug.Log(partenza);
        Debug.Log(partenza + 1);
        Debug.Log(partenza + 2);
    }

    // Start is called before the first frame update
    void Start()
    {
        Stampa2Successivi();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
