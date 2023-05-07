using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.InputSystem;

public class ShootingPin : MonoBehaviour
{

    public Transform shootingPoint;
    public GameObject bulletPrefab;

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.ctrlKey.wasPressedThisFrame)
            if (Input.GetButtonDown("Fire1"))
            {
            Instantiate(bulletPrefab, shootingPoint.position, transform.rotation);
        }
    }
}
