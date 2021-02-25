using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchModelObject : MonoBehaviour
{

    public GameObject model1, model2;

    int activatedModel = 1;

    // Start is called before the first frame update
    void Start()
    {
        model1.gameObject.SetActive (true);
        model2.gameObject.SetActive (false);
    }

    public void switchModel()
    {
        switch (activatedModel) {

        case 1:

            activatedModel = 2;

            model1.gameObject.SetActive (false);
            model2.gameObject.SetActive (true);
            break;

        case 2:

            activatedModel = 1;

            model1.gameObject.SetActive (true);
            model2.gameObject.SetActive (false);
            break;



        }
    }
}
