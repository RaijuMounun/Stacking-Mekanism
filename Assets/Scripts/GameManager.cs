using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region De�i�kenler
    public bool oyunBasladi;
    public bool oyunSonu;
    public GameObject oyunuBaslatTus;
    #endregion

    #region Start
    private void Start()
    {
        oyunBasladi = false;
        oyunSonu = false;
    }
    #endregion

    #region Update
    private void Update()
    {
        
    }
    #endregion

    #region Oyunu Ba�lat Tu�u
    public void OyunuBaslat()
    {
        oyunBasladi = true;
        oyunuBaslatTus.SetActive(false);
    }
    #endregion

    
}
