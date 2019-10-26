﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour{
    [SerializeField]
    GameManager gameManager;

    [SerializeField]
    float velocity = 1;

    private Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start() {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update() {

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)){

            //Jump
            rb2d.velocity = Vector2.up * velocity; 
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        gameManager.gameOver();
    }

}
