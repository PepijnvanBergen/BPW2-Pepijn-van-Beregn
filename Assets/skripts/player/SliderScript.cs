using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour
{
    public Slider bossBar;
    public Slider armorBar;
    public Slider healthBar;
    public void UpdateBossHealth(float health)
    {
        bossBar.value = health;
    }
    public void UpdateHealth(float health)
    {
        //SetHealth(health);
        healthBar.value = health;
    }
    public void UpdateArmor(float armor)
    {
        armorBar.value = armor;
    }
}
