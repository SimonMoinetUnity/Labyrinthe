using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{  
    [SerializeField] private float speed = 5f;
    [SerializeField] private float MouseSensitivity = 3f;
    [SerializeField] private Camera cam;
    [SerializeField] private float cameraRotationLimit = 85f;
    
    private Vector3 rotation;
    private float cameraRotationX = 0f;
    private float currentCameraRotationX = 0f;

    private Rigidbody rb;

    private void Start() 
    {
        rb = GetComponent<Rigidbody>();    
    }

    private void Update() 
    {
        if(Input.GetKey(KeyCode.D))
        {
           transform.Translate(Vector3.right*speed*Time.deltaTime);
        }
        else if(Input.GetKey(KeyCode.Q))
        {
            transform.Translate(Vector3.left*speed*Time.deltaTime);
        }
        else if(Input.GetKey(KeyCode.Z))
        {
            transform.Translate(Vector3.forward*speed*Time.deltaTime);
        }
        else if(Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back*speed*Time.deltaTime);
        }

        float yRot = Input.GetAxisRaw("Mouse X");
        float xRot = Input.GetAxisRaw("Mouse Y");

        Vector3 rotation = new Vector3(0, yRot, 0)*MouseSensitivity;
        cameraRotationX = xRot*MouseSensitivity;

        //On calcule la rotation de la caméra
        rb.MoveRotation(rb.rotation * Quaternion.Euler(rotation));
        currentCameraRotationX -= cameraRotationX;
        currentCameraRotationX = Mathf.Clamp(currentCameraRotationX, -cameraRotationLimit, cameraRotationLimit);

        //On applique la rotation de la caméra
        cam.transform.localEulerAngles = new Vector3(currentCameraRotationX, 0f, 0f);
    }

}
