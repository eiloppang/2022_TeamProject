using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneMove : MonoBehaviour
{
    public GameObject[] barrierImages;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        foreach (var item in barrierImages)
        {
            item.transform.Rotate(0, 0, Time.deltaTime * speed * 5f, Space.Self);
        }
        this.transform.Translate(Vector3.right * Time.deltaTime * speed);

        Destroy(gameObject, 5.0f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject, 0.1f);
        }
    }
}
