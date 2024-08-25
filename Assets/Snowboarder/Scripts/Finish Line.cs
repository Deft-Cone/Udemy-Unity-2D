using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float loadDelay = 1f;
    [SerializeField] ParticleSystem finishEffect;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("You Finished");
            finishEffect.Play();
            Invoke("ReloadScene", loadDelay);
        }
        
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
