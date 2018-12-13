using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourCollisionController : MonoBehaviour
{
    public string whiteorblack;
    Collision localCollision;
    private void Update()
    {
        if (whiteorblack == "white")
        {
            if (ColourController.whiteblack == false)
            {
                this.transform.GetComponent<Collider>().enabled = false;
                this.transform.GetComponent<MeshRenderer>().enabled = false;
            }
            else
            {
                this.transform.GetComponent<Collider>().enabled = true;
                this.transform.GetComponent<MeshRenderer>().enabled = true;
            }
        } else if (whiteorblack == "black")
        {
            if (ColourController.whiteblack == true)
            {
                this.transform.GetComponent<Collider>().enabled = false;
                this.transform.GetComponent<MeshRenderer>().enabled = false;
            }
            else
            {
                this.transform.GetComponent<Collider>().enabled = true;
                this.transform.GetComponent<MeshRenderer>().enabled = true;
            }
        }
    }
}
