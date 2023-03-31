using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    float hAxis;
    float vAxis;

    Vector3 moveVec;

    void Start()
    {

    }

    void Update()
    {
        hAxis = Input.GetAxisRaw("Horizontal");
        vAxis = Input.GetAxisRaw("Vertical");

        moveVec = new Vector3(hAxis,0, vAxis);

        transform.position += moveVec * speed * Time.deltaTime;

        transform.LookAt(transform.position + moveVec);
    }

    private void Up()
    {
        Vector3 target = new Vector3(-30f, 60f, 10f);

        Vector3 velo = Vector3.zero;
        transform.position = Vector3.SmoothDamp(transform.position, target, ref velo, 0.1f);


    }
    private void Down()
    {
        Vector3 target = new Vector3(20f, -35f, 0.0f);

        Vector3 velo = Vector3.zero;
        transform.position = Vector3.SmoothDamp(transform.position, target, ref velo, 0.1f);


    }

    void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Ladder1")
        {
            Up();

        }
        if (other.tag == "Ladder2")
        {
            Down();

        }
    }
}
