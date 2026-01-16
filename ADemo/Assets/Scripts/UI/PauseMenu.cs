using UnityEngine;
using UnityEngine.InputSystem;

public class PauseMenu : MonoBehaviour
{
    public GameObject PauseUI;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PauseUI.SetActive(false);
        Cursor.lockState = CursorLockMode .Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
       Input.GetKeyDown(KeyCode.Escape);
       
    }

    public void PauseGame()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Time.timeScale = 0;

}
