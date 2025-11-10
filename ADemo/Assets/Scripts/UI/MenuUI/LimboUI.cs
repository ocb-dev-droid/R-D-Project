using UnityEngine;
using UnityEngine.SceneManagement;

public class LimboUI : MonoBehaviour
{
    public void ReturnButton()
    {
        SceneManager.LoadScene("HubWorld");
    }

}
