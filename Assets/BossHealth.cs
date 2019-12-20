using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHealth : MonoBehaviour
{
    public int hp = 10;


    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D collider)
    {
        // Est-ce un tir ?
        ShotSprite shot = collider.gameObject.GetComponent<ShotSprite>();
        if (shot != null)
        {

            hp -= shot.damage;
            Debug.Log(shot);

            // Destruction du projectile
            // On détruit toujours le gameObject associé
            // sinon c'est le script qui serait détruit avec ""this""
            Destroy(shot.gameObject);

            if (hp <= 0)
            {
                // Destruction !
                Destroy(gameObject);
            }

        }
    }
}
