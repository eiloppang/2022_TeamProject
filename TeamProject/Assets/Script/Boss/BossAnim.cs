using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossAnim : MonoBehaviour
{
    Animator anim;

    //float randomAni;
    float randomCount;
    float timer;

    bool isRandomAnimationPermit = true; //* 강약풍 애니메이션 랜덤결정을 한번만 하게 하는 변수
    [HideInInspector] public bool isBreakAttackAnimation = true; //* 강약풍 애니메이션 진행할 수 있는지 확인하는 변수

    public bool isAttack, isBreak, isHit;

    bool initTimerAndRandomCount = true;
    bool isHitAnimation = false;

    public Slider hpSlider;   //보스 hp 0 됐을 때 사망 애니메이션
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        timer = 0;
        randomCount = Random.Range(3.0f, 7.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if(hpSlider.value != 0.0f)
        {
            CatBossAnimation();
        }
        else if(hpSlider.value == 0.0f)
        {
            anim.SetTrigger("IsDead");
            isBreak = false;
            isAttack = false;
            isHit = false;
        }
    }

    private void CatBossAnimation()
    {
        if(isBreakAttackAnimation == true)
        {
            timer += Time.deltaTime;
            if(timer >= 2.0f)
            {
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
                    isBreakAttackAnimation = false;
                }
                else
                {
                    if(isHitAnimation == true)
                    {
                        anim.SetTrigger("IsHit");
                        isHit = true;
                        isBreak = false;
                        isAttack = false;
                    }
                    else
                    {
                        if (initTimerAndRandomCount == true)
                        {
                            timer = 0;
                            randomCount = Random.Range(3.0f, 7.0f);
                            isBreakAttackAnimation = true;
                            initTimerAndRandomCount = false;
                        }
                    }
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Attack") || collision.gameObject.CompareTag("Magic1") || collision.gameObject.CompareTag("Magic2"))
        {
            isHitAnimation = true;
        }
    }
}
