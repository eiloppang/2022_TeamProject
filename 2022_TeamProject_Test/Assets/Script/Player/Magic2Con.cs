using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magic2Con : MonoBehaviour
{
    BoxCollider2D magic2Range;
    SpriteRenderer magicSprite;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        magicSprite = GetComponent<SpriteRenderer>();
        magicSprite.enabled = false;
        anim = GetComponent<Animator>();
        magic2Range = GetComponent<BoxCollider2D>();
        magic2Range.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.localPosition = new Vector3(4.3f, 1.6f, 0.0f);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.localPosition = new Vector3(-4.3f, 1.6f, 0.0f);
        }

        //Z키 누를 시에만 Magic1Range 박스 콜라이더 활성화
        if (Input.GetKeyUp(KeyCode.C))
        {
            anim.SetTrigger("Magic2");
            magic2Range.enabled = true;
            magicSprite.enabled = true;
            Invoke("AttackFalse", 1.0f);
        }
    }
    void AttackFalse()
    {
        magic2Range.enabled = false;
        magicSprite.enabled = false;
    }
}
