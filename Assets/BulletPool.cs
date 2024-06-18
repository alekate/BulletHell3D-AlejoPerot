using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPool : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private int poolSize = 10;
    [SerializeField] private List<GameObject> bulletList = new List<GameObject>(); // Initialize the list

    // Singleton
    private static BulletPool instance;
    public static BulletPool Instance { get { return instance; } }

    private void Awake() 
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        AddBulletsToPool(poolSize); // poolSize is passed as "amount"
    }

    private void AddBulletsToPool(int amount) // amount because it counts the instances added to the list
    {
        // Instantiate the bullet prefabs and add them to the pool
        for (int i = 0; i < amount; i++)
        {
            GameObject bullet = Instantiate(bulletPrefab);
            bullet.SetActive(false);
            bulletList.Add(bullet);
            bullet.transform.parent = transform;
        }
    }

    public GameObject RequestBullet()
    {
        for (int i = 0; i < bulletList.Count; i++) // Changed laserList to bulletList
        {
            if (!bulletList[i].activeSelf) // Verifies if the element in the list is NOT active (uses !)
            {
                bulletList[i].SetActive(true); // Activates it
                return bulletList[i]; // Returns it
            }
        }
        return null; // Moved return statement outside the loop
    }
}
