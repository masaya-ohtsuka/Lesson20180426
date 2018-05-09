using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warp : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        this.gameObject.transform.position = new Vector3(-3, 0.5f, -3);
    }
}
