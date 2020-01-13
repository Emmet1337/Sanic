using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public float radius;
    public bool isGrounded;
    public LayerMask layerMask;

    private void OnDrawGizmos(){
        Gizmos.DrawWireSphere(transform.position,radius);
    }

    private void Update(){
        isGrounded = Physics2D.OverlapCircle(transform.position,radius,layerMask);
        Debug.Log(isGrounded);
    }
}
