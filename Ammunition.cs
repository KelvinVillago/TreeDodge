using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ammunition : MonoBehaviour
{
    public Slider bar;
    private float ammo;
    public GameObject gun;
    private gun g;

    void Start()
    {
        g = gun.GetComponent<gun>();
        ammo = g.getAmmo();
        //healthBar = GameObject.Find("Ammunition").GetComponent<HealthBarController>();
        bar = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        ammo = g.getAmmo();
        bar.value = ammo;
    }
}

