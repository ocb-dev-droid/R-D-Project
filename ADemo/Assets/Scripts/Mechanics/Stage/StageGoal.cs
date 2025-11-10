using UnityEngine;
using UnityEngine.SceneManagement;

public class StageGoal : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        SceneManager.LoadScene("LVLComplete");
    }
}
