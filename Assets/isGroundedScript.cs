using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isGroundedScript : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log(transform.parent.GetComponent<PlayerControler>().nbJump);
        transform.parent.GetComponent<PlayerControler>().isGrounded = true;
        transform.parent.GetComponent<PlayerControler>().jumps = transform.parent.GetComponent<PlayerControler>().nbJump;
    }
    void OnTriggerExit2D(Collider2D col)
    {
        transform.parent.GetComponent<PlayerControler>().isGrounded = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
