using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationBody : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //좌우로 걸을 때 캐릭터 보여지는 이미지도 좌우반전
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        else if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }
}
