using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class text_info : MonoBehaviour
{
    public Text textInformation;
    public GameObject followTarget;

    void Start()
    {
        textInformation.fontSize = Screen.height / 20;
    }

    void FixedUpdate()
    {
        textInformation.text = "Position : " + followTarget.transform.position + "\nScale : " + followTarget.transform.localScale.x.ToString("0.00") + "\nBuff : " + GameObject.FindGameObjectsWithTag("buff").Length;
    }
}
