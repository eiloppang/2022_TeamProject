using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMove : MonoBehaviour
{
    public float speed;
    public bool isLeft = true;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

   private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("EndPoint"))
        {
            if (isLeft)
            {
                
                transform.localEulerAngles = new Vector3(0, 180, 0);
                transform.localPosition = new Vector2(this.transform.position.x - 0.5f, this.transform.position.y);
                isLeft = false;
            }
            else
            {
                transform.localEulerAngles = new Vector3(0, 0, 0);
                transform.localPosition = new Vector2(this.transform.position.x + 0.5f, this.transform.position.y);
                isLeft = true;
            }
        }
    }
}
