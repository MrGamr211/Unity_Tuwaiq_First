using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.ProBuilder.MeshOperations;

public class Movement1 : MonoBehaviour
{
    public Rigidbody rb;
    public float Speed = 3;
    public float Jump = 8;
    void Awake()
    {
        Debug.Log("Awake");
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start");
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


        //rb.gameObject.transform.rotation = quaternion.Euler(new Vector3(0, Rotate_X.x * 0.01f, 0));
        rb.MovePosition(rb.position + Move * Speed * Time.fixedDeltaTime);


        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            rb.AddForce(Vector3.up * Jump, ForceMode.Impulse);
            Debug.Log(IsGrounded());
        }
        else
        {
            Debug.Log(IsGrounded());
        }
        if (Input.GetKey(KeyCode.Mouse0))
        {
            rb.gameObject.transform.rotation = quaternion.Euler(new Vector3(0, 80, 0));
        }
        else if (Input.GetKey(KeyCode.Mouse1))
        {
            rb.gameObject.transform.rotation = quaternion.Euler(new Vector3(0, -80, 0));
        }
        else
        {
            rb.gameObject.transform.rotation = quaternion.Euler(new Vector3(0, 0, 0));


        }
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