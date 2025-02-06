using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DialogueManager : MonoBehaviour
{
    public Text dialogueText; // Ссылка на текстовое поле
    public string[] dialogues; // Массив строк для диалога
    private int currentDialogueIndex = 0; // Индекс текущего диалога

    void Start()
    {
        // Начинаем с первого диалога
        ShowDialogue();
    }

    void ShowDialogue()
    {
        // Проверяем, есть ли ещё диалоги
        if (currentDialogueIndex < dialogues.Length)
        {
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

    void EndDialogue()
    {
        // Логика завершения диалога (например, переход к следующей сцене или что-то ещё)
        Debug.Log("Dialogue ended");
    }
}
