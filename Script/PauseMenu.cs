using NUnit.Framework;
using UnityEditor;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public ScriptableObject Player;
    public ScriptableObject Camera;
    private bool IsPaused = false;

    // void Start()
    // {

    // }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && IsPaused == false)
        {
            IsPaused = true;
            Debug.Log(IsPaused);
        }
        if (Input.GetKeyDown(KeyCode.Escape) && IsPaused == true)
        {
            IsPaused = false;
            Debug.Log(IsPaused);
        }
        
        if (IsPaused == false)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        if (IsPaused == true)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }
}
