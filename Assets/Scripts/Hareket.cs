using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hareket : MonoBehaviour
{
    public GameManager gm;

    #region De�i�kenler
    [Header("Eksen H�zlar�")]

    [Tooltip("�leri gitme h�z�"), SerializeField]
    private float xEksenHiz;

    [Tooltip("Sa�a sola gitme h�z�"), SerializeField]
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
