using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clockcollection : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Collectibles"))
        {
            Destroy(other.gameObject);
        }
    }   
}
