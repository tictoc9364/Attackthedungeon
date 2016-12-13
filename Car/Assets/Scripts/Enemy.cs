using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

    public float enemySpeed;
    public float randomPos;
    public Vector3 enemyPos;
    public float xPosMin;
    public float XposMax;
    public float enemySpeedMin;
    public float enemySpeedMax;

	// Use this for initialization
	void Start ()
    {
	    
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(0, 0, enemySpeed * Time.deltaTime);

        if(transform.position.z < 0)
        {
            transform.position = enemyPos;

            SetEnemy();
        }
	}

    void OnTriggerEnter()
    {
        Debug.Log("플레이어와 부딛힘!!!!");
        SetEnemy();
    }

    void SetEnemy()
    {
        randomPos = Random.Range(xPosMin,XposMax);
        enemySpeed = Random.Range(enemySpeedMin, enemySpeedMax);
        enemyPos.x = randomPos;
        transform.position = enemyPos;
    }
}
