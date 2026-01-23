using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public Rigidbody bullet;
    public GameObject bulletobj;
    int bulletSpeed = 5;
    public EnemyManager enemyManager;
    // Update is called once per frame
    void Update()
    {
        bullet.AddForce(transform.forward * bulletSpeed);
    }
    private void OnCollisionEnter(Collision collision)
    {
      if(collision.gameObject.tag == "enemy")
        {
            enemyManager = collision.gameObject.GetComponent<EnemyManager>();
            enemyManager.CastdamageEnemy();
            Destroy(bulletobj);
        }
      else Destroy(bulletobj);
    }
}
