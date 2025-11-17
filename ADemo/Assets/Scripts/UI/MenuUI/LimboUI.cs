using UnityEngine;
using UnityEngine.SceneManagement;

public class LimboUI : MonoBehaviour
{
    public string currentStage;
    public void ReturnButton()
    {
        SceneManager.LoadScene("Hubworld");
    }

    public void ReviveButton()
    {
        SceneManager.LoadScene(currentStage);
    }

}
