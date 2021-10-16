using System.ComponentModel.Design;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerMovement : MonoBehaviour
{
    public bool isPlayer1;
    public float speed = 5;
    private float movement = 0;
    PhotonView view;
    void Start()
    {
        view = GetComponent<PhotonView>();
    }
    // Update is called once per frame
    void Update()
    {
        if(view.IsMine) {
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
                movement = 1;
            else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
                movement = -1;
            else 
                movement = 0;
        }
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(gameObject.GetComponent<Rigidbody2D>().velocity.x, movement * speed);

    }
}
