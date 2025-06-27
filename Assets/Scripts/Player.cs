using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        //移動
        Dash();
        MoveRight();
        MoveLeft();
        Jump();
    }

    void MoveRight()
    {
        //Dキーを押すと右に動く
        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.linearVelocity = new Vector3(1, 0, 0);
        }
    }
    void MoveLeft()
    {
        //Aキーを押すと左に動く

    }
    void Jump()
    {
        //Wキーでジャンプ

    }

    void Dash()
    {

    }

    //変装
    void Disguise()
    {

    }
}
