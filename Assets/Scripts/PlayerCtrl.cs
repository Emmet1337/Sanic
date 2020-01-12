using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using CnControls;

[RequireComponent(typeof(Rigidbody2D))]

public class PlayerCtrl : MonoBehaviour
{

    public float speed = 20f;
    private Rigidbody2D rb;


    void Start()
    {
        rb = GetComponent <Rigidbody2D> ();

    }

    void Update()
    {
         float moveX = CnInputManager.GetAxis ("Horizontal");
	       rb.MovePosition (rb.position + Vector2.right * moveX * speed * Time.deltaTime);


         // if(CnInputManager.GetAxis("Jump")) {
         //   Jump();
         // }

    }

    void OnTriggerEnter2D(Collider2D other)
   {
       if(other.tag == "bad")
       {
           SceneManager.LoadScene(1);
       }
       if(other.tag == "win") {
         SceneManager.LoadScene(2);
       }
   }


}
