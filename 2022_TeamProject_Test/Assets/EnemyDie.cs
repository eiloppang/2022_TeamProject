using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyDie : MonoBehaviour
{
    public Slider HPSlider;

    // Start is called before the first frame update
    void Start()
    {

        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("PAttack"))
            HPSlider.value -= 0.2f;

        if (collision.CompareTag("PMagicX"))
            HPSlider.value -= 0.3f;

        if (collision.CompareTag("PMagicC"))
            HPSlider.value -= 0.4f;
    }

    // Update is called once per frame
    void Update()
    {
        if(HPSlider.value <= 0)
        {
            Destroy(gameObject);
        }
        
    }

    
}
