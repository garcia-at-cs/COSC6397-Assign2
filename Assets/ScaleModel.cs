using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScaleModel : MonoBehaviour
{
    public GameObject model_object;
    public Slider slider;
    private float new_value;

    void Start()
    {
        this.slider.onValueChanged.AddListener(this.scale_model);
    }

    public void scale_model(float new_value)
    {
        model_object.transform.localScale = Vector3.one * new_value * 5;
    }
}
