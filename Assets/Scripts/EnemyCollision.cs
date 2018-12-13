using System.Collections;
using System.Collections.Generic;
using Invector.CharacterController;
using UnityEngine.SceneManagement;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    Animator animator;
    public static bool Dead;
    public Renderer rend;
    public AnimationClip deathAnim;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        Dead = false;
        //rend = GetComponent<Renderer>();
    }

    private void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.CompareTag("Enemy"))
        {
            Dead = true;
            GetComponent<vThirdPersonInput>().enabled = false;
            GetComponent<vThirdPersonController>().enabled = false;
            animator.Play(deathAnim.name);
            StartCoroutine(WaitFinale());
        }
    }

    IEnumerator WaitFinale()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
