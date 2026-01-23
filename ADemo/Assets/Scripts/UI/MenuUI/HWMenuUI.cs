using UnityEngine;
using UnityEngine.SceneManagement;

public class HWMenuUI : MonoBehaviour
{
    public void TutorialButton()
    {
        SceneManager.LoadScene("TutorialStage");
    }

    public void BackButton()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void StoreButton()
    {
        SceneManager.LoadScene("Store");
    }
    
    public void AdventureModeButton()
    {
        SceneManager.LoadScene("LevelSelect");

    }
}
