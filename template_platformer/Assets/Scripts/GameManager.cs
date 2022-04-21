using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static bool gameOver = false;

    public static bool winCondition = false;

    public static int actualPlayer = 0;

    public List<Controller_Target> targets;

    public List<Controller_Player> players;

    void Start()
    {
        Physics.gravity = new Vector3(0, -30, 0);
        gameOver = false;
        winCondition = false;
        SetConstraits();
    }

    void Update()
    {
        GetInput();
        CheckWin();

    }

    private void CheckWin()
    {
        int i = 0;
        foreach(Controller_Target t in targets)
        {
            if (t.playerOnTarget)
            {
                i++;
                //Debug.Log(i.ToString());
            }
        }
        if (i >= 7)
        {
            winCondition = true;
        }
    }

    private void GetInput()
    {
        if (Input.GetKeyDown("1")) {
            actualPlayer = 0;
            SetConstraits();
        }
        if (Input.GetKeyDown("2"))
        {
            actualPlayer = 1;
            SetConstraits();
        }
        if (Input.GetKeyDown("3"))
        {
            actualPlayer = 2;
            SetConstraits();
        }
        if (Input.GetKeyDown("4"))
        {
            actualPlayer = 3;
            SetConstraits();
        }
        if (Input.GetKeyDown("5"))
        {
            actualPlayer = 4;
            SetConstraits();
        }
    }

    private void SetConstraits()
    {
        foreach(Controller_Player p in players)
        {
            if (p == players[actualPlayer])
            {
                p.rb.constraints = RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotation;
            }
            else
            {
                p.rb.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotation;
            }
        }
    }
}
