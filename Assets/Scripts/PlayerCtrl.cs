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
    public GroundCheck groundCheck;
    public String lavaTag="lava";
    public String enemyTag="bad";
    public String flagTag="win";
    public int startlevel = 1;
    public int winScreen = 2;

    void Start () {
        rb = GetComponent<Rigidbody2D> ();
    }

    void FixedUpdate () {
        float moveX = CnInputManager.GetAxis ("Horizontal");
        transform.Translate(Vector2.right*moveX*speed*Time.deltaTime);

        if(groundCheck.isGrounded && CnInputManager.GetButtonDown("Jump")){
            Jump();
        }
    }

    private void Jump () {
        rb.velocity = Vector3.up * jumpPower;
    }

    
    void OnCollisionEnter2D (Collision2D collision) {
        if (collision.gameObject.tag == enemyTag) {
            SceneManager.LoadScene (startlevel);
        }
        if (collision.gameObject.tag == flagTag) {
            SceneManager.LoadScene (winScreen);
        }
        if(collision.gameObject.tag == lavaTag) {
            SceneManager.LoadScene(startlevel);
        }
    }

}