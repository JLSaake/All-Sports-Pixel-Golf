using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Throw : MonoBehaviour {

    Rigidbody rb;

    // Public Variables
    public float power = 0; // Scale of shot
    public float angle = 0; // Ratio of X-Y for shot
    public float max_power = 30f;
    public bool power_bar = false;
    public bool positive_bar = true;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButton("Horizontal"))
        {
            power += 0.2f * Input.GetAxis("Horizontal");
        }
        if (Input.GetButton("Vertical"))
        {
            angle += 0.2f * Input.GetAxis("Vertical");
        }
		if (Input.GetButton("Jump"))
        {
            if (positive_bar)
            {
                power += 0.01f;
            } else
            {
                power -= 0.01f;
            }
            if (power >= max_power || power <= 0)
            {
                positive_bar = !positive_bar;
            }
        }
        if (Input.GetButtonUp("Jump"))
        {
            power_bar = false;
            rb.velocity = new Vector3(Mathf.Cos(angle * Mathf.Deg2Rad) * power, Mathf.Sin(angle * Mathf.Deg2Rad) * power, 0);
            power = 0;
        }
    }


    void PowerBar()
    {
        power_bar = true;
        bool positive = true;
        while (power_bar)
        {
            if (positive)
            {
                power += 0.1f;
            } else
            {
                power -= 0.1f;
            }
            if (power >= max_power)
            {
                positive = !positive;
            }
        }
    }
}
