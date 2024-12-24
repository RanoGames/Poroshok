using UnityEngine;

public class Button : MonoBehaviour
{   
    [SerializeField] GameObject screamer;
    void OnMouseDown()
    {
        screamer.SetActive(true);
        Destroy(gameObject);
    }
}
