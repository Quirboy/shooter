using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraRotation : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;
    public float speed = 100f;

    private float xMouse;
    private float yMouse;
    private float xRotation = 0f;
    public Camera cam;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;  
    }

    // Update is called once per frame
    void Update()
    {
        xMouse= Input.GetAxis("Mouse X")* speed *Time.deltaTime;
        yMouse = Input.GetAxis("Mouse Y") * speed * Time.deltaTime;

        xRotation -= yMouse;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        player.Rotate(Vector3.up * xMouse);
    }
}
