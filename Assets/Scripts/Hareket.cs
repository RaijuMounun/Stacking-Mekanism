using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hareket : MonoBehaviour
{
    public GameManager gm;

    #region Deðiþkenler
    [Header("Eksen Hýzlarý")]

    [Tooltip("Ýleri gitme hýzý"), SerializeField]
    private float xEksenHiz;

    [Tooltip("Saða sola gitme hýzý"), SerializeField]
    private float zEksenHiz;
    #endregion    

    #region Update
    void Update()
    {
        if (gm.oyunBasladi == true)
        {
            float yatayEksen = Input.GetAxis("Horizontal") * zEksenHiz * Time.deltaTime;    //yatay hareket
            this.transform.Translate(yatayEksen, 0, xEksenHiz * Time.deltaTime);        //ileri hareket
        }
    }
    #endregion
}
