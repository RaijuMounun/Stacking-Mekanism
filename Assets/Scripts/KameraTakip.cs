using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraTakip : MonoBehaviour
{
    #region Deðiþkenler
    public GameObject karakter;
    public Vector3 mesafe;
    #endregion

    #region LateUpdate
    private void LateUpdate()
    {
        this.transform.position = Vector3.Lerp(this.transform.position, karakter.transform.position + mesafe, Time.deltaTime);
    }
    #endregion
}
