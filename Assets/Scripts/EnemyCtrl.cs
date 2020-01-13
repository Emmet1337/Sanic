using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCtrl : MonoBehaviour
{
    float direction = 1;
    float minX, maxX;
    private Rigidbody2D rigidbody2D;
    public int offsetX = 10;
    public float speed = 5f;

    void Start()
    {
      rigidbody2D=GetComponent<Rigidbody2D>();
        minX = transform.position.x;
        maxX = minX + offsetX;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currPos = transform.position;

        if(currPos.x >= maxX) {
          direction = -1;
        }
        if(currPos.x <= minX) {
          direction = 1;
        }

        rigidbody2D.MovePosition(new Vector2 (direction * speed * Time.deltaTime, 0)+rigidbody2D.position);

    }
}
