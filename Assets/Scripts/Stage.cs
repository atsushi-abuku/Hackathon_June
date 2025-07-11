using UnityEngine;

enum Fase
{
    GOING,//行き
    BACK, //帰り
    FINISH //終わり
}
public class Stage : MonoBehaviour
{
    Fase fase;
    float time;
    float timeAccumulator;

    public GameObject field;
    public GameObject firstGoal;//行きのゴール
    public GameObject secondGoal;//帰りのゴール
    public TMPro.TextMeshProUGUI textMeshPro;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        fase = Fase.GOING;
        time = 10f;
        timeAccumulator = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        //textMeshPro.text = time + "seconds";
        StageUpdate();
        //時間を減らす(1秒ごと）
        timeAccumulator += Time.deltaTime;
        if(timeAccumulator >= 1f)
        {
            time--;
            timeAccumulator = 0f;
        }
        if (fase != Fase.FINISH && time >= 0)
        {
            textMeshPro.text = Mathf.Ceil(time).ToString();
        }
    }

    void GameOver()
    {
        //GAMEOVERなら「GAMEOVER」と表示
        if (time < 0f)
        {
            textMeshPro.text = "GAMEOVER";
        }
        else
        {
            textMeshPro.text = "CLEAR";
        }
    }

    void StageUpdate()
    {
        switch (fase)
        {
            case Fase.GOING:
                Going();
                break;
            case Fase.BACK:
                Back();
                break;
            case Fase.FINISH:
                Finish();
                break;
        }
    }

    void Going()
    {
        if (firstGoal.GetComponent<Goal>().GetIsGoaled())
        {
            //firstGoalを消し，secondGoalを出現させる

            fase = Fase.BACK;
        }
    }

    void Back()
    {
        if (secondGoal.GetComponent<Goal>().GetIsGoaled())
        {
            fase = Fase.FINISH;
        }
    }

    void Finish()
    {
        //GAMEOVERなら「GAMEOVER」,CLEARなら「CLEAR」とUIに表示
        GameOver();
    }
}
