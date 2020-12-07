using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombMove : MonoBehaviour
{public float Countdown=5f;
public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { transform.position += transform.forward * speed * Time.deltaTime;
        Countdown-=Time.deltaTime;
        if(Countdown==0f)
        {
            Destroy(gameObject);
        }
    }
}
