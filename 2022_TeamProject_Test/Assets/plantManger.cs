using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plantManger : MonoBehaviour
{
    public GameObject bullet;
    float timer;
    float waitTime;
    // Start is called before the first frame update
    void Start()
    {
        waitTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer = Random.Range(3.0f, 6.0f);
        waitTime += Time.deltaTime;

        if(waitTime >= timer)
        {
            waitTime = 0;
            Instantiate(bullet, new Vector2(this.transform.position.x, this.transform.position.y), transform.rotation);

        }
        
    }
}
