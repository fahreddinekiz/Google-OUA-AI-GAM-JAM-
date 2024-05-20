using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("TimeHero"))
        {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    }
}
