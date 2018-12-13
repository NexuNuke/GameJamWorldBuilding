using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class FinishLevel : MonoBehaviour
{
    public static bool nextLevel;
    // Start is called before the first frame update
    void Start()
    {
        nextLevel = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            nextLevel = true;
            StartCoroutine(WaitFinale());
        }
    }

    IEnumerator WaitFinale()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("Level 2");
    }
}
