using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    int resWidth = 1920;
    int resLen = 1080;
    public void StartButton()
    {
        SceneManager.LoadScene("HubWorld");
     }

    public void QuitButton()
    {
        Application.Quit();
    }

}
