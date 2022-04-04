using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hareket : MonoBehaviour
{
    [Header("Eksen H�zlar�")]
    [SerializeField]
    [Tooltip("�leri gitme h�z�")]
    private float xEksenHiz;
    [SerializeField]
    [Tooltip("Sa�a sola gitme h�z�")]
    private float zEksenHiz;

    void Update()
    {
        float yatayEksen = Input.GetAxis("Horizontal")*zEksenHiz*Time.deltaTime;    //yatay hareket
        this.transform.Translate(yatayEksen, 0, xEksenHiz * Time.deltaTime);        //ileri hareket
    }
}
