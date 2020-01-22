using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jenga : MonoBehaviour
{
    public void OnMouseDrag(){
        Vector3 TapPos = Input.mousePosition;
        TapPos.z = 10f;
        transform.position = Camera.main.ScreenToWorldPoint(TapPos);
    }
}
