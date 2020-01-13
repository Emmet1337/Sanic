using System;
using System.Collections;
using CnControls;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent (typeof (Rigidbody2D))]

public class PlayerCtrl : MonoBehaviour {

    public float speed = 20f;
    public float jumpPower;
    private Rigidbody2D rb;

    void Start () {
        rb = GetComponent<Rigidbody2D> ();
    }

    void FixedUpdate () {
        float moveX = CnInputManager.GetAxis ("Horizontal");
        transform.Translate(Vector2.right*moveX*speed*Time.deltaTime);

        if(CnInputManager.GetButtonDown("Jump")){
            Jump();
        }
    }

    private void Jump () {
        Debug.Log("Jump");
        rb.velocity = Vector3.up * jumpPower;
    }

    void OnTriggerEnter2D (Collider2D other) {
        if (other.tag == "bad") {
            SceneManager.LoadScene (1);
        }
        if (other.tag == "win") {
            SceneManager.LoadScene (2);
        }
    }

}