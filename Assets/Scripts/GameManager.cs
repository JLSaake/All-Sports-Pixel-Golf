using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public Player player;                       // Player sprite
    public BallManager ballManager;             // Manages Ball mechanics and spawn
    public float power;                         // Power of the shot
    public float angle;                         // Angle of the shot
    public float maxShots = 8;                  // Max number of shots: Should equal length of ShotTypes
    public float numShots = 0;                  // Number of shots taken already
    public enum ShotTypes { BASEBALL, FRISBEE, NERFFOOTBALL, FOOTBALL,
        SOCCERBALL, VOLLEYBALL, TENNISBALL, HOCKEYPUCK, UNSELECTED};
    public ShotTypes selectedShot = ShotTypes.UNSELECTED;              // Actively selected shot type
    public Camera mainCamera;

    public GameObject arrow;

    private bool cameraFollow = false;


    // Has type of shot been used
    public bool usedBaseball = false;
    public bool usedFrisbee = false;
    public bool usedNerfFootball = false;
    public bool usedFootball = false;
    public bool usedSoccerBall = false;
    public bool usedVolleyBall = false;
    public bool usedTennisBall = false;
    public bool usedHockeyPuck = false;
    public bool inPlay = false;



    // Use this for initialization
    void Start() {
        player.MovePlayer(player.PLAYER_START_X, player.PLAYER_START_Y);
        ResetUsage();
    }

    // Update is called once per frame
    void FixedUpdate() {
        arrow.transform.rotation = Quaternion.Euler(0, 0, angle);
        if (Input.GetButton("Horizontal")) // Change to positive / negative buttons
        {
            power += 0.1f * Input.GetAxis("Horizontal");
        }
        if (Input.GetButton("Vertical"))
        {
            angle += 0.2f * Input.GetAxis("Vertical");
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SelectShotType(ShotTypes.BASEBALL);
        }
        if (Input.GetButtonDown("Jump") && !inPlay)
        {
            inPlay = true;
            Shot(power, angle);
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            EndStroke();
        }

        if (ballManager.liveBall != null && !cameraFollow && 
            Mathf.RoundToInt(ballManager.liveBall.transform.position.x) == 
            Mathf.RoundToInt(mainCamera.transform.position.x))
        {
            cameraFollow = true;
        }
        if (cameraFollow)
        {
            mainCamera.transform.position = 
                new Vector3(ballManager.liveBall.transform.position.x, mainCamera.transform.position.y,
                            mainCamera.transform.position.z);
        }
    }


    void Shot (float _power, float _angle)
    {
        float startingY = _DetermineShotStartHeight();
        ballManager.ShootBall(_power, _angle, player.gameObject.transform.position.x, startingY, selectedShot);
        _useShot(selectedShot);
        arrow.SetActive(false);
        numShots++;
    }

    float _DetermineShotStartHeight ()
    {
        if (selectedShot == ShotTypes.BASEBALL ||
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

    public void EndStroke ()
    {
        cameraFollow = false;

        player.MovePlayer(ballManager.liveBall.transform.position.x, player.PLAYER_START_Y);
        Destroy(ballManager.liveBall);
        ballManager.activeBall = null;
        arrow.SetActive(true);
        if (mainCamera.transform.position.x <= 235)
        {
            mainCamera.transform.position = new Vector3(player.transform.position.x + 20, mainCamera.transform.position.y,
                                                        mainCamera.transform.position.z);
            arrow.transform.position = new Vector2(player.transform.position.x + 8, arrow.transform.position.y);
        }
        else
        {
            mainCamera.transform.position = new Vector3(player.transform.position.x - 20, mainCamera.transform.position.y,
                                            mainCamera.transform.position.z);
            arrow.transform.position = new Vector2(player.transform.position.x - 8, arrow.transform.position.y);
        }
        inPlay = false;
        if (numShots >= maxShots)
        {
            // End game in loss state (out of shots)
        }

    }

    public void WaterHazard()
    {
        ballManager.liveBall.transform.position = new Vector2(player.gameObject.transform.position.x, player.PLAYER_START_Y);
        EndStroke();
    }


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
        if (shotType == ShotTypes.BASEBALL)
        {
            if (!usedBaseball)
            {
                selectedShot = ShotTypes.BASEBALL;
            }
        } else
        if (shotType == ShotTypes.FOOTBALL)
        {
            if (!usedFootball)
            {
                selectedShot = ShotTypes.FOOTBALL;
            }
        }
        else
        if (shotType == ShotTypes.FRISBEE)
        {
            if (!usedFrisbee)
            {
                selectedShot = ShotTypes.FRISBEE;
            }
        }
        else
        if (shotType == ShotTypes.HOCKEYPUCK)
        {
            if (!usedHockeyPuck)
            {
                selectedShot = ShotTypes.HOCKEYPUCK;
            }
        }
        else
        if (shotType == ShotTypes.NERFFOOTBALL)
        {
            if (!usedNerfFootball)
            {
                selectedShot = ShotTypes.NERFFOOTBALL;
            }
        }
        else
        if (shotType == ShotTypes.SOCCERBALL)
        {
            if (!usedSoccerBall)
            {
                selectedShot = ShotTypes.SOCCERBALL;
            }
        }
        else
        if (shotType == ShotTypes.TENNISBALL)
        {
            if (!usedTennisBall)
            {
                selectedShot = ShotTypes.TENNISBALL;
            }
        }
        else
        if (shotType == ShotTypes.VOLLEYBALL)
        {
            if (!usedVolleyBall)
            {
                selectedShot = ShotTypes.VOLLEYBALL;
            }
        }
    }

    void _useShot (ShotTypes shotType)
    {
        if (shotType == ShotTypes.BASEBALL)
        {
            usedBaseball = true;
        } else
        if (shotType == ShotTypes.FOOTBALL)
        {
            usedFootball = true;
        }
        else
        if (shotType == ShotTypes.FRISBEE)
        {
            usedFrisbee = true;
        }
        else
        if (shotType == ShotTypes.HOCKEYPUCK)
        {
            usedHockeyPuck = true;
        }
        else
        if (shotType == ShotTypes.NERFFOOTBALL)
        {
            usedNerfFootball = true;
        }
        else
        if (shotType == ShotTypes.SOCCERBALL)
        {
            usedSoccerBall = true;
        }
        else
        if (shotType == ShotTypes.TENNISBALL)
        {
            usedTennisBall = true;
        }
        else
        if (shotType == ShotTypes.VOLLEYBALL)
        {
            usedVolleyBall = true;
        }
        selectedShot = ShotTypes.UNSELECTED;
    }
}
