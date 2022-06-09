using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JugabilidadScript : MonoBehaviour
{

    public GameObject Monedaprefab;
    public GameObject DeathCubePrefab;
    public GameObject Confeti;

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

    void OnCollisionStay(Collision col)
    {

        if (col.gameObject.tag == "Coin")
        {
            contadorMonedas++;

            Destroy(col.gameObject);

            if (contadorMonedas < 10)
            {
                Vector3 randomSpawnPositionCoin = new Vector3(Random.Range(-9, 10), 0.8f, Random.Range(-9, 10));
                Instantiate(Monedaprefab, randomSpawnPositionCoin, Quaternion.identity);

                Vector3 randomSpawnPositionDeathCube = new Vector3(Random.Range(-9, 10), 0.8f, Random.Range(-9, 10));
                Instantiate(DeathCubePrefab, randomSpawnPositionDeathCube, Quaternion.identity);
            }

           else
            {
                Destroy(gameObject);
                for (int i = 0; i <= 100; i++)
                {
                    Instantiate (Confeti);
                }
            }

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
