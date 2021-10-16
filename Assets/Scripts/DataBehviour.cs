using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class DataBehviour : MonoBehaviour
{
    // Start is called before the first frame update
    public static int player1Score = 0;
    public static int player2Score = 0;

    public Text player1ScoreText;
    public Text player2ScoreText;

    // Update is called once per frame 
    [PunRPC] 
    public static void incrementPLayer1()
    {
        player1Score++;
    }
    [PunRPC] 
    public static void incrementPLayer2()
    {
        player2Score++;
    }
    
    
    void Update()
    {
        GetComponent<PhotonView>().RPC("displayScorePlayer1", RpcTarget.All);
        GetComponent<PhotonView>().RPC("displayScorePlayer2", RpcTarget.All);
        displayScorePlayer1();
        displayScorePlayer2();

    }
    
    [PunRPC] 
    void displayScorePlayer1() {
        player1ScoreText.text = player1Score.ToString();
    }

    [PunRPC]
    void displayScorePlayer2(){
        player2ScoreText.text = player2Score.ToString();
    }
}
