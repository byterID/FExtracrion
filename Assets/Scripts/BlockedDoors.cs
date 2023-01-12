using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockedDoors : MonoBehaviour
{
    public GameObject AttentionSign;

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            AttentionSign.SetActive(true);
        }
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            AttentionSign.SetActive(false);
        }
    }
}
