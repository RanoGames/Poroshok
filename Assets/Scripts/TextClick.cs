using UnityEngine;
using UnityEngine.UI;

public class TextClick : MonoBehaviour
{
    public Text textToHide;

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.E))
        {
            // ������ �����
            textToHide.gameObject.SetActive(false);
        }
    }
}