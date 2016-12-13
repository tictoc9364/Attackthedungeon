using UnityEngine;
using System.Collections;

public class ResetBackGround : MonoBehaviour {

    public float treeSpeed;
    public float resetPos;
    public Vector3 treePos;

	// Use this for initialization
	void Start ()
    {
	    
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(0, 0, treeSpeed * Time.deltaTime);

        if(transform.position.z < resetPos)
        {
            transform.position = treePos;
        }
	}
}
