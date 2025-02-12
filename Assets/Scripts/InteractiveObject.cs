using UnityEngine;
using UnityEngine.UI;

public class InteractableObject : MonoBehaviour
{
    public Transform player; // ������ �� ��������� ���������
    public float textAppearDistance = 5f; // ���������� ��� ��������� ������ "����� E"
    public float interactionDistance = 3f; // ���������� ��� �������������� (������� E)
   
    public Animator animator; // ������ �� ��������� ���������
    public string animationName; // ��� ��������, ������� ����� ���������

    private bool isInTextRange = false; // ����, �����������, ��������� �� ����� � ���� ��������� ������
    private bool isInInteractionRange = false; // ����, �����������, ��������� �� ����� � ���� ��������������

    void Update()
    {
        float distanceToPlayer = Vector3.Distance(player.position, transform.position);

        // ���������, ��������� �� ����� � ���� ��������� ������
        if (distanceToPlayer <= textAppearDistance)
        {
            if (!isInTextRange)
            {
                isInTextRange = true;
               
            }

            // ���������, ��������� �� ����� � ���� ��������������
            if (distanceToPlayer <= interactionDistance)
            {
                if (!isInInteractionRange)
                {
                    isInInteractionRange = true;
                }

                // ���������, ������ �� ������� "E" � ��������� �� ����� � ���� ��������������
                if (isInInteractionRange && Input.GetKeyDown(KeyCode.E))
                {
                    
                    animator.Play(animationName); // ����������� ��������
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