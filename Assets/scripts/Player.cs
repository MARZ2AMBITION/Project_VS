using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int PlayerSpd;
    Rigidbody2D rb;
    public Vector2 moveDir;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        InpuManager();
    }
    void FixedUpdate()
    {
        Move();
    }
    void InpuManager()
    {
        float movex = Input.GetAxisRaw("Horizontal");
        float movey = Input.GetAxisRaw("vertical");

        moveDir = new Vector2(movex,movey).normalized;

    }
    void Move()
    {
        rb.velocity = new Vector2(moveDir.x * PlayerSpd, moveDir.y * PlayerSpd);
    }
}
