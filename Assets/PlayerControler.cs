using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public int speed = 7, jump = 300;
    public bool isJumping = false;
    public GameObject bullet;
    public GameObject effect;
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

            //GameObject b = (GameObject)(Instantiate(bullet, transform.position  + transform.right * 1.5f, Quaternion.identity));
            
            //newVector3 is here to ensure that the bullet comes out from the gun
            GameObject b = (GameObject)(Instantiate(bullet, transform.position - new Vector3(0.3f, 0.38f, 0.0f) + transform.right * 1.5f, Quaternion.identity));

            b.GetComponent<Rigidbody2D>().AddForce(transform.right * 300);

        }

    }

    void FixedUpdate()
    {   //sauter
        if (Input.GetButtonDown("Jump"))
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.up * jump * Time.deltaTime;
            //GameObject s = (GameObject)(Instantiate(effect, transform.position - new Vector3(1.4f, 0.2f, 0.0f) + transform.right * 1.5f, Quaternion.identity)); will see later for jump animation

            

    


}