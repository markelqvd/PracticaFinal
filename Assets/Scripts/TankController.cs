using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController : MonoBehaviour
{
    public float speed = 5f;
    public float rotationSpeed = 100f;
    public Transform turretPivot; // NUEVO: Pivot de la torreta

    void Update()
    {
        // Movimiento del tanque
        float move = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float rotate = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
        transform.position += transform.forward * move;
        transform.Rotate(0, rotate, 0);

        // Rotación de la torreta con Q y E
        if (turretPivot != null)
        {
            float turretRotation = 50f * Time.deltaTime; // Velocidad de rotación
            if (Input.GetKey(KeyCode.Q))
            {
                turretPivot.Rotate(0, -turretRotation, 0); // Girar izquierda
            }
            if (Input.GetKey(KeyCode.E))
            {
                turretPivot.Rotate(0, turretRotation, 0); // Girar derecha
            }
        }
    }
}
