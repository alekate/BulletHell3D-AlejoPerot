using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float bulletSpeed = 5f;
    [SerializeField] private Rigidbody bulletRB;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnEnable()
    {
        bulletRB.velocity = Vector3.forward * bulletSpeed;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Bullet>() == null)
        {
            gameObject.SetActive(false);
            //crear metodo que return la bullet en pool script
        }
        
    }
}
