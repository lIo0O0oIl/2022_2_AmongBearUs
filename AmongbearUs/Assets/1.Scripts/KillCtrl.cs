using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillCtrl : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject kill_anim, text_anim, mainView, effect, mainCamera;

    List<int> number = new List<int>();

    int count;

    // 초기화
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

    // NPC 스폰
    public void NPCSpawn()
    {
        int rand = Random.Range(0, 10);

        for (int i = 0; i < 5;)
        {
            // 중복되었다면
            if (number.Contains(rand))
            {
                rand = Random.Range(0, 10);
            }
            // 중복되지 않았다면
            else
            {
                number.Add(rand);
                i++;
            }
        }

        // 스폰
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

    // 모든 미션 성공 후 화면전환
    public void Change()
    {
        mainView.SetActive(true);
        gameObject.SetActive(false);

        // 캐릭터 삭제
        FindObjectOfType<PlayerCtrl>().DestroyPlayer();
    }
}

