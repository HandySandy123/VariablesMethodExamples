using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonClick : MonoBehaviour
{
    public GameObject empty;

    MyFirstVariableandMethod mMethod;
    int number;
    string value;


    // Start is called before the first frame update
    void Start()
    {
        value = gameObject.name;
        mMethod = empty.gameObject.GetComponent<MyFirstVariableandMethod>();
    }

    public void OnClick()
    {
        //Debug.Log(gameObject.name);
        bool success = int.TryParse(value, out number);
        if (success)
        {
            mMethod.IncreaseAge(number);
        } else
        {
            Debug.Log("Input failed");
        }
    }
}
