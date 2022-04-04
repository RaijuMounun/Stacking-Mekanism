using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToplanabilirPara : MonoBehaviour
{
    public Toplayýcý toplayici;

    #region Deðiþkenler
    bool isCollected;
    int index;
    #endregion

    #region Start
    private void Start()
    {
        isCollected = false;
    }
    #endregion

    #region Update
    private void Update()
    {
        if (isCollected == true)
        {
            if (transform.parent != null)
            {
                transform.localPosition = new Vector3(0, -index, 0);
            }
        }        
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
