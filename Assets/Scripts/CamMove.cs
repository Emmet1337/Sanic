using UnityEngine;

public class CamMove : MonoBehaviour
{
    public GameObject sanic;

    void  LateUpdate()
    {
        transform.position = new Vector3 (sanic.transform.position.x, sanic.transform.position.y, -10f);
    }
}
