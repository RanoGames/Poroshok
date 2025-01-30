using UnityEngine;
using UnityEngine.UI;


public class Scene1AnimCtrl : MonoBehaviour
{
    [SerializeField] Animator CameraAnim;
    [SerializeField] Animator TalkingAnim;
    [SerializeField] Animator RingsAnim;
    [SerializeField] bool IsAnimated;
    [SerializeField] GameObject PlayerBody;
    [SerializeField] GameObject Crosshair;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("WomanWorker")& IsAnimated == false) 
        {
            Debug.Log("Animation started");
            IsAnimated = true;
            RingsAnim.SetTrigger("RingsAnimation");
            TalkingAnim.SetTrigger("TalkingAnimation");
            Crosshair.SetActive(false);
            
            CameraAnim.enabled = true;
            CameraAnim.SetTrigger("CameraAnimation");
        }
    }
}