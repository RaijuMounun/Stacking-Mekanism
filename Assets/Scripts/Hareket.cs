using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hareket : MonoBehaviour
{
    #region De�i�kenler
    [Header("Eksen H�zlar�")]

    [SerializeField]
    [Tooltip("�leri gitme h�z�")]
    private float xEksenHiz;

    [SerializeField]
    [Tooltip("Sa�a sola gitme h�z�")]
    private float zEksenHiz;

    bool oyunBasladi;
    public GameObject oyunuBaslatTus;
    #endregion

    #region Start
    private void Start()
    {
        oyunBasladi = false;
    }
    #endregion

    #region Update
    void Update()
    {
        if (oyunBasladi == true)
        {
            float yatayEksen = Input.GetAxis("Horizontal") * zEksenHiz * Time.deltaTime;    //yatay hareket
            this.transform.Translate(yatayEksen, 0, xEksenHiz * Time.deltaTime);        //ileri hareket
        }
    }
    #endregion

    #region OyunuBaslat
    public void OyunuBaslat()
    {
        oyunBasladi = true;
        oyunuBaslatTus.SetActive(false);
    }
    #endregion
}
