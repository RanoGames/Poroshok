using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
 
public class FpsSetting : MonoBehaviour {
 
    // Use this for initialization
    void Start() {
 
    }
 
    // Update is called once per frame
    void Update() {
 
    }
    public void ValueChanged()
    {
        Debug.Log("Выбран элемент №" + GetComponent<Dropdown>().value);
    }
}