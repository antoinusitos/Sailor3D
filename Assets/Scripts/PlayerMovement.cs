using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Transform       myMainCamera = null;

    private const float     mySpeed = 5.0f;

    private Transform       myModel = null;

    private void Start()
    {
        myMainCamera = Camera.main.transform;
        myModel = transform.GetChild(0);
    }

    private void Update()
    {
        Vector3 dir = Vector3.zero;

        if(Input.GetKey(KeyCode.Z))
        {
            dir += myMainCamera.forward;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            dir -= myMainCamera.forward;
        }

        if (Input.GetKey(KeyCode.D))
        {
            dir += myMainCamera.right;
        }
        else if (Input.GetKey(KeyCode.Q))
        {
            dir -= myMainCamera.right;
        }

        transform.position += dir.normalized * mySpeed * Time.deltaTime;

        myModel.LookAt(transform.position + dir.normalized);
    }
}
