using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flag : MonoBehaviour {

    void OnTriggerEnter2D (Collider2D collider)
    {
        Debug.Log("Something triggered me");
        if (collider.gameObject.tag == "Ball")
        {
            Debug.Log("It's in the hole!");
            // Call game manager ending
            // Throw fireworks at flag
        }
    }
    
}
