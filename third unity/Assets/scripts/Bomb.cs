using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;

public class Bomb : MonoBehaviour
{public float Countdown=5f;
public float speed = 5f;
public ParticleSystem blast;
public float radius=5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    { transform.position += transform.forward * speed * Time.deltaTime;
        Countdown-=Time.deltaTime;
        if(Countdown<0f)
        { ParticleSystem newdestroy = Instantiate(blast);
            newdestroy.transform.position = transform.position;
          CameraShaker1.Instance.ShakeOnce(4f,4f,.1f,1f);
            Collider[] colliders = Physics.OverlapSphere(transform.position,radius);
        foreach(Collider nearbyobject in colliders)
        {
            Rigidbody rb = nearbyobject.GetComponent<Rigidbody>();
            if(rb!=null&&nearbyobject.gameObject.name!="Robot")
            {rb.AddExplosionForce(1000f,transform.position,radius);
           
            Destroy(nearbyobject.gameObject);
            }
        }
            Destroy(gameObject);
        }
    }
}
