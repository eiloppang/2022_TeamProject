using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossAnim : MonoBehaviour
{
    Animator anim;

    float randomAni;
    float randomCount;
    float timer;

    bool isRandomAnimationPermit = true; //* ����ǳ �ִϸ��̼� ���������� �ѹ��� �ϰ� �ϴ� ����
    [HideInInspector] public bool isStrongAndWeakAnimation = true; //* ����ǳ �ִϸ��̼� ������ �� �ִ��� Ȯ���ϴ� ����

    public bool isAttack, isBreak;

    bool initTimerAndRandomCount = true;
    bool isHitAnimation = false;

    public Slider hpSlider;   //���� hp 0 ���� �� ��� �ִϸ��̼�
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
        }
    }

    private void CatBossAnimation()
    {
        if(isStrongAndWeakAnimation == true)
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
                        //isTired = false;
                        //Debug.Log("��ǳ");
                    }
                    else
                    {
                        anim.SetTrigger("IsBreak");
                        isBreak = true;
                        isAttack = false;
                    }
                    isStrongAndWeakAnimation = false;
                }
                else
                {
                    if(isHitAnimation == true)
                    {
                        anim.SetTrigger("IsHit");
                        isBreak = false;
                        isAttack = false;
                    }
                    else
                    {
                        if (initTimerAndRandomCount == true)
                        {
                            timer = 0;
                            randomCount = Random.Range(3.0f, 7.0f);
                            isStrongAndWeakAnimation = true;
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
