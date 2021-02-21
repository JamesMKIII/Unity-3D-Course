using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
    AudioSource audioSource;
    [SerializeField] AudioClip success;
    [SerializeField] AudioClip boom;

    bool isTransitioning;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void OnCollisionEnter(Collision collision)
    {


        switch (collision.gameObject.tag)
        {
            case "Respawn":
                Debug.Log("Launch Pad");
                break;

            case "Fuel":
                Debug.Log("Fuel Pod");
                break;

            case "Finish":
                Invoke("NextLevel", 1f);
                break;

            default:
                Crashed();
                break;
        }
    }

    private void Respawn()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }

    private void Success()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(success);
        Invoke("NextLevel", 1f);
    }

    private void NextLevel()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = currentSceneIndex + 1;
        if (nextSceneIndex == SceneManager.sceneCountInBuildSettings)
        {
            nextSceneIndex = 0;
        }
        SceneManager.LoadScene(nextSceneIndex);
    }

    private void Crashed()
    {
        Movement.isCrashed = true;
        audioSource.Stop();
        audioSource.PlayOneShot(boom);
        Invoke("Respawn", 1f);
    }
}
