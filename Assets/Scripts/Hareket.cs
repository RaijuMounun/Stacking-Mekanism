using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hareket : MonoBehaviour
{
    [Header("Eksen Hýzlarý")]
    [SerializeField]
    [Tooltip("Ýleri gitme hýzý")]
    private float xEksenHiz;
    [SerializeField]
    [Tooltip("Saða sola gitme hýzý")]
    private float zEksenHiz;

    void Update()
    {
        float yatayEksen = Input.GetAxis("Horizontal")*zEksenHiz*Time.deltaTime;    //yatay hareket
        this.transform.Translate(yatayEksen, 0, xEksenHiz * Time.deltaTime);        //ileri hareket
    }
}
