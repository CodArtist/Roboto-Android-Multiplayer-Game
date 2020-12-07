using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class charactermove: MonoBehaviour
{
    public CharacterController controller;
    public float speed = 30f;
    public static float score = 0f;
    


    // Update is called once per frame
    void Update()
    {
        Debug.Log(score);
        
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

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
