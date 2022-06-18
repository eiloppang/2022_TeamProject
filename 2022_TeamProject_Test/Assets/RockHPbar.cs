using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RockHPbar : MonoBehaviour
{
    private GameObject HPSlider;
    private GameObject HPSlider2;

    // Start is called before the first frame update
    void Start()
    {
        HPSlider = GameObject.Find("RockEnemy/Canvas/HPSlider");
        HPSlider2 = GameObject.Find("RockEnemy_1/Canvas/HPSlider");

    }

    // Update is called once per frame
    void Update()
    {
        HPSlider.transform.position = Camera.main.WorldToScreenPoint(transform.position + new Vector3(0, 1.2f, 0));
        HPSlider2.transform.position = Camera.main.WorldToScreenPoint(transform.position + new Vector3(0, 1.2f, 0));

    }
}
