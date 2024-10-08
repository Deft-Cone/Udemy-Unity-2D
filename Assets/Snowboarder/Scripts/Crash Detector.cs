using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CrashDetector : MonoBehaviour
{
    [SerializeField] float loadDelay = 0.5f;
    bool hasCrashed = false;

    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] AudioClip crashSFX;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ground" && !hasCrashed)
        {
            hasCrashed = true;
            FindObjectOfType<PlayerController>().DisableControls();
            Debug.Log("Hit your head.");
            crashEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
            Invoke("ReloadScene", loadDelay);
        }
    }
    
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
