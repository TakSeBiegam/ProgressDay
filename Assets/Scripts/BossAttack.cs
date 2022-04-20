using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAttack : MonoBehaviour
{
    public float BossAttackCoooldown = 2f;
    public float sinceLastShoot;

    public GameObject bulletPrefab;
    public Transform firePoint;
    public Transform PlayerPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        sinceLastShoot += Time.deltaTime;
        if(BossAttackCoooldown < sinceLastShoot)
        {
            Debug.LogError("Shooted boss");
            sinceLastShoot = 0;
            gameObject.transform.LookAt(PlayerPoint.position);
            Instantiate(bulletPrefab, firePoint.position, PlayerPoint.rotation);

        }
    }
}
