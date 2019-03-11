using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buff : MonoBehaviour
{
    Vector3 moveVector = new Vector3(0, (float)0.01, 0);
    public float scale;

    void Update()
    {
        // move
        if (this.transform.position.y > 0.8)
            moveVector = new Vector3(0, (float)-0.01, 0);
        else if (this.transform.position.y < 0.3)
            moveVector = new Vector3(0, (float)0.01, 0);
        this.gameObject.transform.position += moveVector;
    }

    private void OnTriggerEnter(Collider other)
    {
        // add scale
        if (other.gameObject.name == "player")
            other.transform.localScale += new Vector3(scale, scale, scale);

        // complite game
        if (GameObject.FindGameObjectsWithTag("buff").Length == 1)
            Application.LoadLevel(0);

        Object.Destroy(this.gameObject);
    }
}