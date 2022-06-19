using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostEnemyMove : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rigid;
    Animator anim;
    SpriteRenderer spriteRenderer;
    public int nextMove;

    // Start is called before the first frame update
    void Awake()
    {
        // HPSlider = GameObject.Find("RockEnemy/Canvas/HPSlider");
        rigid = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        Think();

        Invoke("Think", 2);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rigid.velocity = new Vector2(nextMove, rigid.velocity.y);
        // HPSlider.transform.position = Camera.main.WorldToScreenPoint(transform.position + new Vector3(0, 1.2f, 0));
    }

    void Think()
    {
        nextMove = Random.Range(-1, 2);

        anim.SetTrigger("disappear");

        if (nextMove != 0)
            spriteRenderer.flipX = nextMove == 1;

        float nextThinkTime = Random.Range(2f, 5f);
        Invoke("Think", nextThinkTime);
    }
}
