using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerController : MonoBehaviour
{

    public float MovementSpeed;

    public GameObject Moneda;

    public Text CoinText;

    AudioSource source;
    public AudioClip CoinSound;
    public AudioClip DeathSound;
   

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
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
            transform.position += new Vector3(0, MovementSpeed, 0);
        }


    }

    void OnCollisionEnter(Collision col)
    {
        int contadorMonedas;
        contadorMonedas = +1;

        if (col.gameObject.name == "Moneda")
        {
            Destroy(Moneda);

            if (contadorMonedas == 1)
            {
                CoinText.text = contadorMonedas + " moneda";
            }
            else
            {
                CoinText.text = contadorMonedas + " monedas";
            }

            source.clip = CoinSound;

        }

        if (col.gameObject.name == "DeathCube")
        {
            //gameObject sin mayus hace referencia al mismo objeto
            Destroy(gameObject);
            source.clip = DeathSound;
        }
    }

}
