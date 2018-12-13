using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MovementConstraint : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        //rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        var x = transform.position.x;
        var y = transform.position.y;

        transform.position = new Vector3(x, y, 0);

        if(Input.GetKey (KeyCode.LeftControl))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            
        }
        if(Input.GetKey (KeyCode.RightShift))
        {
            
        } else
        {
            
        }
    }

}
