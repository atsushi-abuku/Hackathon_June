using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody rb;
    bool isGrounded;
    float moveSpeed = 3f;
    bool isDashing = false;

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
        StopIfNoInput();
    }

    void MoveRight()
    {
        //Dキーを押すと右に動く

        Vector3 currentVelocity = rb.linearVelocity;//y軸方向維持

        if (Input.GetKey(KeyCode.D) && isGrounded)//地面にいるとき
        {
            rb.linearVelocity = new Vector3(moveSpeed, 0, 0);
        }
        else if (Input.GetKey(KeyCode.D) && !isGrounded)//空中にいるとき
        {
            rb.linearVelocity = new Vector3(moveSpeed, currentVelocity.y, 0);
        }
    }
    void MoveLeft()
    {
        //Aキーを押すと左に動く
        isGrounded = Physics.Raycast(transform.position, Vector3.down, 1.1f);
        Vector3 currentVelocity = rb.linearVelocity;//y軸方向維持

        if (Input.GetKey(KeyCode.A) && isGrounded)//地面にいるとき
        {
            rb.linearVelocity = new Vector3(-moveSpeed, 0, 0);
        }
        else if (Input.GetKey(KeyCode.A) && !isGrounded)//空中にいるとき
        {
            rb.linearVelocity = new Vector3(-moveSpeed, currentVelocity.y, 0);
        }
    }
    void Jump()
    {
        //Wキーでジャンプ
        isGrounded = Physics.Raycast(transform.position, Vector3.down, 1.1f);

        if (Input.GetKey(KeyCode.W) && isGrounded)//1段ジャンプ
        {
            Vector3 currentVelocity = rb.linearVelocity;
            rb.linearVelocity = new Vector3(currentVelocity.x, 9, 0);
        }
    }

    void Dash()
    {
        //Shiftを押しながら移動することでダッシュ
        isGrounded = Physics.Raycast(transform.position, Vector3.down, 1.1f);
        isDashing = Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift);
        moveSpeed = isDashing ? 5f : 3f;
    }

    void StopIfNoInput()//ボタンをはなしたとき
    {
        bool noInput = !Input.GetKey(KeyCode.D) && !Input .GetKey(KeyCode.A);

        if(noInput && isGrounded)
        {
            Vector3 currentVelocty = rb.linearVelocity;
            rb.linearVelocity = new Vector3(0, currentVelocty.y, currentVelocty.z);
        }
    }

    //変装
    void Disguise()
    {

    }
}

