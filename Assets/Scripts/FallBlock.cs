using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallBlock : MonoBehaviour {

    private Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
		
	}

    private void OnCollisionEnter(Collision other)    {
        if (other.gameObject.CompareTag("Player")) {
            Invoke("Fall", 2);
        }
    }

    void Fall(){
        rb.isKinematic = false;
    }

}
