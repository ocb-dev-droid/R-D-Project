using System.Collections;
using UnityEngine;


public class Telepoints : MonoBehaviour
{

    public GameObject Telepoint1;
    public GameObject Telepoint2;
    public bool cooldown;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject == Telepoint1 && !cooldown)
        {
            this.gameObject.transform.position = Telepoint2.transform.position;
            cooldown = true;
            StartCoroutine(timer());
        }
        else if (collision.gameObject == Telepoint2 && !cooldown)
        {
            this.gameObject.transform.position = Telepoint1.transform.position;
            cooldown = true;
            StartCoroutine(timer());
        }
    }
    public IEnumerator timer()
    {
        yield return new WaitForSeconds(2);
        cooldown = false;
    }
}