using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject EnemyMain;
    public int StartingHealth;
    int health;
    public Shoot shoot;
   public void CastdamageEnemy()
    {
        health = health - shoot.PlayerPWR;
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
