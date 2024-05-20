using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderScript : MonoBehaviour
{
    public int requiredColliderCount = 10; // Toplanmas� gereken collider say�s�
    private int Collectibles = 0; // Toplanan collider say�s�
    public GameObject portal; // Portal objesi

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("TimeHero")) 
        {
            Collectibles++; // Toplanan collider say�s�n� art�r
            Debug.Log("Collider collected. Total: " + Collectibles);

            if (Collectibles >= requiredColliderCount) // E�er gerekli say�da collider topland�ysa
            {
                ActivatePortal(); // Portal� aktifle�tir
            }
        }
    }

    private void ActivatePortal()
    {
        portal.SetActive(true); // Portal� aktifle�tir
    }
}

