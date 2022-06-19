using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera2 : MonoBehaviour
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
        if (targetChar.gameObject != null)
        {
            targetPos.Set(targetChar.transform.position.x - 4.0f, targetChar.transform.position.y + 1.0f, this.transform.position.z);

            this.transform.position = Vector3.Lerp(this.transform.position, targetPos, speed * Time.deltaTime);

        }
    }
}
