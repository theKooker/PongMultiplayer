using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class BallMovement : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    public float speed = 5;
    private int count = 0;
    void Start()
    {
    }
    void Update()
    {
        if(PhotonNetwork.PlayerList.Length > 1 && count == 0) 
        {
            Launch();
            count = 1;
        }
    }

    // Update is called once per frame
    void Launch()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(x * speed, y * speed);

    }
    void OnCollisionEnter2D(Collision2D other)
    {   
        if(other.collider.tag == "Player1Goal") {
            DataBehviour.incrementPLayer2();
            gameObject.transform.position = new Vector3(0,0,1);
            Launch();
        }
        if(other.collider.tag == "Player2Goal") {
            DataBehviour.incrementPLayer1();
            gameObject.transform.position = new Vector3(0,0,1);
            Launch();
        }
    }

    
}
