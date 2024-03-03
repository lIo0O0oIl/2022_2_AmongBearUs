# AmongBearUs

<div align="center">
<a href="#">
  <img alt="image" src="https://github.com/lIo0O0oIl/2022_2_AmongBearUs/assets/98943168/d1d2491e-4adb-454b-a9b2-672836bbf76b">
</a>
<!--타이틀 잘라서 넣어주기-->

<!--
[![Hits](https://hits.seeyoufarm.com/api/count/incr/badge.svg?url=https%3A%2F%2Fgithub.com%2FlIo0O0oIl%2F2022_1_Only_One_Chance&count_bg=%23EEEE0E&title_bg=%23555555&icon=&icon_color=%23E7E7E7&title=hits&edge_flat=false)](https://hits.seeyoufarm.com)
-->

</div> <!--가운데 정렬은 여기까지-->

## 프로젝트 정보
> **1학년 여름방학 유니티 기초반 수업**  
> **2022.7.21 ~ 2022.7.29**

## 게임 설명
<div align="center">

|  InGame   |
| :-------: |
| <a href="#"> <img alt="image" width="250" src=""> <img alt="image" width="250" src=""> </a> |

|   Intro   |   Outro   |
|:---------:|:---------:|
| <a href="#"> <img alt="image" width="250" src=""> </a> | <a href="#"> <img alt="image" width="250" src=""> </a> |

</div>

> **Only One Chance는 1학년 1학기 동안 배운 내용을 응용해서 약 1개월동안 만든 간단한 PC 슈팅게임입니다.**  
> **플레이어 쪽으로 날라오는 적, 한 방향으로 내려오는 적이 랜덤으로 생성되며 3가지의 패턴을 가진 보스가 존재합니다.**

## 빌드본 다운
> **구글 드라이브** : [https://drive.google.com/file/d/1yi15vQp7MBOX9OUXNNc79FEmomPVpFd9/view?usp=sharing] <br>

## 개발팀 소개
<div align="center">

| <a href="https://github.com/lIo0O0oIl"> lIo0O0oIl </a> |
| :-----------: |
| <a href="https://github.com/lIo0O0oIl"> <img alt="image" width="200" src="https://github.com/lIo0O0oIl.png"> </a> |
| 1인 개발 |

</div>

## 사용한 것들
<div align="left"> <a href="#">
<img src="https://img.shields.io/badge/unity-%23000000.svg?style=for-the-badge&logo=unity&logoColor=white">
<img src="https://img.shields.io/badge/Visual%20Studio%202022-5C2D91?style=for-the-badge&logo=Visual%20Studio&logoColor=white">
<img src="https://img.shields.io/badge/GitHub-181717?style=for-the-badge&logo=GitHub&logoColor=white">
</a> </div>
<a href="#">
  <img src="https://img.shields.io/badge/Unity_Version-2021.3.8f1-blue?style=flat-square">
</a>

## 구조
<!--
```bash
2022_1_ONLY_ONE_CHANCE\ASSETS
├─1_Scenes
│      GameClaer.unity
│      GameOver.unity
│      Intro.unity
│      Play.unity
│
├─2_Scripts
│  │  ButtonEvent.cs
│  │  Leave.cs
│  │  Leave.cs.meta
│  │
│  └─GamePlay
│          AutoDestroyer.cs
│          Boss.cs
│          BossBullet.cs
│          BossHP.cs
│          Bullet.cs
│          Bulletile.cs
│          Enemy.cs
│          EnemySpawner.cs
│          Enemytile.cs
│          Mana.cs
│          ManaViewer.cs
│          Movement.cs
│          Player.cs
│          PlayerHP.cs
│          PlayerHPViewer.cs
│          PlayerScoreViewer.cs
│          ResultScoreViewer.cs
│          StageData.asset
│          StageData.cs
│
├─3_Prefabs
│      BossBullet.prefab
│      Bullet.prefab
│      Enemy.prefab
│
├─4_Sounds
         Rinne - Connect.mp3

AMONGBEARUS\ASSETS
├─0. Scenes
│      SampleScene.unity
│
├─1.Scripts
│  │  KillCtrl.cs
│  │  MainMenu.cs
│  │  NPCCtrl.cs
│  │
│  ├─Mission
│  │      Mission1.cs
│  │      Mission2.cs
│  │      Mission3.cs
│  │      Mission4.cs
│  │      Mission5.cs
│  │      Mission6.cs
│  │      MissionCtrl.cs
│  │
│  └─Player
│          JoyStick.cs
│          PlayerCtrl.cs
│          Settings.cs
│
├─2. Sprites
│  │  AtlasAll.spriteatlas
│  │  Icon.png
│  │
│  ├─0. Particle
│  │      Bubble.mat
│  │      bubble.png
│  │      Rose.mat
│  │      rose.png
│  │
│  ├─1. UI
│  │  ├─Main Menu
│  │  │      AmongBearUs_Title.png
│  │  │      human-skull.png
│  │  │      Main_1.png
│  │  │      Main_2.png
│  │  │      Main_3.png
│  │  │      Main_Title.png
│  │  │      mission.png
│  │  │      quit 1.png
│  │  │
│  │  ├─Player
│  │  │      JoyStick.png
│  │  │      Kill.png
│  │  │      Use.png
│  │  │
│  │  └─Setting
│  │          Setting.png
│  │          Setting_Back.png
│  │          Setting_Btn.png
│  │
│  ├─2. Character
│  │  ├─1
│  │  │      1.png
│  │  │      2.png
│  │  │      3.png
│  │  │      4.png
│  │  │      5.png
│  │  │      6.png
│  │  │      7.png
│  │  │      Dead.png
│  │  │
│  │  ├─2
│  │  │      1.png
│  │  │      2.png
│  │  │      3.png
│  │  │      4.png
│  │  │      5.png
│  │  │      6.png
│  │  │      7.png
│  │  │      Dead.png
│  │  │
│  │  ├─3
│  │  │      1.png
│  │  │      2.png
│  │  │      3.png
│  │  │      4.png
│  │  │      5.png
│  │  │      6.png
│  │  │      7.png
│  │  │      Dead.png
│  │  │
│  │  ├─4
│  │  │      1.png
│  │  │      2.png
│  │  │      3.png
│  │  │      4.png
│  │  │      5.png
│  │  │      6.png
│  │  │      7.png
│  │  │      Dead.png
│  │  │
│  │  └─5
│  │          1.png
│  │          2.png
│  │          3.png
│  │          4.png
│  │          5.png
│  │          6.png
│  │          7.png
│  │          Dead.png
│  │
│  ├─3. Map
│  │      1. Back.png
│  │      1. Back.png.meta
│  │      10. Hallway_4.png
│  │      10. Hallway_4.png.meta
│  │      2. Cafeteria.png
│  │      2. Cafeteria.png.meta
│  │      3. Lab.png
│  │      3. Lab.png.meta
│  │      4. Prop_Down.png
│  │      4. Prop_Down.png.meta
│  │      5. Prop_Up.png
│  │      5. Prop_Up.png.meta
│  │      6. Electric.png
│  │      6. Electric.png.meta
│  │      7. Hallway_1.png
│  │      7. Hallway_1.png.meta
│  │      8. Hallway_2.png
│  │      8. Hallway_2.png.meta
│  │      9. Hallway_3.png
│  │      9. Hallway_3.png.meta
│  │
│  ├─4. Item
│  │      Mission1.png
│  │      Mission1.png.meta
│  │      Mission2.png
│  │      Mission2.png.meta
│  │      Mission3.png
│  │      Mission3.png.meta
│  │      Mission4.png
│  │      Mission4.png.meta
│  │      Mission5.png
│  │      Mission5.png.meta
│  │      Mission6.png
│  │      Mission6.png.meta
│  │
│  ├─5. Mission
│  │  │  Cancle.png
│  │  │  Cancle.png.meta
│  │  │  Guage.png
│  │  │  Guage.png.meta
│  │  │  Mission1.meta
│  │  │  Mission2.meta
│  │  │  Mission3.meta
│  │  │  Mission4.meta
│  │  │  Mission5.meta
│  │  │  Mission6.meta
│  │  │
│  │  ├─Mission1
│  │  │      Mission1_Back.png
│  │  │      Mission1_Back.png.meta
│  │  │      Mission1_Btn.png
│  │  │      Mission1_Btn.png.meta
│  │  │
│  │  ├─Mission2
│  │  │      Mission2_1.png
│  │  │      Mission2_1.png.meta
│  │  │      Mission2_2.png
│  │  │      Mission2_2.png.meta
│  │  │      Mission2_3.png
│  │  │      Mission2_3.png.meta
│  │  │      Mission2_4.png
│  │  │      Mission2_4.png.meta
│  │  │      Mission2_5.png
│  │  │      Mission2_5.png.meta
│  │  │      Mission2_Back.png
│  │  │      Mission2_Back.png.meta
│  │  │      Mission2_Handle.png
│  │  │      Mission2_Handle.png.meta
│  │  │
│  │  ├─Mission3
│  │  │      Mission3_Back.png
│  │  │      Mission3_Back.png.meta
│  │  │
│  │  ├─Mission4
│  │  │      1.png
│  │  │      1.png.meta
│  │  │      10.png
│  │  │      10.png.meta
│  │  │      2.png
│  │  │      2.png.meta
│  │  │      3.png
│  │  │      3.png.meta
│  │  │      4.png
│  │  │      4.png.meta
│  │  │      5.png
│  │  │      5.png.meta
│  │  │      6.png
│  │  │      6.png.meta
│  │  │      7.png
│  │  │      7.png.meta
│  │  │      8.png
│  │  │      8.png.meta
│  │  │      9.png
│  │  │      9.png.meta
│  │  │      Mission4_Back.png
│  │  │      Mission4_Back.png.meta
│  │  │
│  │  ├─Mission5
│  │  │      Mission5_Back.png
│  │  │      Mission5_Back.png.meta
│  │  │      Mission5_Hadle.png
│  │  │      Mission5_Hadle.png.meta
│  │  │      Mission5_Rotate.png
│  │  │      Mission5_Rotate.png.meta
│  │  │
│  │  └─Mission6
│  │          Mission6_Back.png
│  │          Mission6_Back.png.meta
│  │
│  ├─6. KillAnimation
│  │      1.png
│  │      1.png.meta
│  │      10.png
│  │      10.png.meta
│  │      11.png
│  │      11.png.meta
│  │      12.png
│  │      12.png.meta
│  │      2.png
│  │      2.png.meta
│  │      3.png
│  │      3.png.meta
│  │      4.png
│  │      4.png.meta
│  │      5.png
│  │      5.png.meta
│  │      6.png
│  │      6.png.meta
│  │      7.png
│  │      7.png.meta
│  │      8.png
│  │      8.png.meta
│  │      9.png
│  │      9.png.meta
│  │
│  └─7. good
│          celebration.png
│          celebration.png.meta
│          Light.mat
│          Light.mat.meta
│          Light.psd
│          Light.psd.meta
│          missionClear.psd
│          missionClear.psd.meta
│
├─3. Animation
│      BackGround.controller
│      BackGround.controller.meta
│      Character.controller
│      Character.controller.meta
│      Character_Idle.anim
│      Character_Idle.anim.meta
│      Character_Walk.anim
│      Character_Walk.anim.meta
│      KillAnimation.anim
│      KillAnimation.anim.meta
│      Kill_Anim.controller
│      Kill_Anim.controller.meta
│      MissionUI.controller
│      MissionUI.controller.meta
│      Mission_Down.anim
│      Mission_Down.anim.meta
│      Mission_Idle_Down.anim
│      Mission_Idle_Down.anim.meta
│      Mission_Idle_Up.anim
│      Mission_Idle_Up.anim.meta
│      Mission_Up.anim
│      Mission_Up.anim.meta
│      Text.controller
│      Text.controller.meta
│      Text_Success.anim
│      Text_Success.anim.meta
│      Trash_Shake.anim
│      Trash_Shake.anim.meta
│
├─4. Material
│      Blue.mat
│      Blue.mat.meta
│      Green.mat
│      Green.mat.meta
│      Red.mat
│      Red.mat.meta
│      Yellow.mat
│      Yellow.mat.meta
│
└─Resources
    │  Character.prefab
    │  NPC.prefab
    │
    └─Trash
            Trash1.prefab
            Trash2.prefab
            Trash3.prefab
            Trash4.prefab
            Trash5.prefab
```
주석 지우기~~-->

## 참고
<img>
