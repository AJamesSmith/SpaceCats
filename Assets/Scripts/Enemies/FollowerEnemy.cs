﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowerEnemy : Enemy {

    
    void Start()
    {
        health = 10;
        damage = 20;
        speed = 2;
       // bounceForce = 0.5;
        target = GameObject.Find("Player");
        
        boxCol = GetComponent<BoxCollider>();
        body = GetComponent<Rigidbody>();
       
    }
    // Update is called once per frame
    void Update()
    {
        
        chaseTarget = target.transform.position - this.transform.position;
        //this.transform.position += chaseTarget * .2f;
        body.AddForce(chaseTarget.x, chaseTarget.y, 0);
       
    }

    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.name == "Player")
        {
            playerScript = target.GetComponent<Player>();
            if (playerScript.canTakeDamage)
            {
                playerScript.TakeDamage(damage);
                ApplyBounce(target.transform.position);
                playerScript.Bounce(chaseTarget);
            }
        }
        
    }


   
}
