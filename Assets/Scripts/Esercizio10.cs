using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio10 : MonoBehaviour
{
    public float tempoTrascorso = 0;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        tempoTrascorso = tempoTrascorso + Time.deltaTime;

        if (tempoTrascorso < 30)
        {
            Debug.Log("sono trascorsi meno di 30 secondi");
        }
        else if (tempoTrascorso > 60)
        {
            Debug.Log("è trascorso più di un minuto");
        }
        else if (tempoTrascorso > 45)
        {
            Debug.Log("sono trascorsi più di 45 secondi");
        }
        else if (tempoTrascorso > 30)
        {
            Debug.Log("sono trascorsi più di 30 secondi");
        }
    }
}
