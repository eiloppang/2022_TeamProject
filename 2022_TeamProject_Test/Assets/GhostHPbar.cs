using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GhostHPbar : MonoBehaviour
{
    private GameObject HPSlider;


    // Start is called before the first frame update
    void Start()
    {
        HPSlider = GameObject.Find("GhostEnemy/Canvas/HPSlider");
        

    }

    // Update is called once per frame
    void Update()
    {
        HPSlider.transform.position = Camera.main.WorldToScreenPoint(transform.position + new Vector3(0, 1.2f, 0));

    }
}
