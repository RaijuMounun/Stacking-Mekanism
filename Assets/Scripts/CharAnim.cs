using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharAnim : MonoBehaviour
{
    public GameManager gm;

    #region Deðiþkenler
    public Animator charAnim;
    #endregion

    #region Start
    private void Start()
    {
        charAnim = GetComponent<Animator>();
    }
    #endregion

    #region Update
    private void Update()
    {
        #region Karakter Animasyonu
        if (gm.oyunBasladi == true)
        {
            charAnim.SetBool("isRunning", true);
        }
        else
        {
            charAnim.SetBool("isRunning", false);
        }
        #endregion
    }
    #endregion
}
