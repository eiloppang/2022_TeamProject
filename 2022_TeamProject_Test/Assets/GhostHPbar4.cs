using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostHPbar4 : MonoBehaviour
{
    private GameObject HPSlider;

    // Start is called before the first frame update
    void Start()
    {
        HPSlider = GameObject.Find("GhostEnemy_3/Canvas/HPSlider");

    }

    // Update is called once per frame
    void Update()
    {
        HPSlider.transform.position = Camera.main.WorldToScreenPoint(transform.position + new Vector3(0, 1.2f, 0));

    }
}
