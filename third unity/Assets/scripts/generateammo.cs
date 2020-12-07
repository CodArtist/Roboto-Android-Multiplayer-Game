using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;
public class generateammo : MonoBehaviour
{public bool firebullets;
public bool firebomb;
public GameObject gun;


//Bullet variables
private float speed = 3f;
public GameObject bulletprefab;
private Vector3 direction = new Vector3(0f, 5.01f, 0f);
protected Joystick joystick;
public ParticleSystem bulletblastprefab;

//Bomb variables

public GameObject bombprefab;
public float countdown=5f;
protected float bombs=0f;

    // Start is called before the first frame update
    void Start()
    {firebullets=true;
    firebomb=false;
        
    }

    // Update is called once per frame
    void Update()
    {if(firebullets)
    {
        GenerateBullets();
    }
    if(firebomb)
    {
        GenerateBomb();
    }
        
    }
   /* public void FireBullets()
    {
        firebullets=true;
        firebomb=false;
    }
    public void FireBomb()
    {
        firebomb=true;
        firebullets=false;
    }*/
public void GenerateBullets()
{
    
        Ray ray;
        /*float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        if (horizontal != 0f || vertical != 0f)
            direction = new Vector3(horizontal, 0f, vertical);*/
        //Touch t = Input.GetTouch(0);
        //Touch t2 = Input.GetTouch(1);

        /* if (t1.phase == TouchPhase.Began)
             t = t1;*/
        /*if (t2.phase == TouchPhase.Began)
            t = t2;*/
        int i =0;

         ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                    RaycastHit hit;
                    //direction = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,Input.mousePosition.y,5));
                    if (Physics.Raycast(ray, out hit, 1000))
                    {
                       
                        direction = hit.point;
                    }

                    direction = direction - transform.position;
                    direction.y =0.4f;
                    if (Input.GetMouseButton(0))
            
                    
                        {ParticleSystem muzzle = GetComponentInChildren<ParticleSystem>();
                        muzzle.Play();
                        GameObject newbullet = Instantiate(bulletprefab);
                        CameraShaker1.Instance.ShakeOnce(1f,1f,0.1f,0.2f);
                        
                         // Debug.Log("pessed");
                        /*if (horizontal != 0f || vertical != 0f)
                              
                            newbullet.transform.forward = direction;*/

                        //newbullet.transform.LookAt(transform.forward);
                        newbullet.transform.forward = transform.forward;
                        newbullet.transform.position = transform.position + transform.forward;
                        // bulletblastprefab.transform.position = transform.position + transform.forward;
                        
                        }
                  
        /*while (i < Input.touchCount)
        {
            Touch t = Input.GetTouch(i);
            if (t.phase == TouchPhase.Stationary||t.phase ==TouchPhase.Moved)
            {


                if (t.position.x > joystick.transform.position.x+5 && t.position.y >joystick.transform.position.y+5 || t.position.y<joystick.transform.position.y-5)
                {
                    ray = Camera.main.ScreenPointToRay(t.position);
                    RaycastHit hit;
                    //direction = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,Input.mousePosition.y,5));
                    if (Physics.Raycast(ray, out hit, 1000))
                    {
                        Debug.DrawRay(ray.origin, ray.direction, Color.red);
                        direction = hit.point;
                    }

                    direction = direction - transform.position;
                    direction.y = 10.01f;

                    //if (Input.GetMouseButton(0))
                    
                        GameObject newbullet = Instantiate(bulletprefab);
                         // Debug.Log("pessed");
                        /*if (horizontal != 0f || vertical != 0f)
                              
                            newbullet.transform.forward = direction;*/

                        //newbullet.transform.LookAt(transform.forward);
           /*             newbullet.transform.forward = transform.forward;
                        newbullet.transform.position = transform.position + transform.forward;
                        
                    

                }
            }
            i++;
        }*/
}
public void GenerateBomb()
{countdown-=Time.deltaTime;
    
        Ray ray;
        /*float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        if (horizontal != 0f || vertical != 0f)
            direction = new Vector3(horizontal, 0f, vertical);*/
        //Touch t = Input.GetTouch(0);
        //Touch t2 = Input.GetTouch(1);

        /* if (t1.phase == TouchPhase.Began)
             t = t1;*/
        /*if (t2.phase == TouchPhase.Began)
            t = t2;*/
        int i =0;

         ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                    RaycastHit hit;
                    //direction = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,Input.mousePosition.y,5));
                    if (Physics.Raycast(ray, out hit, 1000))
                    {
                        Debug.DrawRay(ray.origin, ray.direction, Color.red);
                        direction = hit.point;
                    }

                    direction = direction - transform.position;
                    direction.y = 10.01f;
                    if (Input.GetMouseButton(0)&&bombs==0f)
            
                    
                        {GameObject newbullet = Instantiate(bombprefab);
                        bombs+=1;
                         // Debug.Log("pessed");
                        /*if (horizontal != 0f || vertical != 0f)
                              
                            newbullet.transform.forward = direction;*/

                        //newbullet.transform.LookAt(transform.forward);
                       newbullet.transform.forward = transform.forward;
                        newbullet.transform.position = transform.position + transform.forward;
                        countdown=5f;}
                    if(countdown<=0f)
                       { bombs=0f;
                       }
       /*while (i < Input.touchCount)
        {
            Touch t = Input.GetTouch(i);
            if (t.phase == TouchPhase.Stationary||t.phase ==TouchPhase.Moved&&bombs==0f)
            {


                if (t.position.x > joystick.transform.position.x+5 && t.position.y >joystick.transform.position.y+5 || t.position.y<joystick.transform.position.y-5)
                {
                    ray = Camera.main.ScreenPointToRay(t.position);
                    RaycastHit hit;
                    //direction = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,Input.mousePosition.y,5));
                    if (Physics.Raycast(ray, out hit, 1000))
                    {
                        Debug.DrawRay(ray.origin, ray.direction, Color.red);
                        direction = hit.point;
                    }

                    direction = direction - transform.position;
                    direction.y = 10.01f;

                    //if (Input.GetMouseButton(0))
                    bombs+=1;
                        GameObject newbullet = Instantiate(bulletprefab);
                         // Debug.Log("pessed");
                       /* if (horizontal != 0f || vertical != 0f)
                              
                            newbullet.transform.forward = direction;*/

                        //newbullet.transform.LookAt(transform.forward);
                       /* newbullet.transform.forward = transform.forward;
                        newbullet.transform.position = transform.position + transform.forward;
                        
                      if(countdown<=0f)
                       { bombs=0f;
                       }

                }
            }
            i++;
        }*/
}
}

