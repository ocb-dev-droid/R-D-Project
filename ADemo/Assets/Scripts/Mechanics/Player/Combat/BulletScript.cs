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
        Destroy(bulletobj);
    }
}
