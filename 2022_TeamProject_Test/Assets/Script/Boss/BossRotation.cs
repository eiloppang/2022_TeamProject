using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossRotation : MonoBehaviour
{
    public BossMove walkBoss;
    SpriteRenderer bossSprite;

    // Start is called before the first frame update
    void Start()
    {
        bossSprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(walkBoss.isLeft == false)
        {
            bossSprite.flipX = true;
        }
        else
        {
            bossSprite.flipX = false;
        }
    }
}
