using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToplanabilirPara : MonoBehaviour
{
    public Toplayýcý toplayici;
    public GameManager gm;

    #region Deðiþkenler
    bool isCollected;
    int index;
    public Transform paraTransform;
    public Vector3 hedef;
    public GameObject AnaParaParent;
    public float time = 1;
    public float timer = 0;
    #endregion

    #region Start
    private void Start()
    {
        DOTween.Init();
        isCollected = false;
        paraTransform = this.transform;        
    }
    #endregion

    #region Update
    private void Update()
    {
        #region Para Pozisyonu
        if (isCollected == true)
        {
            if (transform.parent != null)
            {
                transform.localPosition = new Vector3(0, -index, 0);
            }
        }
        #endregion

        #region para isimlendirme
        for (int i = 0; i < toplayici.stacked; i++)
        {
            AnaParaParent.gameObject.transform.GetChild(i + 2).name = (i).ToString();
        }
        #endregion

        #region Oyun sonu para animasyonu
        if (gm.oyunSonu == true && transform.parent != null)
        {
            if (toplayici.stacked-1 == System.Convert.ToInt32(this.gameObject.name))
            {
                paraTransform.DOMoveX(-107+toplayici.stacked, 3);
                if (timer < 1)
                {
                    timer += Time.deltaTime;
                }
                if (timer/time >= 1)
                {
                    timer = 1;
                    toplayici.stacked--;
                }
            }            
        }
        #endregion
    }
    #endregion

    #region Property
    public bool GetisCollected()
    {
        return isCollected;
    }
    #endregion

    #region CollectedYap func.
    public void CollectedYap()
    {
        isCollected = true;
    }
    #endregion

    #region SetIndex Func.
    public void SetIndex(int index)
    {
        this.index = index;
    }
    #endregion

    #region OnTriggerEnter
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Engel")
        {
            toplayici.DecreaseStack();
            transform.parent = null;
            GetComponent<BoxCollider>().enabled = false;
            other.gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }
    #endregion
}
