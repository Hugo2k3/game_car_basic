using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{


    [SerializeField] float steerSpeed = 300f;
    [SerializeField] float moveSpeed= 20f;
    [SerializeField] float slowSpeed =15f;
    [SerializeField] float boostSpeed = 50f;
    void Start()
    {
       
    }
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal")*steerSpeed*Time.deltaTime;// lay tu ban phim a d left right
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed*Time.deltaTime;//
        transform.Rotate(0, 0,-steerAmount );// dung de xoay xe oto
        transform.Translate(0, moveAmount, 0);// di chuyen oto theo movespeed;
        


    }
     void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag=="Speed")
        {
            moveSpeed = boostSpeed;
        }
        
    }
     void OnCollisionEnter2D(Collision2D collision)
    {
        moveSpeed = slowSpeed;
    }
}
