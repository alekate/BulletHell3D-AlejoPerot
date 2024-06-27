using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float layerOffset = 0.5f;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject bullet = BulletPool.Instance.RequestBullet();

            if (bullet != null)
            {
                bullet.transform.position = transform.position + Vector3.forward * layerOffset;
            }
        }
    }
}
