using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flag : MonoBehaviour {

    public GameManager gm;

    void OnTriggerEnter2D (Collider2D collider)
    {
        Debug.Log("Something triggered me");
        if (collider.gameObject.tag == "Ball")
        {
            Debug.Log("It's in the hole!");
            gm.Win();
            // Throw fireworks at flag
        }
    }
    
}
