using UnityEngine;
using UnityEngine.SceneManagement;

public class StageSelect : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void ReturntoMainMenu()
    {
        SceneManager.LoadScene("HubWorld");
    }

    public void CS1()
    {
        SceneManager.LoadScene("Region1");
    }

    public void CS2()
    {
        SceneManager.LoadScene("Region2");
    }

    public void CS3()
    {
        SceneManager.LoadScene("Region3");
    }

    public void CS4()
    {
        SceneManager.LoadScene("Region4");
    }
}
