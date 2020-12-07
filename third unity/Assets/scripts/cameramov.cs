using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cameramov : MonoBehaviour
{
    public CharacterController controller;
    public float speed;
    public static float score = 0f;
    protected Joystick joystick;


    // Update is called once per frame
    private void Start()
    {
        joystick = FindObjectOfType<Joystick>();
    }
    void Update()
    {
        Debug.Log(score);

        float horizontal = /*joystick.Horizontal;*/ Input.GetAxisRaw("Horizontal");
        float vertical = /*joystick.Vertical;*/Input.GetAxisRaw("Vertical");

        Vector3 direction = new Vector3(horizontal, 0f, vertical);
        controller.Move(direction * speed * Time.deltaTime);

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "enemy (1)")
        {
            SceneManager.LoadScene(0);
        }
    }
}
