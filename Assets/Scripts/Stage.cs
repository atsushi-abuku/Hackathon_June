using UnityEngine;

public class Stage : MonoBehaviour
{
    float time;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        time = 10;
    }

    // Update is called once per frame
    void Update()
    {
        GameOver();
        //時間を減らす
    }

    void GameOver()
    {
        //GAMEOVERなら「GAMEOVER」と表示
    }

}
