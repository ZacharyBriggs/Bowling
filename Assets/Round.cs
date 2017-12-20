using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Round : MonoBehaviour
{
    public int mLocalScore;
    public List<Ball> balls = new List<Ball>();
	// Use this for initialization
	void Start ()
	{
        mLocalScore = 0;
	}
	// Update is called once per frame
	void Update ()
	{
	    if (Input.GetKey(KeyCode.Space))
	    {
	        GameObject newBall = GameObject.CreatePrimitive(PrimitiveType.Sphere);
	        newBall.AddComponent<Ball>();
	        balls.Add(newBall.GetComponent<Ball>());

        }
	    if (Input.GetKeyDown(KeyCode.Mouse0))
	    {
	        mLocalScore++;
	    }
	}
}