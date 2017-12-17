using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class destruct : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D obj)
    {
        if (obj.gameObject.layer == LayerMask.NameToLayer("player"))
        {
            Destroy(obj.gameObject);
            Destroy(gameObject);
            SceneManager.LoadScene("End_Game");
        }
    }
}