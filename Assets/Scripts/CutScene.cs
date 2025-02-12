using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] GameObject Camera;
    [SerializeField] GameObject Body;
    [SerializeField] bool isAnimating;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isAnimating = !isAnimating;
        }
    }
}
