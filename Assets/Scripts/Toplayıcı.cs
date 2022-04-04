using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toplayıcı : MonoBehaviour
{
    #region Değişkenler
    GameObject AnaPara;

    [SerializeField]
    private int stacked;
    #endregion

    #region Start
    private void Start()
    {
        AnaPara = GameObject.Find("AnaPara");
    }
    #endregion

    #region Update
    private void Update()
    {
        AnaPara.transform.position = new Vector3(transform.position.x, stacked + 1, transform.position.z);
        this.transform.localPosition = new Vector3(0, -stacked, 0);
    }
    #endregion

    #region DecreaseStack
    public void DecreaseStack()
    {
        stacked--;
    }
    #endregion

    #region OnTriggerEnter
    private void OnTriggerEnter(Collider other)
    {
        if ((other.gameObject.tag == "Topla") && (other.gameObject.GetComponent<ToplanabilirPara>().GetisCollected() == false))
        {
            stacked += 1;
            other.gameObject.GetComponent<ToplanabilirPara>().CollectedYap();
            other.gameObject.GetComponent<ToplanabilirPara>().SetIndex(stacked);
            other.gameObject.transform.parent = AnaPara.transform;
        }
    }
    #endregion

    
}
