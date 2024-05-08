using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] float velocity, velocityJump;
    private void FixedUpdate()
    {
        MovePlayer();
        JumpPlayer();
    }
    void MovePlayer()
    {
        var go = transform.position;
        var time = Time.deltaTime;
        if (Input.GetKey(KeyCode.W))
        {
            go += Vector3.forward * velocity * time;
        }
        if (Input.GetKey(KeyCode.S))
        {
            go += Vector3.back * velocity * time;
        }
        if (Input.GetKey(KeyCode.D))
        {
            go += Vector3.right * velocity * time;
        }
        if (Input.GetKey(KeyCode.A))
        {
            go += Vector3.left * velocity * time;
        }
        transform.position = go;
    }
    void JumpPlayer()
    {
        var go = transform.position;
        var time = Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            go += Vector3.up * velocityJump * time;
        }
        transform.position = go;
    }
   
}