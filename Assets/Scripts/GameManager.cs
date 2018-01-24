﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public Player player;                       // Player sprite
    public BallManager ballManager;             // To be used for current ball in play
    public float power;                         // Power of the shot
    public float angle;                         // Angle of the shot
    public float maxShots = 8;                  // Max number of shots: Should equal length of ShotTypes
    public float numShots = 0;                  // Number of shots taken already
    public enum ShotTypes { BASEBALL, FRISBEE, NERFFOOTBALL, FOOTBALL,
        SOCCERBALL, VOLLEYBALL, TENNISBALL, HOCKEYPUCK };
    public ShotTypes selectedShot;              // Actively selected shot type

    // Has type of shot been used
    public bool usedBaseball = false;
    public bool usedFrisbee = false;
    public bool usedNerfFootball = false;
    public bool usedFootball = false;
    public bool usedSoccerBall = false;
    public bool usedVolleyBall = false;
    public bool usedTennisBall = false;
    public bool usedHockeyPuck = false;



    // Use this for initialization
    void Start() {
        player.MovePlayer(player.PLAYER_START_X, player.PLAYER_START_Y);
        ResetUsage();
    }

    // Update is called once per frame
    void Update() {

    }


    void Shot (float power, float angle)
    {
        float startingY = _DetermineShotStartHeight();

    }

    float _DetermineShotStartHeight ()
    {
        if (selectedShot == ShotTypes.BASEBALL ||
            selectedShot == ShotTypes.FOOTBALL ||
            selectedShot == ShotTypes.FRISBEE ||
            selectedShot == ShotTypes.NERFFOOTBALL ||
            selectedShot == ShotTypes.TENNISBALL ||
            selectedShot == ShotTypes.VOLLEYBALL)
        {
            return player.BALL_UPPER_Y;
        } else
        {
            return player.BALL_LOWER_Y;
        }
    }

    //void EndStroke ()
    //{
    //    player.MovePlayer(currentBall.transform.position.x, player.PLAYER_START_Y);
    //    Destroy(currentBall.gameObject);
    //}

    void ResetUsage ()
    {
        usedBaseball = false;
        usedFrisbee = false;
        usedNerfFootball = false;
        usedFootball = false;
        usedSoccerBall = false;
        usedVolleyBall = false;
        usedTennisBall = false;
        usedHockeyPuck = false;
}

    void SelectShotType (ShotTypes shotType)
    {
        //TODO: state machine for checking if each shot type can be selected
    }
}