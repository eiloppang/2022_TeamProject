using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatform : MonoBehaviour
{
    public GameObject cloud;
    float span;
    float delta;
    float timer;

    Rigidbody2D rb;

    void Start()
    {
        delta = 0.0f;
        timer = 3.0f;
        cloud.gameObject.SetActive(true);
        rb = GetComponent<Rigidbody2D>();

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(clouding());
            //cloud.gameObject.SetActive(false);
            //Invoke("falling", 3f);
            Invoke("Remake", 3f);
            // Destroy(gameObject, destroySec);
        }

    }

    void Remake()
    {
        //  span = Random.Range(3.0f, 5.0f);
        cloud.gameObject.SetActive(true);
    }

    IEnumerator clouding()
    {
        yield return new WaitForSeconds(2f);
        cloud.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
