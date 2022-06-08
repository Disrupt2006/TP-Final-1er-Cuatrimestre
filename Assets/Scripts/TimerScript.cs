using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{

    public Text timerText;
    private float startTime;
    public bool TimerOn;

    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
        TimerOn = true;
    }

    // Update is called once per frame
    void Update()
    {
        float t = Time.time - startTime;

        if (TimerOn == true)
        {
            string minutes = ((int)t / 60).ToString();
            string seconds = (t % 60).ToString("f2");

            timerText.text = minutes + ":" + seconds;
        }

        
    }

    void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.tag == "DeathCube")
        {
            TimerOn = false;
        }


    }


}
