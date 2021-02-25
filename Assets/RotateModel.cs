using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotateModel : MonoBehaviour
{
    public GameObject model_object;
    public Slider slider;
    private float initVal;

    void Start()
    {
        this.slider.onValueChanged.AddListener(this.rotate_model);
    }

    public void rotate_model(float new_val)
    {
        float change = new_val - initVal;
        if (change != initVal)
        {
            model_object.transform.Rotate(Vector3.up * change * 360);
        }
        initVal = new_val;
    }
}
