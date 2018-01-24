using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float PLAYER_START_X = 0;
    public float PLAYER_START_Y = 4;
    public float BALL_LOWER_Y = 1;
    public float BALL_UPPER_Y = 5;

   public void MovePlayer (float xPosition, float yPosition)
    {
        this.gameObject.transform.position = new Vector2(xPosition, yPosition);
    }
}
