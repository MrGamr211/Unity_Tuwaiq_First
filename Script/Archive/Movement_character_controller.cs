using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_character_controller : MonoBehaviour
{
    public CharacterController CC;
    public float Speed = 5;
    void Awake()
    {
        Debug.Log("Awake");
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start");
        CC = gameObject.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(Horizontal, 0, Vertical);
        CC.Move(movement * Speed * Time.deltaTime);
            Debug.Log("Update");

// }
    }
    void LateUpdate()
    {
        Debug.Log("LateUpdate"); 
    }
    void FixedUpdate()
    {
       
            Debug.Log("FixedUpdate");
} 
    
}