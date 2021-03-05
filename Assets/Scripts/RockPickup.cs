using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RockPickup : MonoBehaviour
{
    public GameObject UiObject;
    public GameObject rock;

    // Start is called before the first frame update
    void Start()
    {
        UiObject.SetActive(false);
    }

       void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            UiObject.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        UiObject.SetActive(false);
        Destroy(rock);
    }
}
