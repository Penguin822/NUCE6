using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangeGuideFont : MonoBehaviour
{
    public TMP_FontAsset newFont; // �s���r��

    void Update()
    {
        // �M��������Ҧ��� TMP_Text ����
        TMP_Text[] allTMPTextComponents = FindObjectsOfType<TMP_Text>();

        foreach (TMP_Text textComponent in allTMPTextComponents)
        {
            // �ˬd textComponent �O�_�ŦX�ݭn���r��������
            // �o�̧A�i�H�K�[��L�������ˬd�A��p�ھڤ�r���e��
            if (textComponent.name == "DirectionsLabel") // �Ϊ̥i�H�ϥΨ�L��������ˬd
            {
                // ��� TextMeshPro ���󪺦r��
                textComponent.font = newFont;
            }
        }
    }
}
