using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour {

    public int boxNum;
    public float nowTime;

    // Use this for initialization
    void Start () {
        nowTime = 0;
    }

    // Update is called once per frame
    void Update () {
        nowTime += Time.deltaTime;
        if (boxNum <= 0) {
            GameOver();
        }
    }

    public void GameOver(string resultMessage) {   //<=====引数をもたせた
        DataSender.resultMessage = resultMessage;  //<=====受け取った引数をstatic変数へ格納
        SceneManager.LoadScene("Result");
    }
}
