using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerState : MonoBehaviour
{
    //플레이어 hp
    public Slider playerHP;
    public GameObject fillHP;
    public GameObject hpText;

    Animator anim;

    public GameObject magicOne;
    public GameObject magicTwo;

    public int coinCount;
    public Text coinCountText;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        fillHP.SetActive(true);

        coinCount = 0;
        coinCountText.text = "X " + coinCount;
    }

    // Update is called once per frame
    void Update()
    {
        playerHP.transform.position = Camera.main.WorldToScreenPoint(transform.position + new Vector3(0, 4.0f, 0));
        hpText.transform.position = Camera.main.WorldToScreenPoint(transform.position + new Vector3(0, 4.0f, 0));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (playerHP.value > 0)
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
        else if (playerHP.value <= 0)
        {
            fillHP.SetActive(false);
            anim.SetTrigger("IsDead");
            Invoke("MoveToFail", 1.5f);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (playerHP.value > 0)
        {
            if (collision.gameObject.CompareTag("Candy"))
            {
                playerHP.value -= 0.1f;
            }
            if (collision.gameObject.CompareTag("Stone"))
            {
                playerHP.value -= 0.05f;
            }
        }
        else if (playerHP.value <= 0)
        {
            fillHP.SetActive(false);
            anim.SetTrigger("IsDead");
            Invoke("MoveToFail", 1.0f);
        }

        if (collision.gameObject.CompareTag("HPUP"))
        {
            playerHP.value += 0.2f;
        }

        if(collision.gameObject.CompareTag("Coin"))
        {
            coinCount = coinCount + 1;
            coinCountText.text = "X " + coinCount;
        }

        if(collision.gameObject.CompareTag("DeadLine"))
        {
            SceneManager.LoadScene("Fail");
        }
    }

    void MoveToFail()
    {
        SceneManager.LoadScene("Fail");
    }
}
