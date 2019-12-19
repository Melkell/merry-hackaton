using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotSprite : MonoBehaviour
{
    public int damage = 1;
    public bool isEnemyShot = false;

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, 20);
    }
}