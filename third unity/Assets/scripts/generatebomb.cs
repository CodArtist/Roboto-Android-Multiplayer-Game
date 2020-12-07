using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generatebomb : MonoBehaviour
{
    private float speed = 3f;
    public GameObject bulletprefab;
    public GameObject bombprefab;
    private Vector3 direction = new Vector3(0f, 5.01f, 0f);
    protected Joystick joystick;
    public float countdown=5f;
    protected float bombs=0f;

    private void Start()
    {
        joystick = FindObjectOfType<Joystick>();
    }
    // Update is called once per frame
    void Update()
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
       /* while (i < Input.touchCount)
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
                        if (horizontal != 0f || vertical != 0f)
                              
                            newbullet.transform.forward = direction;

                        //newbullet.transform.LookAt(transform.forward);
                        newbullet.transform.forward = transform.forward;
                        newbullet.transform.position = transform.position + transform.forward;
                        
                    

                }
            }
            i++;
        }*/
    }
}
