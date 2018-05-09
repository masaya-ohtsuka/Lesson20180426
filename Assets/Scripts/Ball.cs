using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour {

	public float moveSpeed;
    public float jump_speed;
    public AudioClip coinGet;
    private Rigidbody rb;
    private bool isJumping = false;
    private int coinCount;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();

        coinCount = 0;
	}
	
	// Update is called once per frame
	void Update () {
		float moveH = Input.GetAxis ("Horizontal");
		float moveV = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveH, 0, moveV);

		rb.AddForce (movement * moveSpeed);

        if (Input.GetButtonDown("Jump") &&  isJumping == false) {
            rb.velocity = Vector3.up * jump_speed;
            isJumping = true;
        }
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Coin"))
        {
            Destroy(other.gameObject);

            AudioSource.PlayClipAtPoint(coinGet, Camera.main.transform.position);

            coinCount = coinCount + 1;

            if (coinCount == 2) {
                SceneManager.LoadScene("GameClear");
            }
        }   
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Floor")) {
            isJumping = false;
        }
    }

}