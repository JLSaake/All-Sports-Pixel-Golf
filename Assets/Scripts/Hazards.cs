using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazards : MonoBehaviour {

    public GameManager gamemanager;

	void OnCollisionEnter2D (Collision2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            Debug.Log("Ball in hazard");
            Debug.Log(this.gameObject.tag);
            if (this.gameObject.tag == "WaterHazard")
            {
                gamemanager.WaterHazard();
                return;
            }
            if (this.gameObject.tag == "SandTrap")
            {
                gamemanager.EndStroke();
                return;
            }
        }
    }
}
