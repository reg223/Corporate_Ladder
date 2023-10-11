using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money_scr : MonoBehaviour
{
    private Vector3 startPos;
    private Vector3 rescale; 
    public float speedS = 25f;
    public float distS = 0.01f;

    public float speedR = 2f;

    
    void Start()
    {
        startPos = transform.position;
        rescale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = startPos + new Vector3(0.0f, (Mathf.Sin(Time.time * speedS) * distS),0.0f);
        transform.localScale = rescale + new Vector3((Mathf.Sin(Time.time * speedR) -1f  ), 0.0f ,0.0f);
        
    }
}
