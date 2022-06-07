using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerController : MonoBehaviour
{

    public float MovementSpeed;
    public float JumpForce;

    bool hasJump;

    public GameObject Moneda;

    Rigidbody rb;

    public Text CoinText;
   

    // Start is called before the first frame update
    void Start()
    {
        //source = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody>();
        hasJump = true;
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
        if (Input.GetKey(KeyCode.Space) && hasJump)
        {
            rb.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
            hasJump = false;
            //transform.position += new Vector3(0, MovementSpeed, 0);
        }


    }

    void OnCollisionEnter(Collision col)
    {
        int contadorMonedas = 0;
       
        if (col.gameObject.tag == "Ground")
        {
            hasJump = true;
        }

        if (col.gameObject.tag == "Coin")
        {
            contadorMonedas ++;
            Destroy(Moneda);

            if (contadorMonedas == 1)
            {
                CoinText.text = contadorMonedas + " moneda";
            }
            else
            {
                CoinText.text = contadorMonedas + " monedas";
            }


        }

        if (col.gameObject.tag == "DeathCube")
        {
            Destroy(gameObject, 0.2f);            
        } 

      
    }

}
