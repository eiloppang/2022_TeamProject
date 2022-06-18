using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlantHPbar : MonoBehaviour
{
    private GameObject HPSlider;
    private GameObject HPSlider2;


    // Start is called before the first frame update
    void Start()
    {
        HPSlider = GameObject.Find("PlantEnemy/Canvas/HPSlider");
        HPSlider2 = GameObject.Find("PlantEnemy_1/Canvas/HPSlider");


    }

    // Update is called once per frame
    void Update()
    {
        HPSlider.transform.position = Camera.main.WorldToScreenPoint(transform.position + new Vector3(0, 1.4f, 0));
        HPSlider2.transform.position = Camera.main.WorldToScreenPoint(transform.position + new Vector3(0, 1.4f, 0));

    }
}
