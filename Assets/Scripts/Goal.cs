using UnityEngine;

public class Goal : MonoBehaviour
{
    public bool isGoaled;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isGoaled = false;
        
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


    }
}
