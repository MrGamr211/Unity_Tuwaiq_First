using UnityEngine;
using System;
using Unity.VisualScripting;
using UnityEditor;

public class Mice : MonoBehaviour
{
    public Camera looking;
    public Rigidbody body;
    void Start()
    {
       
        body = gameObject.GetComponent<Rigidbody>();
        // Look_X = Empty.transform.rotation;
        
    }

    
    public float sens = 1.0f;


    void Update()
    {
        Vector3 move = Input.mousePosition;
        looking.gameObject.transform.rotation = Quaternion.Euler(new Vector2(move.y * sens * -1, move.x * sens));
        //body.gameObject.transform.rotation = Quaternion.Euler(new Vector3(0, move.x * 0.01f, 0));

    }
    

}