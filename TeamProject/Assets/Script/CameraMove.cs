using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Transform targetChar;
    public float speed;
    private Vector3 targetPos;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(targetChar.gameObject != null)
        {
            targetPos.Set(targetChar.transform.position.x + 4.0f, targetChar.transform.position.y + 3.5f, this.transform.position.z);

            this.transform.position = Vector3.Lerp(this.transform.position, targetPos, speed * Time.deltaTime);

        }
    }
}
