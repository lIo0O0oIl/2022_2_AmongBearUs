using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissionCtrl : MonoBehaviour
{
    public Slider gauge;
    public CircleCollider2D[] colls;

    public GameObject text_anim, mainView, effect, mainCamera;

    int missionCount;

    //�̼� �ʱ�ȭ
    public void MissionReset()
    {
        gauge.value = 0;
        missionCount = 0;

        for (int i = 0; i < colls.Length; i++)
        {
            colls[i].enabled = true;
        }

        text_anim.SetActive(false);
        effect.SetActive(false);
    }

    // �̼� �����ϸ� ȣ��
    public void MissionSuccess(CircleCollider2D coll)
    {
        missionCount++;

        gauge.value = missionCount / 7f;        // ������ ä����

        // ������ �̼��� �ٽ� �÷��� ���ϰ�
        coll.enabled = false;

        // ��� �̼� ���� üũ
        if (gauge.value == 1)
        {
            text_anim.SetActive(true);
            effect.transform.position = mainCamera.transform.position;
            effect.SetActive(true);

            Invoke("Change", 3f);
        }
    }

    // ��� �̼� ���� �� ȭ����ȯ
    public void Change()
    {
        mainView.SetActive(true);
        gameObject.SetActive(false);

        // ĳ���� ����
        FindObjectOfType<PlayerCtrl>().DestroyPlayer();
    }
}
