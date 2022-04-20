using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{

    public float bulletSpeed = 10f;
    public Rigidbody2D rg;



    // Start is called before the first frame update
    void Start()
    {
        Vector3 shootDirection;
        shootDirection = Input.mousePosition;
        shootDirection.z = 0.0f;
        shootDirection = Camera.main.ScreenToWorldPoint(shootDirection);
        shootDirection = shootDirection - transform.position;
        rg.velocity = transform.right * bulletSpeed;
        rg.velocity = new Vector2(shootDirection.x * bulletSpeed, shootDirection.y * bulletSpeed);

    }

    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Wall")
            Destroy(gameObject);
    }

}

