using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider healthSlider;
    public int max;
    public int current;

    public void SetMaxHealth(int health)
    {
        healthSlider.maxValue = health;
    }
    public void SetHealth(int health)
    {
        healthSlider.value = health;
    }

    private void Start()
    {
        SetMaxHealth(max);
        SetHealth(current);
    }
}
