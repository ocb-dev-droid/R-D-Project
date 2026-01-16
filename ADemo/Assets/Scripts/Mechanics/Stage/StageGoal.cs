using UnityEngine;
using UnityEngine.SceneManagement;

public class StageGoal : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        SceneManager.LoadScene("LevelComplete");
    }
}
