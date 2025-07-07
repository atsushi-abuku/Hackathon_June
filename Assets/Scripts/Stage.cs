using UnityEngine;

public class Stage : MonoBehaviour
{
    float time;
    float timeAccumulator = 0f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        time = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        GameOver();
        //時間を減らす(1秒ごと）
        timeAccumulator += Time.deltaTime;
        if(timeAccumulator >= 1f)
        {
            time--;
            timeAccumulator = 0f;
        }
        GameOver();
    }

    void GameOver()
    {
        //GAMEOVERなら「GAMEOVER」と表示
        if (time == 0f)
        {
            Debug.Log("「GAMEOVER」");
        }
    }

}
