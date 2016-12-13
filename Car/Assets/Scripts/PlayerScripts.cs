using UnityEngine;
using System.Collections;

public class PlayerScripts : MonoBehaviour
{

    public float speed;
    public GameObject effect;
    public GameObject dmgEffect;
    public AudioClip item;
    public AudioClip dmgSound;
    public GameObject textEffect2;
    public GameObject textEfeect;
    public int hp;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MoveX();
        MoveXLimit();
        if(hp <=0 )
        {
            hp = 0;
        }

        Application.LoadLevel(0);
        ScnenManager.LodaScene(0);

        shakeTime = shakeTime - Time.deltaTime;

        if(shakeTime < 0)
        {
            shakeTime = 0;
        }
    
        ShakeCamera();    
    }

    void MoveX()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-speed*Time.deltaTime , 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(speed*Time.deltaTime , 0, 0);
        }
    }


    void MoveXLimit()
    {
        if (transform.position.x < -2.0f)
        {
            transform.position = new Vector3(-2.0f,transform.position.y,transform.position.z);
        }
        if (transform.position.x > 2.0f)
        {
            transform.position = new Vector3(2.0f,transform.position.y,transform.position.z);
        }

    }

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag=="Item")
        {
            //Debug.Log("아이템을 먹었다!!!!");
            Instantiate(effect, transform.position, transform.rotation);
            Instantiate(textEfeect, transform.position, transform.rotation);
            gameObject.GetComponent<AudioSource>().PlayOneShot(item);
            hp = hp + 10;
            
        }

        if(col.gameObject.tag == "Enemy")
        {
            Debug.Log("적에 부딪혔다!!!!");
            Instantiate(dmgEffect, transform.position, transform.rotation);
            gameObject.GetComponent<AudioSource>().PlayOneShot(dmgSound);
            Instantiate(textEffect2, transform.position, transform.rotation);
            hp = hp - 20;
            if(hp <= 0)
            {
                Application.LoadLevel(0);
                
            }
            shakeTime = 1;     
         }  
                    
                
    }
    void ShakeCamera()
    {
        if(shakeTime > 0)
        {
            float x = Random.Range(-0.1f, 0.1f);
            float y = Random.Range(2.7f, 2.87f);
            GetComponent<Camera>().transform.position= new Vector3(x, y, GetComponent<Camera>().transform.position.z);
        }
    }
}




