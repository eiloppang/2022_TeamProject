using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockHPbar2 : MonoBehaviour
{
    private GameObject HPSlider;
    // Start is called before the first frame update
    void Start()
    {
        HPSlider = GameObject.Find("RockEnemy_1/Canvas/HPSlider");
    }

    // Update is called once per frame
    void Update()
    {
        HPSlider.transform.position = Camera.main.WorldToScreenPoint(transform.position + new Vector3(0, 1.2f, 0));
    }
}
