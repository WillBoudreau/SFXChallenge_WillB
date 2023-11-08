using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float MoveSpeed = 5f;
    private float horizontalInput;
    private float verticalInput;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    { 
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");

        transform.Translate(Vector3.right *horizontalInput * Time.deltaTime * MoveSpeed);

        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * MoveSpeed);
    }
}
