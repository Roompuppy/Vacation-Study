using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject coin;

    void start()
    {
        CapsuleCollider col = coin.GetComponent<CapsuleCollider>();
    }

    void Update()
    {

    }
}
