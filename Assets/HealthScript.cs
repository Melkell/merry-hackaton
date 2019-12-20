using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthScript : MonoBehaviour
{
    public int hp = 1;
    public bool isEnemy = true;
    public GameObject Drop;    


    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D collider)
    {
        // Est-ce un tir ?
        ShotSprite shot = collider.gameObject.GetComponent<ShotSprite>();
        if (shot != null)
        {
            // Tir allié
            if (shot.isEnemyShot != isEnemy)
            {
                hp -= shot.damage;

                // Destruction du projectile
                // On détruit toujours le gameObject associé
                // sinon c'est le script qui serait détruit avec ""this""
                Destroy(shot.gameObject);

                if (hp <= 0)
                {
                    // Destruction !
                    Destroy(gameObject);
                    Instantiate(Drop, transform.position, transform.rotation);
                }
            }
        }
    }
}