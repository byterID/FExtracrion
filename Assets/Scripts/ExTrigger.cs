using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExTrigger : MonoBehaviour
{
    [SerializeField]public GameObject Guide4;
    [SerializeField] public GameObject Fire;
    public void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "ExTrigger")
        {
            Guide4.SetActive(true);
            Fire.SetActive(true);
        }
    }
}
