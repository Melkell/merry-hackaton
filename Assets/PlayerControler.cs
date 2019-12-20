using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public int speed = 7, jump = 300, nbJump = 2;
    public int jumps;
    public bool grounded = true;
    public bool isGrounded = false;
    private bool isJumping = false;
    public GameObject bullet;
    public GameObject effect;
    private bool isKeysEnabled = false;


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
        {   //saut
            Jump();
            
            

        }

        void Jump()
        {
            if (jumps > 0)
            {
                // jump
                Debug.Log("jumps " + jumps + "--- Maxjumps " + nbJump);
                jumps = jumps - 1;
                GetComponent<Rigidbody2D>().velocity = Vector2.up * jump * Time.deltaTime;
                //anim
                GameObject s = (GameObject)(Instantiate(effect, transform.position - new Vector3(1.4f, -0.3f, 0.0f) + transform.right * 1.5f, Quaternion.identity));
                Destroy(s, 0.25f);

            }
            if (jumps == 0)
            {
                return;
            }
        }

    }


}