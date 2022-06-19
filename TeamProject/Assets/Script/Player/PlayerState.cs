using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerState : MonoBehaviour
{
    //ÇÃ·¹ÀÌ¾î hp
    public Slider playerHP;
    public GameObject fillHP;
    //ÇÃ·¹ÀÌ¾î mp
    public Slider playerMP;
    public GameObject fillMP;

    Animator anim;

    public GameObject magicOne;
    public GameObject magicTwo;


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
            //¹º°¡ ÇÏ°ÚÁö...
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
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
            //¾À Ã¼ÀÎÁö
        }

        if (collision.gameObject.CompareTag("HPUP"))
        {
            playerHP.value += 0.2f;
        }
        else if (collision.gameObject.CompareTag("MPUP"))
        {
            playerMP.value += 0.2f;
        }

        if(collision.gameObject.CompareTag("DeadLine"))
        {
            //»ç¸Á¾À
        }
    }
}
