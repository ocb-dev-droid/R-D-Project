using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject EnemyMain;
    public int StartingHealth;
    int health;
    public Shoot shoot;
   public void CastdamageEnemy()
    {
        Debug.Log("Hit");
        health = health - shoot.PlayerPWR;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "bullet")
        {
            CastdamageEnemy();
        }
    }
    void Start()
    {
        health = StartingHealth;
    }

    public void EnemyBrain()
    {
        if (health < 1 )
        {
            Destroy(EnemyMain);
        }
    }



   
    void Update()
    {
        EnemyBrain();  
    }
}
