using UnityEngine;
using UnityEngine.SceneManagement; // Не забудьте подключить этот namespace для работы со сценами
using UnityEngine.UI; // Для работы с UI элементами
using System.Collections;

public class MainMenuScript : MonoBehaviour
{
    [SerializeField] Animator CameraAnim;
    [SerializeField] GameObject Ui;
    [SerializeField] GameObject LoadingUi;
    public void PlayClick()
    {
        Ui.SetActive(false);
        CameraAnim.SetTrigger("Play");
        // Запускаем корутину для переключения сцены через 5 секунд
        StartCoroutine(SwitchSceneAfterDelay(5f));
    }

    private IEnumerator SwitchSceneAfterDelay(float delay)
    {
        // Ждем указанное количество секунд
        yield return new WaitForSeconds(delay);
        
        LoadingUi.SetActive(true);
        // Переключаем сцену. Убедитесь, что вы указали правильное имя сцены.
        SceneManager.LoadScene(1); // Замените "ИмяВашейСцены" на имя сцены, которую вы хотите загрузить
    }
    public void Exit()
    {
        Application.Quit();
    }
}