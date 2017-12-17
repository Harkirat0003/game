﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingplatform1 : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            collider.transform.SetParent(transform);
        }
    }

    void OnCollisionExit2D(Collision2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            collider.transform.SetParent(null);
        }
    }
}