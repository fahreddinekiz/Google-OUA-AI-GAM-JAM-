using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderScript : MonoBehaviour
{
    public int requiredColliderCount = 10; // Toplanmasý gereken collider sayýsý
    private int Collectibles = 0; // Toplanan collider sayýsý
    public GameObject portal; // Portal objesi

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("TimeHero")) 
        {
            Collectibles++; // Toplanan collider sayýsýný artýr
            Debug.Log("Collider collected. Total: " + Collectibles);

            if (Collectibles >= requiredColliderCount) // Eðer gerekli sayýda collider toplandýysa
            {
                ActivatePortal(); // Portalý aktifleþtir
            }
        }
    }

    private void ActivatePortal()
    {
        portal.SetActive(true); // Portalý aktifleþtir
    }
}

