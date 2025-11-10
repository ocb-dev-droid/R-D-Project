using UnityEngine;
using UnityEngine.SceneManagement;

public class StoreUI : MonoBehaviour
{



    public void ExitButton()
    {
        SceneManager.LoadScene("HubWorld");
    }

}
