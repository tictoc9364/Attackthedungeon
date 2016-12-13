using UnityEngine;
using System.Collections;

public class ItemScript : MonoBehaviour {

    public float itemSpeed;
    public Vector3 itemPos;

	// Use this for initialization
	void Start ()
    {
	     
	}

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, itemSpeed * Time.deltaTime);

        if (transform.position.z < -1.0f)
        {
            itemPos.x = Random.Range(-2.5f, 2.5f);

            transform.position = itemPos;
        }
    }

    void OnTriggerEnter(Collider col)
    {

    }


}


