using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeathMG : MonoBehaviour
{
    public GameObject DeathUI;

    public void Start()
    {
        DeathUI.SetActive(false);
    }
   
    public void KillPlayer()
    {
        DeathUI.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
     public GameObject EnemyObject;
    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            KillPlayer();
        }

    }

}
