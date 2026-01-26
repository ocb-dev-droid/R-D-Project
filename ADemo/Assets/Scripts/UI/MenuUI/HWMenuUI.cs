using UnityEngine;
using UnityEngine.SceneManagement;

public class HWMenuUI : MonoBehaviour
{
    public void TutorialButton()
    {
        SceneManager.LoadSceneAsync("TutorialStage");
    }

    public void BackButton()
    {
        SceneManager.LoadSceneAsync("MainMenu");
    }
    public void StoreButton()
    {
        SceneManager.LoadScene("Store");
    }
    
    public void AdventureModeButton()
    {
        SceneManager.LoadSceneAsync("LevelSelect");

    }
    public void ArcadeModeButton()
    {
        SceneManager.LoadScene("Region1");
    }
}
