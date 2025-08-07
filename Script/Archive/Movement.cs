using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;
    public float Speed = 5;
    public float Jump = 100;
    // void Awake()
    // {
    //     Debug.Log("Awake");
    // }
    // Start is called before the first frame update
    void Start()
    {
        // Debug.Log("start");
        rb = gameObject.GetComponent<Rigidbody>();

        
    }
        bool IsGrounded()
    {
        return rb.linearVelocity.y == 0;
        // return Physics.Raycast(transform.position, -Vector3.up, 0.1f);
    }
    // Update is called once per frame
    void Update()
    {
        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");

        Vector3 Move = new Vector3(Horizontal, 0, Vertical);
        Vector3 Rotate_X = Input.mousePosition;

        rb.gameObject.transform.rotation = quaternion.Euler(new Vector3(0f, Rotate_X.x * 0.01f, 0f));
        rb.MovePosition(rb.position + Move * Speed * Time.fixedDeltaTime);


        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            rb.AddForce(Vector3.up * Jump, ForceMode.Impulse);
            // Debug.Log(IsGrounded());
        }
        // else
        // {
        //     Debug.Log(IsGrounded());
        // }

// }
    }
//     void LateUpdate()
//     {
//         Debug.Log("LateUpdate"); 
//     }
//     void FixedUpdate()
//     {
       
//             Debug.Log("FixedUpdate");
// } 
    
}