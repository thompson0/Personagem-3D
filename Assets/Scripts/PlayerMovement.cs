using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Animator animator;
    private Rigidbody rb;

    [SerializeField] private float MoveSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");
        float horizontalSpeed = horizontal * MoveSpeed;
        float verticalSpeed = vertical * MoveSpeed;
        
        rb.velocity  = new Vector3(horizontalSpeed,rb.velocity.y,verticalSpeed);
        transform.forward = new Vector3(rb.velocity.x,0,rb.velocity.z);
        if (rb.velocity.x != 0 || rb.velocity.z != 0)
        {
            animator.SetBool("isRunning", true);
        }
        else
        {
            animator.SetBool("isRunning", false);
        }
    }
}
