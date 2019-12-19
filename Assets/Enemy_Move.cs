using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Move : MonoBehaviour
{
    public float speed;

    public bool MoveRight;


    // Update is called once per frame
    void Update()
    {
       // if MoveRight bool is true mean enemy will go to the right
       if(MoveRight)
        {
            transform.Translate(2 * Time.deltaTime * speed, 0, 0);
            transform.localScale = new Vector2(1, 1);
        }
       else
        {
            transform.Translate(-2 * Time.deltaTime * speed, 0, 0);
            transform.localScale = new Vector2(-1, 1);
        }
    }
}
