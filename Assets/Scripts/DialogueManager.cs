using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public TMP_Text dialogueText; // Ссылка на текстовое поле
    public string[] dialogues; // Массив строк для диалога
    public AudioClip[] otherClip;
    public AudioSource audioS;
    private int currentDialogueIndex = 0; // Индекс текущего диалога
    [SerializeField] Animator CameraAnim;

    void Start()
    {
        // Начинаем с первого диалога
        ShowDialogue();
    }

    void Update()
    {
        
    }

    void ShowDialogue()
    {
        // Проверяем, есть ли ещё диалоги
        if (currentDialogueIndex < dialogues.Length)
        {
            audioS.clip = otherClip[currentDialogueIndex];
            audioS.Play();
            StartCoroutine(TypeSentence(dialogues[currentDialogueIndex]));
        }
        else
        {
            // Если диалоги закончились, можно скрыть текст или выполнить другую логику
            dialogueText.text = ""; // Скрываем текст
            EndDialogue();
        }
    }

    IEnumerator TypeSentence(string sentence)
    {
        dialogueText.text = ""; // Очищаем текстовое поле
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter; // Добавляем букву к тексту
            yield return new WaitForSeconds(0.05f); // Задержка между буквами (можно настроить)
        }
        yield return new WaitForSeconds(3f); // Задержка перед переходом к следующему диалогу
        NextDialogue();
    }

    void NextDialogue()
    {
        currentDialogueIndex++;
        ShowDialogue();
    }

    void SkipDialogue()
    {
        // Можно пропустить текущий диалог и сразу перейти к следующему
        StopAllCoroutines(); // Останавливаем текущий тип текста
        NextDialogue(); // Переходим к следующему диалогу
    }

    void EndDialogue()
    {
        gameObject.SetActive(false);
        // Логика завершения диалога (например, переход к следующей сцене или что-то ещё)
        Debug.Log("Dialogue ended");
        CameraAnim.enabled = false;
    }
}
