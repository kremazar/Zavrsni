using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Status : MonoBehaviour
{
    [SerializeField]
    private RectTransform health;
    [SerializeField]
    private Text healthText;

    void Start()
    {
        if (health == null)
        {
            Debug.LogError("No health bar");
        }
        if (healthText == null)
        {
            Debug.LogError("No health bar");
        }
    }
    public void SetHealth(int _cur, int _max)
    {
        float _value = (float)_cur / _max;
        health.localScale = new Vector3(_value, health.localScale.y, health.localScale.z);
        healthText.text = _cur + "/" + _max + "HP";
    }
   
}
