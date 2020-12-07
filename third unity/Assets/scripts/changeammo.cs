using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeammo : MonoBehaviour
{public Sprite BulletButtonOn;
public Sprite BulletButtonOff;
public Sprite BombButtonOn;
public Sprite BombButtonOff;
    public void FireBullets()
    {if(GameObject.Find("Bullets").GetComponent<Image>().sprite!=BulletButtonOn)
        {GameObject.Find("Bullets").GetComponent<Image>().sprite=BulletButtonOn;
        GameObject.Find("Bomb").GetComponent<Image>().sprite=BombButtonOff;
        }
        FindObjectOfType<generateammo>().firebullets=true;
        FindObjectOfType<generateammo>().firebomb=false;
    }
    public void FireBomb()
    {if(GameObject.Find("Bomb").GetComponent<Image>().sprite!=BombButtonOn)
       {GameObject.Find("Bomb").GetComponent<Image>().sprite=BombButtonOn;
       GameObject.Find("Bullets").GetComponent<Image>().sprite=BulletButtonOff;
       }
        FindObjectOfType<generateammo>().firebullets=false;
        FindObjectOfType<generateammo>().firebomb=true;
    }
    
}
