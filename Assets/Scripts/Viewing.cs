using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Viewing : MonoBehaviour
{
    public GameObject Canvas;
    private void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            Canvas.SetActive(true);
        }
    }
}
