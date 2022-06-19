using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossAnim : MonoBehaviour
{
    Animator anim;

    float randomCount;
    float timer;

    bool isRandomAnimationPermit = true; // 공격 애니메이션 랜덤결정을 한번만 하게 하는 변수
    [HideInInspector] public bool isBreakAttackAnimation = true; // 공격 애니메이션 진행할 수 있는지 확인하는 변수

    public bool isAttack, isBreak, isHit;

    bool isHitAnimation = false; //보스 맞았는지 확인하는 변수

    public Slider hpSlider;   //보스 hp 0 됐을 때 사망 애니메이션
    public GameObject hpFill;
    float deadTimer;
    float waitTime;

    //public float speed;
    //bool isLeft = true;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        timer = 0;
        randomCount = Random.Range(3.0f, 7.0f);

        deadTimer = 1.5f;
        waitTime = 0.0f;

        hpFill.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Vector2.left * speed * Time.deltaTime);

        if(hpSlider.value != 0.0f)
        {
            CatBossAnimation();
        }
        else if(hpSlider.value <= 0.0f)
        {
            hpFill.SetActive(false);
            anim.SetTrigger("IsDead");
            isBreak = false;
            isAttack = false;
            isHit = false;
            waitTime += Time.deltaTime;
            if(waitTime >= deadTimer)
            {
                Destroy(gameObject);
            }
        }
    }

    private void CatBossAnimation()
    {
        if (isBreakAttackAnimation == true)
        {
            timer += Time.deltaTime;
            if (timer >= 3.0f)
            {
                timer = 0.0f;
                if (isRandomAnimationPermit == true)
                {
                    if (!(Random.Range(1, 4) == 1))
                    {
                        anim.SetTrigger("IsAttack");
                        isBreak = false;
                        isAttack = true;
                        isHit = false;
                    }
                    else
                    {
                        anim.SetTrigger("IsBreak");
                        isBreak = true;
                        isAttack = false;
                        isHit = false;
                    }
                }
            }
        }
        else
        {
            timer = 0.0f;
            if (isHitAnimation == true)
            {
                anim.SetTrigger("IsHit");
                isBreak = false;
                isAttack = false;
                isHit = true;
                isHitAnimation = false;
                isBreakAttackAnimation = true;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("PAttack"))
        {
            isHitAnimation = true;
            isBreakAttackAnimation = false;
            hpSlider.value -= 0.05f;
        }
        else if(collision.gameObject.CompareTag("PMagicX"))
        {
            isHitAnimation = true;
            isBreakAttackAnimation = false;
            hpSlider.value -= 0.1f;
        }
        else if(collision.gameObject.CompareTag("PMagicC"))
        {
            isHitAnimation = true;
            isBreakAttackAnimation = false;
            hpSlider.value -= 0.15f;
        }
    }
}
