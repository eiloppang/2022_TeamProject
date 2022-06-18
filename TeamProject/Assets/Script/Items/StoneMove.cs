using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneMove : MonoBehaviour
{
    private Rigidbody2D rigid;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        rigid.velocity = new Vector3(speed, speed, 0);
    }

    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        speed = Random.Range(10.0f, 18.0f);
        Destroy(gameObject, 5.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject, 0.1f);
        }
    }
}
