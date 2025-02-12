using UnityEngine;
using UnityEngine.UI;

public class InteractableObject : MonoBehaviour
{
    public Transform player; // Ссылка на трансформ персонажа
    public float textAppearDistance = 5f; // Расстояние для появления текста "Нажми E"
    public float interactionDistance = 3f; // Расстояние для взаимодействия (нажатие E)
   
    public Animator animator; // Ссылка на компонент аниматора
    public string animationName; // Имя анимации, которую нужно проиграть

    private bool isInTextRange = false; // Флаг, указывающий, находится ли игрок в зоне появления текста
    private bool isInInteractionRange = false; // Флаг, указывающий, находится ли игрок в зоне взаимодействия

    void Update()
    {
        float distanceToPlayer = Vector3.Distance(player.position, transform.position);

        // Проверяем, находится ли игрок в зоне появления текста
        if (distanceToPlayer <= textAppearDistance)
        {
            if (!isInTextRange)
            {
                isInTextRange = true;
               
            }

            // Проверяем, находится ли игрок в зоне взаимодействия
            if (distanceToPlayer <= interactionDistance)
            {
                if (!isInInteractionRange)
                {
                    isInInteractionRange = true;
                }

                // Проверяем, нажата ли клавиша "E" и находится ли игрок в зоне взаимодействия
                if (isInInteractionRange && Input.GetKeyDown(KeyCode.E))
                {
                    
                    animator.Play(animationName); // Проигрываем анимацию
                }
            }
            else
            {
                if (isInInteractionRange)
                {
                    isInInteractionRange = false;
                }
            }
        }
        else
        {
            if (isInTextRange)
            {
                isInTextRange = false;
               
            }

            if (isInInteractionRange)
            {
                isInInteractionRange = false;
            }
        }
    }
}