using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Ball : MonoBehaviour
{
    public float timer = 3;

    public Vector3 Direction;
	// Use this for initialization
	void Start ()
    {
        Direction = new Vector3(1,0,0);
	}
	// Update is called once per frame
	void Update ()
	{
	    if (timer > 0)
	        timer -= Time.deltaTime;
	    else
	    {
	        timer = 3;
	        Direction = new Vector3(Random.Range(-1,1), Random.Range(-1,1), Random.Range(-1,1));
            GetComponent<Renderer>().material.color = Random.ColorHSV();
        }
	    transform.position += Direction * Time.deltaTime;
	}
}