using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterCreation : MonoBehaviour
{
    [SerializeField] private Text vitalityText;
    [SerializeField] private Text strengthText;
    [SerializeField] private Text dexterityText;
    [SerializeField] private Text intelligenceText;
    [SerializeField] private Image appearanceImage;
    [SerializeField] private Sprite boySprite;
    [SerializeField] private Sprite girlSprite;

    private string gender;
    private int vitalityValue;
    private int strengthValue;
    private int dexterityValue;
    private int intelligenceValue;

    public void AddVitality(int value)
    {
        vitalityValue += value;
        vitalityText.text = vitalityValue.ToString();
    }

    public void AddStrength(int value)
    {
        strengthValue += value;
        strengthText.text = strengthValue.ToString();
    }

    public void AddDexterity(int value)
    {
        dexterityValue += value;
        dexterityText.text = dexterityValue.ToString();
    }

    public void AddIntelligence(int value)
    {
        intelligenceValue += value;
        intelligenceText.text = intelligenceValue.ToString();
    }

    public void ChangeGender(string gender)
    {
        this.gender = gender.ToLower();
        appearanceImage.sprite = this.gender == "m" ? boySprite : girlSprite;
    }
}
