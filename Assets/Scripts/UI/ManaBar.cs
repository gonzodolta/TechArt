using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManaBar : MonoBehaviour

{
    public Slider manaSlider;
    public int max;
    public int current;

    public void SetMaxMana(int mana)
    {
        manaSlider.maxValue = mana;
    }
    public void SetMana(int mana)
    {
        manaSlider.value = mana;
    }

    private void Start()
    {
        SetMaxMana(max);
        SetMana(current);
    }
}
