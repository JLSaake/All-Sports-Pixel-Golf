using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallManager : MonoBehaviour {

    public Vector2 shotScale;

    public GameObject Baseball;                                 // Baseball prefab
    public GameObject Frisbee;                                  // Frisbee prefab
    public GameObject NerfFootball;                             // NerfFootball prefab
    public GameObject Football;                                 // Football prefab
    public GameObject Soccerball;                               // SocerBall prefab
    public GameObject Volleyball;                               // Volleyball prefab
    public GameObject TennisBall;                               // TennisBall prefab
    public GameObject HockeyPuck;                               // HockeyPuck prefab


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ShootBall(float power, float angle, float startingY, GameManager.ShotTypes ballType)
    {
        _SetSprite(ballType);
        _SetShotScale(ballType);

    }

    void _SetSprite(GameManager.ShotTypes ballType)
    {

    }

    void _SetShotScale(GameManager.ShotTypes ballType)
    {
        // substate machine for ball types and their respective power scalars
    }
}
