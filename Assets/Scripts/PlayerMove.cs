using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public GameManager gameManager;
    public Rigidbody rbody;
    public Vector3 moveDir;
    public float moveSpeed;

    void Update()
    {
        moveDir = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        moveDir.Normalize();
    }

    void FixedUpdate()
    {
        rbody.MovePosition(rbody.position + moveDir*moveSpeed);
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.GetComponent<Coin>() != null)
        {
            gameManager.GotCoin();
            Destroy(collision.gameObject);
        }
    }
}
