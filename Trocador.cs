using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trocador : MonoBehaviour
{
    // inputs indentificadores que tu dos objs das cameras
    public GameObject cam1;
    public GameObject cam2;

    void Update()
    {

        // ativa e desativa as cameras
        if (Input.GetKey(KeyCode.F))
        {
            cam1.SetActive(false);
            cam2.SetActive(true);
        }
        else
        {
            cam1.SetActive(true);
            cam2.SetActive(false);
        }
    }
}
