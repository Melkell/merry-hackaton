using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public int speed = 7, jump = 300;
    public bool isJumping = false;
    public GameObject bullet;


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
        if (h < 0) GetComponent<SpriteRenderer>().flipX = true;

        if (Input.GetKeyDown(KeyCode.Keypad1))

        {

            GameObject b = (GameObject)(Instantiate(bullet, transform.position + transform.right * 1.5f, Quaternion.identity));

            b.GetComponent<Rigidbody2D>().AddForce(transform.right * 50);

        }

    }

    void FixedUpdate()
    {
        if(Input.GetButtonDown("Jump"))
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.up * jump * Time.deltaTime;
        }
    }
}
