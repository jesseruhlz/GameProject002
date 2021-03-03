using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public Vector3 pos1;
    public Vector3 pos2;
    public float speed = 1.0f;
    //public Transform startPos;

    //Vector3 nextPos;


    // Start is called before the first frame update
    void Start()
    {
        //nextPos = startPos.position;
        //nextPos = pos1.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        /*
        if (transform.position == pos1.position)
        {
            nextPos = pos2.position;
        }

        if (transform.position == pos2.position)
        {
            nextPos = pos1.position;
        }*/

        transform.position = Vector3.Lerp(pos1, pos2, Mathf.PingPong(Time.time * speed, 1.0f));
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(pos1, pos2);
    }
}
