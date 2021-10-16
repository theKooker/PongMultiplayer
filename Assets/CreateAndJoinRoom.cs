using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class CreateAndJoinRoom : MonoBehaviourPunCallbacks
{
    public InputField createRoomField;
    public InputField joinRoomField;
    public static bool created = false;
    public static bool joined = false;

    public void CreateRoom(){
        created = true;
        PhotonNetwork.CreateRoom(createRoomField.text);
    }

    public void JoinRoom() {
        joined = true;
        PhotonNetwork.JoinRoom(joinRoomField.text);
    }

    public override void OnJoinedRoom() {
        PhotonNetwork.LoadLevel("Game");
    }
}
