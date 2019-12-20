using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chara_health : MonoBehaviour
{
    public int hp = 5;
    

    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D collider)
    {
        // Est-ce un tir ?
        Bullet shot = collider.gameObject.GetComponent<Bullet>();
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
