using UnityEngine;

enum Fase
{
    GOING,
    BACK,
    FINISH
}
public class Stage : MonoBehaviour
{
    Fase fase;
    float time;

    public GameObject field;
    private Goal firstGoal;//行きのゴール
    private Goal secondGoal;//帰りのゴール
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        fase = Fase.GOING;
        time = 10;
        //field内のゴールをfirstGoal,secondGoalに代入

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
        if (firstGoal.GetIsGoaled())
        {
            //firstGoalを消し，secondGoalを出現させる

            fase = Fase.BACK;
        }
    }

    void Back()
    {
        if (secondGoal.GetIsGoaled())
        {
            fase = Fase.FINISH;
        }
    }

    void Finish()
    {
        //GAMEOVERなら「GAMEOVER」,CLEARなら「CLEAR」とUIに表示
    }
}
