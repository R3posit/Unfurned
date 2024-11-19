using UnityEngine;

public class FPSController : MonoBehaviour
{
    public float mouseSensitivity = 300f; // Fare hassasiyeti
    public Transform cameraTransform; // Kameranýn Transform'u (Main Camera)
    public Transform playerBody; // Oyuncunun vücudu

    private float verticalRotation = 0f; // Dikey bakýþ sýnýrý için deðiþken

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

        // Yukarý-aþaðý hareket (kameranýn dikey dönüþü)
        verticalRotation -= mouseY;
        verticalRotation = Mathf.Clamp(verticalRotation, -90f, 90f); // Yukarý ve aþaðý sýnýrlama
        cameraTransform.localRotation = Quaternion.Euler(verticalRotation, 0f, 0f);

        // Saða-sola hareket (oyuncu gövdesi)
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
