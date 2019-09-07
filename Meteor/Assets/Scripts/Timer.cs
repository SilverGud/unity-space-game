using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerText;
    private float startTime = 60f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (startTime > 0f)
        {
            startTime -= Time.deltaTime;

            timerText.text = "" + Mathf.Round(startTime);
        }
        else
        {
            
        }
    }
}
