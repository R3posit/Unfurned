using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f; // Hareket hýzý
    public float mouseSensitivity = 300f; // Fare hassasiyeti (arttýrýldý)

    private Rigidbody rb;
    private float rotationY = 0f; // Oyuncunun dönme açýsý

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked; // Farenin ekranýn içinde kalmasýný saðlar
    }

    void Update()
    {
        // Fare hareketine göre dönüþ
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        rotationY += mouseX;
        transform.rotation = Quaternion.Euler(0f, rotationY, 0f);

        // Klavye giriþleriyle hareket
        float horizontal = Input.GetAxis("Horizontal"); // A/D tuþlarý
        float vertical = Input.GetAxis("Vertical"); // W/S tuþlarý

        Vector3 moveDirection = transform.forward * vertical + transform.right * horizontal;
        rb.MovePosition(rb.position + moveDirection * moveSpeed * Time.deltaTime);
    }
}
