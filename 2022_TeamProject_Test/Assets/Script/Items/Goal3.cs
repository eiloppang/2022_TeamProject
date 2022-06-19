using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Goal3 : MonoBehaviour
{
    public PlayerState coinCount;

    public Slider bossHP;

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
        if(bossHP.value <= 0)
        {
            if (coinCount.coinCount == 5)
            {
                SceneManager.LoadScene("Sucess");
            }
            else
            {
                //
            }
        }
    }
}
