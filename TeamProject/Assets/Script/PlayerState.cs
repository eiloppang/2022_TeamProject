using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerState : MonoBehaviour
{
    //플레이어 hp
    public Slider plyerHP;
    //플레이어 mp
    public Slider playerMP;
    
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
        if(collision.gameObject.CompareTag("Enemy"))
        {
            playerMP.value -= 0.1f;
        }
        else if(collision.gameObject.CompareTag("Obstacle"))
        {
            playerMP.value -= 0.05f;
        }
    }
}
