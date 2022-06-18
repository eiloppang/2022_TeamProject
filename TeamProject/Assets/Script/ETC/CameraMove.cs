using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    //쫓아다닐 타겟
    public Transform targetChar;
    //얼마의 속도로 쫓아올건지
    public float speed;
    //타겟의 위치 벡터값
    private Vector3 targetPos;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //플레이어 캐릭터를 쫓아다니는 카메라 x위치는 앞부분이 더 보일 수 있도록 4.0정도 앞으로, y위치는 위부분이 더 보일 수 있도로 2.5위로.
        if(targetChar.gameObject != null)
        {
            targetPos.Set(targetChar.transform.position.x + 4.0f, targetChar.transform.position.y + 1.5f, this.transform.position.z);

            this.transform.position = Vector3.Lerp(this.transform.position, targetPos, speed * Time.deltaTime);

        }
    }
}
