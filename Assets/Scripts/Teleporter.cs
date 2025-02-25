using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleporter : MonoBehaviour
{
    public int sceneToLoad; // Имя сцены, на которую будет телепорт

    private void OnTriggerEnter(Collider other)
    {
        // Проверяем, является ли объект игроком
        if (other.CompareTag("Player"))
        {
            // Загружаем указанную сцену
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}