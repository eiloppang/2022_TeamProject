using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GoalCondition : MonoBehaviour
{
    public PlayerState coinCount;
    
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
        if(coinCount.coinCount == 3)
        {
            SceneManager.LoadScene("main2");
        }
        else
        {
            //
        }
    }
}
