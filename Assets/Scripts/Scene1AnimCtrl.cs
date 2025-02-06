using UnityEngine;
using UnityEngine.UI;


public class Scene1AnimCtrl : MonoBehaviour
{
    [SerializeField] Animator CameraAnim;
    [SerializeField] Animator TalkingAnim;
    [SerializeField] Animator RingsAnim;
    [SerializeField] bool IsAnimatedOnce;
    [SerializeField] GameObject PlayerBody;
    [SerializeField] GameObject Crosshair;
    [SerializeField] GameObject DialogWindow;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Worker")& IsAnimatedOnce == false) 
        {
            Debug.Log("Animation started");
            DialogWindow.SetActive(true);
            IsAnimatedOnce = true;
            TalkingAnim.SetTrigger("TalkingAnimation");
            Crosshair.SetActive(false);
            CameraAnim.enabled = true;
            CameraAnim.SetTrigger("CameraAnimation");
        }
    }
    void Update()
    {

    }
}