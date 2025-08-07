using UnityEngine;

public class Player_Movement_0 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // void Start()
    // {

    // }

    // Update is called once per frame

    public float Speed = 10.0f;
    public float Jump = 10.0f;
    void Update()
    {
        //All if statement are W-A-S-D Movement
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.forward * Speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.back * Speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * Speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * Speed * Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.position += Vector3.up * Jump * Time.deltaTime;
        }
    }
}
