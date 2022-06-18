using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magic1Con : MonoBehaviour
{
    BoxCollider2D magic1Range;
    SpriteRenderer magicSprite;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        magicSprite = GetComponent<SpriteRenderer>();
        magicSprite.enabled = false;
        anim = GetComponent<Animator>();
        magic1Range = GetComponent<BoxCollider2D>();
        magic1Range.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Magic1 박스 위치 좌우 걸을 때 변경
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.localPosition = new Vector3(4.0f, 1.0f, 0.0f);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.localPosition = new Vector3(-4.0f, 1.0f, 0.0f);
        }

        //Z키 누를 시에만 Magic1Range 박스 콜라이더 활성화
        if (Input.GetKeyUp(KeyCode.X))
        {
            anim.SetTrigger("Magic1");
            magic1Range.enabled = true;
            magicSprite.enabled = true;
            Invoke("AttackFalse", 1.0f);
        }
    }

    void AttackFalse()
    {
        magic1Range.enabled = false;
        magicSprite.enabled = false;
    }
}
