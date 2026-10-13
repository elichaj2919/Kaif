using System;
using UnityEngine;

public class CoinCollect : MonoBehaviour
{
    [SerializeField]
    private ParticleSystem effect;
    
    private int coinsCollected = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            coinsCollected++;
            
            effect.transform.position = other.transform.position;
            effect.Play();
        }
    }
}
