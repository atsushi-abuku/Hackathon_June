using UnityEngine;

public class Goal : MonoBehaviour
{
    public bool isGoaled;
    public GameObject GoalObject1;
    public GameObject GoalObject2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isGoaled = false;
        GoalObject2.GetComponent<Renderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //接触したら呼び出される
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("GOAL");
        //isGoaledをtrueに変える
        isGoaled = true;
        GoalObject1.GetComponent<Renderer>().enabled = false;
        GoalObject2.GetComponent<Renderer>().enabled = true;







    }
    public bool GetIsGoaled()
    {
        //isGoaledの状態を返す
        return isGoaled;
    }

}
