using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("TimeHero")) // Karakter collider'ý
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // Bir sonraki sahneye geç
        }
    }
    
}

