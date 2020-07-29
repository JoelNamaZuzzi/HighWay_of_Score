using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class PlayerMove : MonoBehaviour
{
    
    public float speed = 12f;
    public int _score;
    public CharacterController Controller;
    private float scoretimer = 1f;
    
    
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        Controller.Move(move * speed * Time.deltaTime);

        scoretimer -= Time.deltaTime;
        if (scoretimer <= 0)
        {
            _score += 10;
            scoretimer = 1f;
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Enemy"))
        {
            Destroy(gameObject);
        }
        else if(other.gameObject.layer == LayerMask.NameToLayer("ScoreBox"))
        {
            _score += 100;
        }
    }
}
