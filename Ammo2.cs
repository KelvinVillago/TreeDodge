using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ammo2 : MonoBehaviour
{
    public Text t;
    private float ammo;
    public GameObject gun;
    private gun g;

    void Start()
    {
        g = gun.GetComponent<gun>();
        ammo = g.getAmmo();
        //healthBar = GameObject.Find("Ammunition").GetComponent<HealthBarController>();
        t = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        ammo = g.getAmmo();
        t.text = ammo.ToString();
    }
}
