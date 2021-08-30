﻿using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyOutofBound : MonoBehaviour
{
    // Start is called before the first frame update
    private float topBound = 30;
    private float lowerBound = -10;
    private float sideBound = 30;
    private GameManager gameManager;
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if(transform.position.z < lowerBound)
        {
            //Debug.Log("Game Over !");
            gameManager.AddLives(-1);
            Destroy(gameObject);
        }
        else if(transform.position.x > sideBound)
        {
            //Debug.Log("Game Over!");
            gameManager.AddLives(-1); 
            Destroy(gameObject);
        }
        else if(transform.position.x < -sideBound)
        {
            //Debug.Log("Game Over!");
            gameManager.AddLives(-1);
            Destroy(gameObject);
        }
        
    }
}
