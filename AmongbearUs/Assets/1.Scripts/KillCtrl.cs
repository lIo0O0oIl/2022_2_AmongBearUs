using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillCtrl : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject kill_anim, text_anim, mainView, effect, mainCamera;

    List<int> number = new List<int>();

    int count;

    // �ʱ�ȭ
    public void KillReset()
    {
        count = 0;

        kill_anim.SetActive(false);
        text_anim.SetActive(false);
        effect.SetActive(false);

        number.Clear();

        for (int i = 0; i < spawnPoints.Length; i++)
        {
            if (spawnPoints[i].childCount != 0)
            {
                Destroy(spawnPoints[i].GetChild(0).gameObject);
            }
        }

        NPCSpawn();
    }

    // NPC ����
    public void NPCSpawn()
    {
        int rand = Random.Range(0, 10);

        for (int i = 0; i < 5;)
        {
            // �ߺ��Ǿ��ٸ�
            if (number.Contains(rand))
            {
                rand = Random.Range(0, 10);
            }
            // �ߺ����� �ʾҴٸ�
            else
            {
                number.Add(rand);
                i++;
            }
        }

        // ����
        for (int i = 0; i < number.Count; i++)
        {
            Instantiate(Resources.Load("NPC"), spawnPoints[number[i]]);
        }
    }

    public void Kill()
    {
        count++;

        if (count == 5)
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

