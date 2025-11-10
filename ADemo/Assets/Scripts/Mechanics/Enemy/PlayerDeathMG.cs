using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeathMG : MonoBehaviour
{
    public GameObject EnemyObject;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            SceneManager.LoadScene("Limbo");
        }

    }

}
