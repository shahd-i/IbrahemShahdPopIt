//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;


//public class enemy : MonoBehaviour
//{
  
//    private Rigidbody2D rb;
//    //[SerializeField] private GameObject redParticles;
//    public float health;
//    public float speed;

//    public void TakeDamage(float damage)
//    {
//        health -= damage;
//        if (health <= 0)
//        {
//            //Instantiate(redParticles, transform.position, transform.rotation);
//            Destroy(gameObject);
//        }
//    }

//    // Start is called before the first frame update
//    void Start()

//    {
//        rb = GetComponent<Rigidbody2D>();

        
//    }

//    // Update is called once per frame
//   private void FixedUpdate()
//    {
//        rb.velocity = new Vector2(speed, rb.velocity.y);
        
//    }
//}
