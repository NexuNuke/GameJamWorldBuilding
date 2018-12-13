using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public GameObject gameobj;
    Canvas canvas;
    float i = 0.0f;
    Text text;
    // Start is called before the first frame update
    void Start()
    {
        canvas = gameobj.GetComponent<Canvas>();
        text = gameobj.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        i += Time.deltaTime;
        float seconds = i % 60;
        float minutes = ((int) i / 60);
        text.text = minutes.ToString("00") + ":" + seconds.ToString("00");
    }
}
