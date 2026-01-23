using UnityEngine;
using UnityEngine.InputSystem;

public class ManageGS : MonoBehaviour
{
   bool isPaused = false;
    public GameObject PauseUI;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       UnPauseGame();
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.Escape))
        if (isPaused) UnPauseGame();
         else PauseGame();
        
    }

    public void UnPauseGame()
    {
        isPaused = false;
        Time.timeScale = 1;
        PauseUI.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    public void PauseGame()
    {
        PauseUI.SetActive(true);
        isPaused = true;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Time.timeScale = 0;

    }
}
