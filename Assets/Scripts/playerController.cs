using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{

    public float MovementSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(MovementSpeed, 0, 0);
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position -= new Vector3(MovementSpeed, 0, 0);
        }
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += new Vector3(0, 0, MovementSpeed);
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.position -= new Vector3(0, 0, MovementSpeed);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            //translate para rotar
            //transform.Translate(0, MovementSpeed, 0);
            transform.position += new Vector3(0, MovementSpeed, 0);
        }
    }
}
