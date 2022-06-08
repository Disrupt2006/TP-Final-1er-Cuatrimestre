using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JugabilidadScript : MonoBehaviour
{

    public GameObject Monedaprefab;
    public Text CoinText;

    int contadorMonedas = 0;


    // Start is called before the first frame update
    void Start()
    {
        Vector3 randomSpawnPosition = new Vector3(Random.Range(-9, 10), 0.8f, Random.Range(-9, 10));
        Instantiate(Monedaprefab, randomSpawnPosition, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.tag == "Coin")
        {
            contadorMonedas++;

            Destroy(col.gameObject);

            Vector3 randomSpawnPosition = new Vector3(Random.Range(-9, 10), 0.8f, Random.Range(-9, 10));
            Instantiate(Monedaprefab, randomSpawnPosition, Quaternion.identity);

         


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
