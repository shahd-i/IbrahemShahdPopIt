using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    [SerializeField] float movement;
    [SerializeField] Rigidbody2D rigid;
    [SerializeField] bool isFacingRight = true;
    [SerializeField] const int SPEED = 15;
    [SerializeField] private float currScale = 1.0f;
    [SerializeField]  float maxScale = 1.0f;
    [SerializeField] float growthRate = 0.5f;



    public float min = 1f;
    public float max = 10f;
    //public double size;
    [SerializeField] int points = 0;
    // Start is called before the first frame update


    public GameManager GM;
    public AudioClip popclip;
    public int score;
    [SerializeField] int sizeMod = 0;

    void Start()
    {

        min = transform.position.x-7;
        max = transform.position.x + 7;
        InvokeRepeating("Grow", 2.0f, 2.0f);

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.PingPong(Time.time * 2, max - min) + min, transform.position.y, transform.position.z);
        if (movement < 0 && isFacingRight || movement > 0 && !isFacingRight)
            Flip();
    }


    private void Flip()
    {
        transform.Rotate(0, 180, 0);
        isFacingRight = !isFacingRight;
    }

    private void Grow()
    {
        currScale += growthRate * 0.1f;
        currScale = Mathf.Min(currScale, maxScale);
        transform.localScale = new Vector3(currScale, currScale, 1.0f);
        //size += 0.1;
        //transform.localScale = new Vector3((float)size, (float)size, transform.localScale.z);
        //points += 1;
        if (currScale < maxScale)
        {
            sizeMod += 1;
        }
        if (currScale >= maxScale)
        {
            AudioSource.PlayClipAtPoint(popclip, transform.position);
            GameObject controller = GameObject.FindGameObjectWithTag("GameController");
            Destroy(gameObject, 3f);
             sizeMod = 6;
            controller.GetComponent<GameManager>().AdvanceScene();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.CompareTag("Pin"))
        {
            AudioSource.PlayClipAtPoint(popclip, transform.position);
            Debug.Log("collision");
        
 




            GameObject controller = GameObject.FindGameObjectWithTag("GameController");

            controller.GetComponent<Scorekeeper>().AddPoints(6 - (sizeMod / 3));
            

            score = PersistentData.Instance.GetScore();




            Destroy(collision.gameObject);

            Destroy(gameObject,5.0f);
            controller.GetComponent<Scorekeeper>().AdvanceScene();
        }

        





    }
}
