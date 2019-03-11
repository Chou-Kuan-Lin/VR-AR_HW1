using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public Vector3 offset;
    public GameObject followTarget;

    void Start()
    {
        this.transform.position = offset + followTarget.transform.position;
    }

    void LateUpdate()
    {
        this.transform.position = followTarget.transform.position + offset;
    }
}
