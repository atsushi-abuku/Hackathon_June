using Unity.VisualScripting;
using UnityEngine;

public class MovingFloor : MonoBehaviour
{
    private Vector2 initialPosition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(Mathf.Sin(Time.time) * 2.0f + initialPosition.x, initialPosition.y);


    }
}