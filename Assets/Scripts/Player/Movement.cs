using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Movement : MonoBehaviour
{
    private Vector2 moveDirection;
    public float moveSpeed = 0f;
    public Rigidbody2D rg;
    //Player
    private bool player_FacingRight = true;

    //Shooting
    private float CooldownToShoot = 1f;
    private float timeSinceLastShoot = 0f;

    //Bullet
    public Transform firePoint;
    public GameObject bulletPrefab;

    //Equipment
    public bool isPlayerHaveSword;
    public bool isPlayerHaveCape;

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        InputProcess();

        if (Input.GetKey(KeyCode.Space) && timeSinceLastShoot > CooldownToShoot)
        {
            timeSinceLastShoot = 0;
            Shoot();
        }

        timeSinceLastShoot += Time.deltaTime;
    }

    private void FixedUpdate()
    {
        Move();
    }

    void InputProcess()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector2(moveX, moveY);

        if (moveX > 0 && !player_FacingRight)
        {
            Flip();
        }
            

        if (moveX < 0 && player_FacingRight)
        {
            Flip();
        }
    }

    void Move()
    {
        rg.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
    }

    private void Flip()
    {
        player_FacingRight = !player_FacingRight;
        transform.Rotate(0f, 180f, 0f);
    }

    private void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
