using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
//VAMOS MESSI CARAJO MENTIRA RE PECHO FRIO
//Y EL DIEGOTE
    public Rigidbody rb;

    public float speed;
    public float rotSpeed;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void FixedUpdate()
    {
        rb.velocity =
            Input.GetAxis("Vertical") * 
            transform.forward * 
            speed * 
            Time.deltaTime 
            
            + 

            Input.GetAxis("Horizontal") * 
            transform.right * 
            speed * 
            Time.deltaTime;

        transform.Rotate 
            (0, Input.GetAxis("Mouse X") * 
            rotSpeed * 
            Time.deltaTime, 0);
    }
}
