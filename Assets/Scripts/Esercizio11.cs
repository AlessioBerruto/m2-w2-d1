using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio11 : MonoBehaviour
{
    public float Grade = 0f;
    private float lastGrade = -1f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Grade != lastGrade)
        {
            lastGrade = Grade;
            PrintGrade();
        }

    }

    void PrintGrade()
    {
        if (Grade >= 0.4f && Grade < 5f)
        {
            Debug.Log("Your Grade is F");
        }
        else if (Grade >= 5f && Grade < 6f)
        {
            Debug.Log("Your Grade is E");
        }
        else if (Grade >= 6f && Grade < 7.8f)
        {
            Debug.Log("Your Grade is C");
        }
        else if (Grade >= 7.8f && Grade < 9f)
        {
            Debug.Log("Your Grade is B");
        }
        else if (Grade >= 9f && Grade < 10f)
        {
            Debug.Log("Your Grade is A");
        }
        else if (Grade == 10f)
        {
            Debug.Log("Your Grade is A+");
        } 
    }
}
