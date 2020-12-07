using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{
    private Vector3 direction;
    //public GameObject robot;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                    RaycastHit hit;
                    //direction = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,Input.mousePosition.y,5));
                    if (Physics.Raycast(ray, out hit, 1000))
                    {
                        //Debug.DrawRay(ray.origin, ray.direction, Color.red);
                        direction = hit.point;
                    }
                    transform.LookAt(direction);
       /* int i =0;
        while (i < Input.touchCount)
        {
            Touch t = Input.GetTouch(i);
            if (t.phase == TouchPhase.Began||t.phase ==TouchPhase.Moved)
            {
                if (t.position.x > 100 && t.position.y > 200)

                {

                    Ray ray = Camera.main.ScreenPointToRay(t.position);
                    RaycastHit hit;
                    //direction = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,Input.mousePosition.y,5));
                    if (Physics.Raycast(ray, out hit, 1000))
                    {
                        //Debug.DrawRay(ray.origin, ray.direction, Color.red);
                        direction = hit.point;
                    }
                    transform.LookAt(direction);
                }

            }
            i++;
        }*/
    }
}
