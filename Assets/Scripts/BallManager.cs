using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallManager : MonoBehaviour {

    public float shotScale;

    public GameObject activeBall;
    public GameObject liveBall;

    public GameObject Baseball;                                 // Baseball prefab
    public GameObject Frisbee;                                  // Frisbee prefab
    public GameObject NerfFootball;                             // NerfFootball prefab
    public GameObject Football;                                 // Football prefab
    public GameObject Soccerball;                               // SocerBall prefab
    public GameObject Volleyball;                               // Volleyball prefab
    public GameObject TennisBall;                               // TennisBall prefab
    public GameObject HockeyPuck;                               // HockeyPuck prefab

    public Rigidbody2D rb;


    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}

    public void ShootBall(float power, float angle, float startingX, float startingY, GameManager.ShotTypes ballType)
    {
        _SetBall(ballType);
        _SetShotScale(ballType);
        liveBall = Instantiate(activeBall, new Vector2(startingX, startingY), Quaternion.identity) as GameObject;
        rb = liveBall.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(Mathf.Cos(angle * Mathf.Deg2Rad) * power * shotScale,
                                    Mathf.Sin(angle * Mathf.Deg2Rad) * power * shotScale);
    }

    void _SetBall(GameManager.ShotTypes ballType)
    {
        if (ballType == GameManager.ShotTypes.BASEBALL)
        {
            activeBall = Baseball;
        } else
        if (ballType == GameManager.ShotTypes.FOOTBALL)
        {
            activeBall = Football;
        }
        else
        if (ballType == GameManager.ShotTypes.NERFFOOTBALL)
        {
            activeBall = NerfFootball;
        }
        else
        if (ballType == GameManager.ShotTypes.FRISBEE)
        {
            activeBall = Frisbee;
        }
        else
        if (ballType == GameManager.ShotTypes.HOCKEYPUCK)
        {
            activeBall = HockeyPuck;
        }
        else
        if (ballType == GameManager.ShotTypes.SOCCERBALL)
        {
            activeBall = Soccerball;
        }
        else
        if (ballType == GameManager.ShotTypes.TENNISBALL)
        {
            activeBall = TennisBall;
        }
        else
        if (ballType == GameManager.ShotTypes.VOLLEYBALL)
        {
            activeBall = Volleyball;
        }

    }

    void _SetShotScale(GameManager.ShotTypes ballType)
    {
        // substate machine for ball types and their respective power scalars
        if (ballType == GameManager.ShotTypes.BASEBALL ||
            ballType == GameManager.ShotTypes.FOOTBALL)
        {
            shotScale = 25;
        } else
        if (ballType == GameManager.ShotTypes.FRISBEE ||
            ballType == GameManager.ShotTypes.SOCCERBALL)
        {
            shotScale = 20;
        } else
        if (ballType == GameManager.ShotTypes.NERFFOOTBALL)
        {
            shotScale = 22.5f;
        } else
        if (ballType == GameManager.ShotTypes.TENNISBALL ||
            ballType == GameManager.ShotTypes.VOLLEYBALL ||
            ballType == GameManager.ShotTypes.HOCKEYPUCK)
        {
            shotScale = 17.5f;
        }
    }
}
