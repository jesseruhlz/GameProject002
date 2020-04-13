using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public KeyCode throwRock;

    private Rigidbody2D theRB;

    private Animator anim;

    public GameObject rock;
    public Transform throwPoint;

    public AudioSource throwSound;

    // Start is called before the first frame update
    void Start()
    {
        //theRB = GetComponent<RigidBody2D>();

        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(throwRock))
        {
            GameObject rockClone = (GameObject) Instantiate(rock, throwPoint.position, throwPoint.rotation);
            rockClone.transform.localScale = transform.localScale;
            anim.SetTrigger("Throw");

            throwSound.Play();
        }


    }

    

        
}
