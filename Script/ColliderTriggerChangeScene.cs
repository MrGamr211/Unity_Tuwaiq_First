using Unity.VisualScripting;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Windows;

public class ColliderTriggerChangeScene : MonoBehaviour
{
    public string SceneName;
    void Start()
    {
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") 
        {
            SceneManager.LoadScene(SceneName);
        }
        else
        {
            // WhiteList
        }
    }

// this code are taken from this video (https://youtube.com/shorts/qCKmtIKmRyQ?si=Vb5KhQPRKor-bghq)
    // public void LoadSceneByName()
    // {
    //     SceneManager.LoadScene("SandBox");
    // }
    // public void LoadNextInBuild()
    // {
    //     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    // }
}
