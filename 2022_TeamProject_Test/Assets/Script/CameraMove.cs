using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    //�Ѿƴٴ� Ÿ��
    public Transform targetChar;
    //���� �ӵ��� �Ѿƿð���
    public float speed;
    //Ÿ���� ��ġ ���Ͱ�
    private Vector3 targetPos;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //�÷��̾� ĳ���͸� �Ѿƴٴϴ� ī�޶� x��ġ�� �պκ��� �� ���� �� �ֵ��� 4.0���� ������, y��ġ�� ���κ��� �� ���� �� �ֵ��� 2.5����.
        if(targetChar.gameObject != null)
        {
            targetPos.Set(targetChar.transform.position.x + 4.0f, targetChar.transform.position.y + 1.5f, this.transform.position.z);

            this.transform.position = Vector3.Lerp(this.transform.position, targetPos, speed * Time.deltaTime);

        }
    }
}
