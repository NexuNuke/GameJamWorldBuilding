using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourChange : MonoBehaviour
{
    Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
 
    }

    // Update is called once per frame
    void Update()
    {
        if (ColourController.whiteblack == true)
        {
            rend.material.color = Color.white;
        }
        else
        {
            rend.material.color = Color.black;
        }
        if(EnemyCollision.Dead == true)
        {
            rend.material.color = Color.red;
        }
    }
}
