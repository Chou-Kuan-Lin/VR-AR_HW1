using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generate : MonoBehaviour
{
    public GameObject generateObject;
    void Start()
    {
        // 5 - -5 ; 10 - 30
        for (int i = 0; i < Random.Range(10f, 30f); i++)
            Instantiate(generateObject, new Vector3(Random.Range(-4.5f, 4.5f), Random.Range(0f, 1f), Random.Range(-4.5f, 4.5f)), Quaternion.identity);

        Object.Destroy(this.gameObject);
    }
}
