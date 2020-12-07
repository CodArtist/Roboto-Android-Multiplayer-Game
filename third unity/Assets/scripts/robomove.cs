using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class robomove: MonoBehaviour
{
    public CharacterController controller;
    public float speed;
    public static float score = 0f;
    private Animator anim;
    protected Joystick joystick;
    private void Start()
    {
        joystick = FindObjectOfType<Joystick>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(score);

        float horizontal = /*joystick.Horizontal;*/Input.GetAxisRaw("Horizontal");

        float vertical = /*joystick.Vertical;*/Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical);
        if (horizontal != 0f || vertical != 0f)
        {
            anim.SetInteger("condition", 1);
            transform.forward = direction;
        }
        else
            anim.SetInteger("condition", 0);
        
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "enemy (1)")
        {
            SceneManager.LoadScene(0);
        }
    }
}
