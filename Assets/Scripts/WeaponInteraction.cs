using UnityEngine;

public class WeaponInteraction : MonoBehaviour
{
    public Transform weaponHolder;
    public Transform droppedWeaponParent;
    public GameObject currentWeapon;

    void Start()
    {
        if (currentWeapon != null)
        {
            currentWeapon.GetComponent<Rigidbody>().isKinematic = true;
            currentWeapon.GetComponent<Collider>().enabled = false;
            currentWeapon.GetComponent<GunController>().enabled = true;
            currentWeapon.transform.SetParent(weaponHolder);
            currentWeapon.transform.localPosition = Vector3.zero;
            currentWeapon.transform.localRotation = Quaternion.identity;
            currentWeapon.tag = "Untagged";
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            RaycastHit hit;
            if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, 2f))
            {
                if (hit.collider.CompareTag("Weapon"))
                {
                    PickupWeapon(hit.collider.gameObject);
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.G) && currentWeapon != null)
        {
            DropWeapon();
        }
    }

    void PickupWeapon(GameObject weapon)
    {
        if (currentWeapon != null)
        {
            DropWeapon();
        }

        currentWeapon = weapon;
        currentWeapon.transform.SetParent(weaponHolder);
        currentWeapon.transform.localPosition = Vector3.zero;
        currentWeapon.transform.localRotation = Quaternion.identity;
        currentWeapon.GetComponent<Rigidbody>().isKinematic = true;
        currentWeapon.GetComponent<Collider>().enabled = false;
        currentWeapon.GetComponent<GunController>().enabled = true;
        currentWeapon.tag = "Untagged";
    }

    void DropWeapon()
    {
        currentWeapon.transform.SetParent(droppedWeaponParent);
        currentWeapon.GetComponent<Rigidbody>().isKinematic = false;
        currentWeapon.GetComponent<Collider>().enabled = true;

        // Ateþ mekanizmasýný devre dýþý býrak
        currentWeapon.GetComponent<GunController>().enabled = false;

        currentWeapon.tag = "Weapon";
        currentWeapon.transform.position = weaponHolder.position + weaponHolder.forward * 1.5f;
        currentWeapon = null;
    }
}
