using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void FireShot (float angle, float power, float startingY)
    {
        rb.velocity = new Vector2(Mathf.Cos(angle * Mathf.Deg2Rad) * power, 
                                    Mathf.Sin(angle * Mathf.Deg2Rad) * power);
    }


 
}
