using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accelpoint : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, -30), ForceMode.VelocityChange);
    }


}
