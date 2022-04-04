using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toplayıcı : MonoBehaviour
{
    #region Değişkenler
    [SerializeField]
    private GameObject AnaPara;

    [SerializeField]
    private int stacked;
    #endregion

    #region Update
    private void Update()
    {
        AnaPara.transform.position = new Vector3(transform.position.x, stacked + 1, transform.position.z);
        this.transform.localPosition = new Vector3(0, -stacked, 0);
    }
    #endregion

    #region OnTriggerEnter
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Topla")
        {
            stacked += 1;
            other.gameObject.GetComponent<ToplanabilirPara>().CollectedYap();
            other.gameObject.GetComponent<ToplanabilirPara>().SetIndex(stacked);
            other.gameObject.transform.parent = AnaPara.transform;
        }
    }
    #endregion
}
