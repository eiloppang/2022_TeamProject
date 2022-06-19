using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAttack : MonoBehaviour
{
    public GameObject[] Barrier;
    private float spownTime;
    private float randomAttack;
    public BossAnim bossScript;

    // Start is called before the first frame update
    void Start()
    {
        bossScript = GameObject.Find("Little_Cat_GirlRig").GetComponent<BossAnim>();
        spownTime = Random.Range(1.0f, 3.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (bossScript.isAttack && !bossScript.isHit)
        {
            spownTime -= Time.deltaTime;
            if (spownTime <= 0)
            {
                spownTime = Random.Range(3.0f, 8.0f);

                if (spownTime >= 5.0f)
                {
                    Instantiate(Barrier[0], this.transform.position, Quaternion.identity);
                }
                else
                {
                    if (Random.Range(1, 3) == 1)
                    {
                        Instantiate(Barrier[1], this.transform.position, Quaternion.identity);
                    }
                    else
                    {
                        Instantiate(Barrier[2], this.transform.position, Quaternion.identity);
                    }
                }
            }
        }
    }
}
