using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class EnableChildren : MonoBehaviour
{
    GameObject gameObj;
    public Text[] toggleText;
    public Text[] toggleText2;
    // Start is called before the first frame update
    void Start()
    {
        gameObj = GetComponent<GameObject>();
        toggleText = GetComponentInChildren<Text[]>();
        toggleText2 = GetComponentInChildren<Text[]>();
    }

    // Update is called once per frame
    void Update()
    {
        foreach (Text tText in toggleText) { tText.gameObject.SetActive(FinishLevel.nextLevel); }
        foreach (Text tText in toggleText2) { tText.gameObject.SetActive(FinishLevel.nextLevel); }


    }
}
