using UnityEngine;

public class CamMove : MonoBehaviour
{
    public GameObject sanic;

    void Update()
    {
        transform.position = new Vector3 (sanic.transform.position.x, sanic.transform.position.y, -10f);
    }
}
