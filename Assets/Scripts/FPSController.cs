using UnityEngine;

public class FPSController : MonoBehaviour
{
    public float mouseSensitivity = 300f; // Fare hassasiyeti
    public Transform cameraTransform; // Kameran�n Transform'u (Main Camera)
    public Transform playerBody; // Oyuncunun v�cudu

    private float verticalRotation = 0f; // Dikey bak�� s�n�r� i�in de�i�ken

    void Start()
    {
        // Fare imlecini kilitle
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        // Fare hareketi
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        // Yukar�-a�a�� hareket (kameran�n dikey d�n���)
        verticalRotation -= mouseY;
        verticalRotation = Mathf.Clamp(verticalRotation, -90f, 90f); // Yukar� ve a�a�� s�n�rlama
        cameraTransform.localRotation = Quaternion.Euler(verticalRotation, 0f, 0f);

        // Sa�a-sola hareket (oyuncu g�vdesi)
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
