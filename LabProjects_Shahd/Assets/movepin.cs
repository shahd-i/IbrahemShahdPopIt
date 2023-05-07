using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movepin : MonoBehaviour
{
    [SerializeField] float movement;
    [SerializeField] Rigidbody2D rigid;
    [SerializeField] const int SPEED = 15;
    [SerializeField] bool isFacingRight = true;
    // Start is called before the first frame update
    void Start()
    {
        if (rigid == null)
            rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxis("Horizontal");
        rigid.velocity = new Vector2(SPEED * movement, rigid.velocity.y);
        if (movement < 0 && isFacingRight || movement > 0 && !isFacingRight)
            Flip();

    }

    private void Flip()
    {
        transform.Rotate(0, 180, 0);
        isFacingRight = !isFacingRight;
    }
}
