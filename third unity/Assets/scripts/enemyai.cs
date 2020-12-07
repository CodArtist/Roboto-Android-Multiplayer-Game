using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class enemyai : MonoBehaviour
{
    public Transform player;
    public Transform bullet; 
    public float health;
    public GameObject healthbar;
    private float speed = 10f;
    Rigidbody rg;
    // Start is called before the first frame update
    void Start()
    {
        rg = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    { Vector3 vec = transform.position - player.position;
        if (vec.magnitude <= 10)
        {
            Vector3 pos = Vector3.MoveTowards(transform.position, player.position, 3 * Time.fixedDeltaTime);

            rg.MovePosition(pos);
            transform.LookAt(player);
        }
    }


}
