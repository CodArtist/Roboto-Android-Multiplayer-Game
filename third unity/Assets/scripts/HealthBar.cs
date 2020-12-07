using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{ public Slider slider;
 public void setMaxHealth(int health)
 {
     slider.maxValue = health;
     slider.value=health;
 }
    // Start is called before the first frame update
   public void setHealth(int health)
   {
       slider.value=health;
   }
}
