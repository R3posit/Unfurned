using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f; // Hareket h�z�
    public float mouseSensitivity = 300f; // Fare hassasiyeti (artt�r�ld�)

    private Rigidbody rb;
    private float rotationY = 0f; // Oyuncunun d�nme a��s�

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked; // Farenin ekran�n i�inde kalmas�n� sa�lar
    }

    void Update()
    {
        // Fare hareketine g�re d�n��
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        rotationY += mouseX;
        transform.rotation = Quaternion.Euler(0f, rotationY, 0f);

        // Klavye giri�leriyle hareket
        float horizontal = Input.GetAxis("Horizontal"); // A/D tu�lar�
        float vertical = Input.GetAxis("Vertical"); // W/S tu�lar�

        Vector3 moveDirection = transform.forward * vertical + transform.right * horizontal;
        rb.MovePosition(rb.position + moveDirection * moveSpeed * Time.deltaTime);
    }
}
