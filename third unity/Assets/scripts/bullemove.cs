using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bullemove : MonoBehaviour
{
    public ParticleSystem destroy;
    
    float speed = 100f;
    //float score = 0f;
    private float lifetimer=0.1f;
    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
        lifetimer -= Time.deltaTime;
        
        if(lifetimer<0f)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "enemy (1)")
        {
            charactermove.score++;
            
            ParticleSystem newdestroy = Instantiate(destroy);
            newdestroy.transform.position = transform.position;
            Destroy(other.gameObject);
            

        }
        if (other.gameObject.name == "Enemy")
        {if(other.gameObject.GetComponent<enemyai>().health<0)          
            {charactermove.score++;
            
            ParticleSystem newdestroy = Instantiate(destroy);
            newdestroy.transform.position = transform.position;
            Destroy(other.gameObject);
            }
            else{
                other.gameObject.GetComponent<enemyai>().health -= (float)0.1;
                other.gameObject.GetComponent<enemyai>().healthbar.GetComponent<Slider>().value=other.gameObject.GetComponent<enemyai>().health;
            }
            

        }
    }
}
