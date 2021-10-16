using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnPlayer : MonoBehaviour
{
    public GameObject player2;

    // Start is called before the first frame update
    void Start()
    {
        Vector2 position;

        if (!CreateAndJoinRoom.created)
        {
            position = new Vector2(-8.56f, 0.02f);
        }
        else
        {
            position = new Vector2(8.56f, 0.02f);
        }
        PhotonNetwork.Instantiate(player2.name, position, Quaternion.identity);
    }
}
