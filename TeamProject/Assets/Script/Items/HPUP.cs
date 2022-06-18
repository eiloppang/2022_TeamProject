using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPUP : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            //소리나기
            //가능하면 이펙트도...?
            Destroy(gameObject);
        }
    }
}
