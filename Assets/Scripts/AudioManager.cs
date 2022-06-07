using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

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
        
    }

    void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.tag == "Coin")
        {
            source.clip = CoinSound;
            source.Play();
        }

        if (col.gameObject.tag == "DeathCube")
        {
            source.clip = DeathSound;
            source.Play();          
        }

    }
}
