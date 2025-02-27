using System;
using UnityEngine;

public class TitleScript : MonoBehaviour
{
    public float timeSinceStart = 0.0f;
    public GameObject titleText;
    public float expandTime = 1.0f;
    public float contratTime = 0.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timeSinceStart < expandTime + contratTime) 
        {
            timeSinceStart += Time.deltaTime;
            titleText.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f) * (float)Math.Pow((timeSinceStart), 2.0f);
            // other equation that can be used
            // titleText.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f) * ((2 / ((- timeSinceStart / expandTime) - 1.0f)) + 2.0f);
        }
        else if (timeSinceStart >= expandTime + contratTime && timeSinceStart < expandTime + 2.0f * contratTime)
        {
            timeSinceStart += Time.deltaTime;
            titleText.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f) * (float)Math.Pow(timeSinceStart - 2.0f * (expandTime + contratTime), 2.0f);
        }

    }
}
