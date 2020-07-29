using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBoxScript : MonoBehaviour
{
    public float speed = 10f;
    private Vector3 Down;
    private float lifetimer = 5f;
    [SerializeField]
    private GameObject player;
    

    private void Start()
    {
        Down = new Vector3(0.0f, 0.0f, -1.0f);
    }

    void Update()
    {

        transform.position = transform.position + Down*speed * Time.deltaTime;

        lifetimer -= Time.deltaTime;
        if (lifetimer <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            Destroy(gameObject);
            player.GetComponent<PlayerMove>()._score += 100;
        }
    }
}
