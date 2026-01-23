using UnityEngine;

public class Shoot : MonoBehaviour
{
    public int PlayerPWR = 5;
    public GameObject bullet;
    public GameObject bulletSpawn;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject.Instantiate(bullet, bulletSpawn.transform.position, bulletSpawn.transform.rotation);
        }
    }
}
