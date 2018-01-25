﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpriteManager : MonoBehaviour {

    public Sprite used;
    public Sprite selected;

    public Sprite _baseball;
    public Sprite _football;
    public Sprite _frisbee;
    public Sprite _hockey;
    public Sprite _nerf;
    public Sprite _soccer;
    public Sprite _tennis;
    public Sprite _volleyball;

    public Image baseball;
    public Image football;
    public Image frisbee;
    public Image hockey;
    public Image nerf;
    public Image soccer;
    public Image tennis;
    public Image volleyball;

    public GameManager.ShotTypes selectedShot = GameManager.ShotTypes.UNSELECTED;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void UseShot()
    {
        if (selectedShot == GameManager.ShotTypes.BASEBALL)
        {
            baseball.sprite = used;
        } else
        if (selectedShot == GameManager.ShotTypes.FOOTBALL)
        {
            football.sprite = used;
        }
        else
        if (selectedShot == GameManager.ShotTypes.FRISBEE)
        {
            frisbee.sprite = used;
        }
        else
        if (selectedShot == GameManager.ShotTypes.HOCKEYPUCK)
        {
            hockey.sprite = used;
        }
        else
        if (selectedShot == GameManager.ShotTypes.NERFFOOTBALL)
        {
            nerf.sprite = used;
        }
        else
        if (selectedShot == GameManager.ShotTypes.SOCCERBALL)
        {
            soccer.sprite = used;
        }
        else
        if (selectedShot == GameManager.ShotTypes.TENNISBALL)
        {
            tennis.sprite = used;
        }
        else
        if (selectedShot == GameManager.ShotTypes.VOLLEYBALL)
        {
            volleyball.sprite = used;
        }

        selectedShot = GameManager.ShotTypes.UNSELECTED;

    }

    public void ChangeSelection (GameManager.ShotTypes newShot)
    {
        if(selectedShot != GameManager.ShotTypes.UNSELECTED)
        {
            if (selectedShot == GameManager.ShotTypes.BASEBALL)
            {
                baseball.sprite = _baseball;
            }
            else
        if (selectedShot == GameManager.ShotTypes.FOOTBALL)
            {
                football.sprite = _football;
            }
            else
        if (selectedShot == GameManager.ShotTypes.FRISBEE)
            {
                frisbee.sprite = _frisbee;
            }
            else
        if (selectedShot == GameManager.ShotTypes.HOCKEYPUCK)
            {
                hockey.sprite = _hockey;
            }
            else
        if (selectedShot == GameManager.ShotTypes.NERFFOOTBALL)
            {
                nerf.sprite = _nerf;
            }
            else
        if (selectedShot == GameManager.ShotTypes.SOCCERBALL)
            {
                soccer.sprite = _soccer;
            }
            else
        if (selectedShot == GameManager.ShotTypes.TENNISBALL)
            {
                tennis.sprite = _tennis;
            }
            else
        if (selectedShot == GameManager.ShotTypes.VOLLEYBALL)
            {
                volleyball.sprite = _volleyball;
            }
        }

        selectedShot = newShot;
        if (selectedShot == GameManager.ShotTypes.BASEBALL)
        {
            baseball.sprite = selected;
        }
        else
        if (selectedShot == GameManager.ShotTypes.FOOTBALL)
        {
            football.sprite = selected;
        }
        else
        if (selectedShot == GameManager.ShotTypes.FRISBEE)
        {
            frisbee.sprite = selected;
        }
        else
        if (selectedShot == GameManager.ShotTypes.HOCKEYPUCK)
        {
            hockey.sprite = selected;
        }
        else
        if (selectedShot == GameManager.ShotTypes.NERFFOOTBALL)
        {
            nerf.sprite = selected;
        }
        else
        if (selectedShot == GameManager.ShotTypes.SOCCERBALL)
        {
            soccer.sprite = selected;
        }
        else
        if (selectedShot == GameManager.ShotTypes.TENNISBALL)
        {
            tennis.sprite = selected;
        }
        else
        if (selectedShot == GameManager.ShotTypes.VOLLEYBALL)
        {
            volleyball.sprite = selected;
        }
    }
}
