using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class canvasupdate : MonoBehaviour
{
    public Text Score;
    // Start is called before the first frame update
    void Start()
    {
        //Score = GetComponent<Text>();

        //Score.transform.position = new Vector3(600, -22);
    }

    // Update is called once per frame
    void Update()
    {
        Score.text =charactermove.score.ToString();
        
    }
}
