using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackRange : MonoBehaviour
{
    BoxCollider2D attacktRange;

    // Start is called before the first frame update
    void Start()
    {
        attacktRange = GetComponent<BoxCollider2D>();
        attacktRange.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Attack 박스 위치 좌우 걸을 때 변경
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.localPosition = new Vector3(1.15f, 1.71f, 0.0f);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.localPosition = new Vector3(-1.15f, 1.71f, 0.0f);
        }

        //Z키 누를 시에만 AttackRange 박스 콜라이더 활성화
        if (Input.GetKeyUp(KeyCode.Z))
        {
            attacktRange.enabled = true;
            Invoke("AttackFalse", 0.5f);
        }
    }

    //0.5초 후 활성화 false
    void AttackFalse()
    {
        attacktRange.enabled = false;
    }
}
