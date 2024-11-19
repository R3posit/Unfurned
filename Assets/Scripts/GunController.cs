using UnityEngine;

public class GunController : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float bulletSpeed = 20f;
    public float fireRate = 0.1f;

    private float nextFireTime = 0f;

    void Update()
    {
        // Eðer GunController devre dýþýysa veya silahýn parent'ý yoksa ateþ etmeyi durdur
        if (!enabled || transform.parent == null)
        {
            Debug.Log("GunController devre dýþý veya parent yok, ateþ etmiyor.");
            return;
        }

        if (Input.GetMouseButton(0) && Time.time >= nextFireTime)
        {
            Debug.Log("GunController: Ateþ ediliyor.");
            Shoot();
            nextFireTime = Time.time + fireRate;
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.velocity = firePoint.forward * bulletSpeed;
        }

        Destroy(bullet, 2f);
    }
}
