using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemstonePickup : MonoBehaviour
{
    public AudioClip pickupClip;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (LayerMask.LayerToName(collision.gameObject.layer) == "Player")
        {
            AudioSource.PlayClipAtPoint(pickupClip, transform.position);
            ScoreManager.instance.ChangeScore(coinValue);
            Destroy(this.gameObject);
        }
    }

    public int coinValue = 1;
    /*
    void onTriggerEnter2D(Collider2D other)
    {
        if (LayerMask.LayerToName(other.gameObject.layer) == "Player")
        {
            ScoreManager.instance.ChangeScore(coinValue);
        }
    }*/
}
