using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerDeathMG : MonoBehaviour
{
    public GameObject DeathUI;

    public void Start()
    {
        DeathUI.SetActive(false);
    }
   
    public void killPlayer()
    {
        DeathUI.SetActive(true);
        Pointer.
    }
     public GameObject EnemyObject;
    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            killPlayer();
        }

    }

}
