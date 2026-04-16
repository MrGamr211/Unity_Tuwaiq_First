using UnityEngine;
using TMPro;
using UnityEngine.Events;
public class Display_Coins : MonoBehaviour
{
    public TextMeshProUGUI numUiCoins;
    public CharMovement monitor_UiCoins;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        numUiCoins.text = "Coins: " + monitor_UiCoins.UiCoins;
        // if (Input.GetButtonDown("Jump"))
        // {
        //     Debug.Log("Update/n");
        //     Debug.Log(monitor_UiCoins.UiCoins);
        // }
    }
}
