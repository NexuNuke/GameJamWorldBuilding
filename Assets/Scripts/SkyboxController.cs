using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyboxController : MonoBehaviour
{

    public Material skyWhite;
    public Material skyBlack;

    // Start is called before the first frame update
    void Start()
    {
        RenderSettings.skybox = skyWhite;
    }

    // Update is called once per frame
    void Update()
    {
        if (ColourController.whiteblack == true)
        {
            RenderSettings.skybox = skyBlack;
        }
        else
        {
            RenderSettings.skybox = skyWhite;
        }
    }
}
