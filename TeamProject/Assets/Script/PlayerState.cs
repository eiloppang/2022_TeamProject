using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerState : MonoBehaviour
{
    //플레이어 hp
    public Slider playerHP;
    public GameObject fillHP;
    //플레이어 mp
    public Slider playerMP;
    public GameObject fillMP;

    Animator anim;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        fillHP.SetActive(true);
        fillMP.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if(playerMP.value > 0)
        {
            if (Input.GetKeyDown(KeyCode.X))
            {
                playerMP.value = -0.1f;
            }

            if (Input.GetKeyDown(KeyCode.C))
            {
                playerMP.value = -0.2f;
            }
        }
        else if(playerMP.value <= 0)
        {
            fillMP.SetActive(false);
            //뭔가 하겠지...
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(playerHP.value > 0)
        {
            if (collision.gameObject.CompareTag("Enemy"))
            {
                playerHP.value -= 0.1f;
            }
            else if (collision.gameObject.CompareTag("Obstacle"))
            {
                playerHP.value -= 0.05f;
            }
        }
        else if(playerHP.value <= 0)
        {
            fillHP.SetActive(false);
            anim.SetTrigger("IsDead");
            //씬 체인지
        }
    }
}
