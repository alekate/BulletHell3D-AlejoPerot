using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float layerOffset = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            GameObject bullet = BulletPool.Instance.RequestBullet();

            if(bullet != null)
            {
                bullet.transform.position = transform.position + Vector3.forward * layerOffset;
            }
        }
    }
}