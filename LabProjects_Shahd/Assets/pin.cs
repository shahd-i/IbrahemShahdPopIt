using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class pin : MonoBehaviour
{
 
    private Rigidbody2D rb;
    public float speed;
 

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed;
        


    }

    //private void OnTriggerEnter2D(Collider2D collision)
    //{

    //    if (collision.gameObject.tag == "balloon")
    //    {
            
    //        Debug.Log("collision");
    //        AudioSource.PlayClipAtPoint(popclip, transform.position);
            


       
    //        GameObject controller = GameObject.FindGameObjectWithTag("GameController");
    //        //controller.GetComponent<GameManager>().PopBalloon(5-(sizeMod/3));

    //        //if (collision.gameObject.transform.localScale.x < 1f)
    //        //{
    //        //
    //        //    Debug.Log("point1");
    //        //}


    //        //else if (collision.gameObject.transform.localScale.x < 1.5f)
    //        //{
    //        //    controller.GetComponent<GameManager>().PopBalloon(3);
    //        //    Debug.Log("point2");
    //        //}
    //        //else if (collision.gameObject.transform.localScale.x < 1.75f)
    //        //{
    //        //    controller.GetComponent<GameManager>().PopBalloon(3);
    //        //    Debug.Log("point3");
    //        //}



    //        Destroy(collision.gameObject);
    //        //GM.PopBalloon();
    //        Destroy(gameObject,3f);
 

           

     


    

}
