using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera2 : MonoBehaviour
{
    //ÂÑ¾Æ´Ù´Ò Å¸°Ù
    public Transform targetChar;
    //¾ó¸¶ÀÇ ¼Óµµ·Î ÂÑ¾Æ¿Ã°ÇÁö
    public float speed;
    //Å¸°ÙÀÇ À§Ä¡ º¤ÅÍ°ª
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
