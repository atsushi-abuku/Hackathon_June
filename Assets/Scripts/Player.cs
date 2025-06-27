using Unity.VisualScripting;
using UnityEngine;//pinekatsu

public class Player : MonoBehaviour
{
    Rigidbody rb;
    bool isGrounded;
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
        isGrounded = Physics.Raycast(transform.position, Vector3.down, 1.1f);

        if (Input.GetKey(KeyCode.D) && isGrounded)//地面にいるとき
        {
            rb.linearVelocity = new Vector3(1, 0, 0);
        }
        else if(Input.GetKey(KeyCode.D) && !isGrounded)//空中にいるとき
        {
            rb.linearVelocity = new Vector3(0.5f, 0, 0);
        }
    }
    void MoveLeft()
    {
        //Aキーを押すと左に動く
        isGrounded = Physics.Raycast(transform.position, Vector3.down, 1.1f);

        if (Input.GetKey(KeyCode.A) && isGrounded)//地面にいるとき
        {
            rb.linearVelocity = new Vector3(-1, 0, 0);
        }
        else if (Input.GetKey(KeyCode.A) && !isGrounded)//空中にいるとき
        {
            rb.linearVelocity = new Vector3(-0.5f, 0, 0);
        }
    }
    void Jump()
    {
        //Wキーでジャンプ
        isGrounded = Physics.Raycast(transform.position, Vector3.down, 1.1f);

        if (Input.GetKey(KeyCode.W) && isGrounded)
        {
            rb.linearVelocity = new Vector3(0, 9, 0);
        }
    }

    void Dash()
    {

    }

    //変装
    void Disguise()
    {

    }
}
