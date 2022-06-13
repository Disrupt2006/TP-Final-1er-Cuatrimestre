using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JugabilidadScript : MonoBehaviour
{

    public GameObject Monedaprefab;
    public GameObject DeathCubePrefab;
    public GameObject Confeti;

    public float SpeedDeathCube;

    public Text CoinText;

    bool toRight;
    bool toUp;

    int contadorMonedas = 0;


    // Start is called before the first frame update
    void Start()
    {
        Vector3 randomSpawnPosition = new Vector3(Random.Range(-9, 10), 0.8f, Random.Range(-9, 10));
        Instantiate(Monedaprefab, randomSpawnPosition, Quaternion.identity);

        toRight = true;
        toUp = true;
    }

    // Update is called once per frame
    void Update()
    {
       
        if (contadorMonedas % 2 == 0 && toRight == true)
        {
            DeathCubePrefab.transform.Translate(SpeedDeathCube, 0, 0);
        }
        else if (toRight == false)
        {
            DeathCubePrefab.transform.Translate(-SpeedDeathCube, 0, 0);
        }

        if (DeathCubePrefab.transform.position.x == 9.9)
        {
            toRight = false;
        }
        if (DeathCubePrefab.transform.position.x == -9.8)
        {
            toRight = true;
        }

        
        
        if (contadorMonedas % 2 != 0 && toUp == true)
        {
            DeathCubePrefab.transform.Translate(0, 0, SpeedDeathCube);
        }
        else if (toUp == false)
        {
            DeathCubePrefab.transform.Translate(0, 0, -SpeedDeathCube);
        }

        if (DeathCubePrefab.transform.position.z == 19.9)
        {
            toUp = false;
        }
        if (DeathCubePrefab.transform.position.z == 0.18)
        {
            toUp = true;
        }
        

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
                DeathCubePrefab = Instantiate(DeathCubePrefab, randomSpawnPositionDeathCube, Quaternion.identity);

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
