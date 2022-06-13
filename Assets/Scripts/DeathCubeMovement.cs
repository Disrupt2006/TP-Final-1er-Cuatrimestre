using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathCubeMovement : MonoBehaviour
{

    public float SpeedDeathCube;

    bool toUp;

    // Start is called before the first frame update
    void Start()
    {
        toUp = true;
    }

    // Update is called once per frame
    void Update()
    {

        if (toUp == true)
        {
            transform.position += new Vector3(0, 0, SpeedDeathCube);
        }
        else if (toUp == false)
        {
            transform.position -= new Vector3(0, 0, SpeedDeathCube);
        }

        if (transform.position.z > 8)
        {
            toUp = false;
        }
        if (transform.position.z < -8)
        {
            toUp = true;
        }

    }
}
