using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacBehaviour : MonoBehaviour
{
    public int speed = 7, jump = 300;
    public bool isJumping = false;
    public GameObject bullet;
    private bool isKeysEnabled  = false;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.right * h * speed * Time.deltaTime);

        if (h > 0) GetComponent<SpriteRenderer>().flipX = false;
        //if (h < 0) GetComponent<SpriteRenderer>().flipX = true;

        // tirer
        if (Input.GetKeyDown(KeyCode.Space))

        {

            GameObject b = (GameObject)(Instantiate(bullet, transform.position  + transform.right * 1.5f, Quaternion.identity));
            //GameObject b = (GameObject)(Instantiate(bullet, transform.y - 1  + transform.right * 1.5f, Quaternion.identity));

            b.GetComponent<Rigidbody2D>().AddForce(transform.right * 300);

        }

    }

    void FixedUpdate()
    {   //sauter
        if (Input.GetButtonDown("Jump"))
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.up * jump * Time.deltaTime;
        }
    }
}