## AmongBearUs 🎮

게임 메뉴얼 : [https://url.kr/pyq6nf]

<br>

<!--  ## 코드 다이어그램 

<br> -->

## 파일 구조
<details>
<summary>눌러서 구조 보기</summary>

```bash
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
│  │      10. Hallway_4.png
│  │      2. Cafeteria.png
│  │      3. Lab.png
│  │      4. Prop_Down.png
│  │      5. Prop_Up.png
│  │      6. Electric.png
│  │      7. Hallway_1.png
│  │      8. Hallway_2.png
│  │      9. Hallway_3.png
│  │
│  ├─4. Item
│  │      Mission1.png
│  │      Mission2.png
│  │      Mission3.png
│  │      Mission4.png
│  │      Mission5.png
│  │      Mission6.png
│  │
│  ├─5. Mission
│  │  │  Cancle.png
│  │  │  Guage.png
│  │  │
│  │  ├─Mission1
│  │  │      Mission1_Back.png
│  │  │      Mission1_Btn.png
│  │  │
│  │  ├─Mission2
│  │  │      Mission2_1.png
│  │  │      Mission2_2.png
│  │  │      Mission2_3.png
│  │  │      Mission2_4.png
│  │  │      Mission2_5.png
│  │  │      Mission2_Back.png
│  │  │      Mission2_Handle.png
│  │  │
│  │  ├─Mission3
│  │  │      Mission3_Back.png
│  │  │
│  │  ├─Mission4
│  │  │      1.png
│  │  │      2.png
│  │  │      3.png
│  │  │      4.png
│  │  │      5.png
│  │  │      6.png
│  │  │      7.png
│  │  │      8.png
│  │  │      9.png
│  │  │      10.png
│  │  │      Mission4_Back.png
│  │  │
│  │  ├─Mission5
│  │  │      Mission5_Back.png
│  │  │      Mission5_Hadle.png
│  │  │      Mission5_Rotate.png
│  │  │
│  │  └─Mission6
│  │          Mission6_Back.png
│  │
│  ├─6. KillAnimation
│  │      1.png
│  │      2.png
│  │      3.png
│  │      4.png
│  │      5.png
│  │      6.png
│  │      7.png
│  │      8.png
│  │      9.png
│  │      10.png
│  │      11.png
│  │      12.png
│  │
│  └─7. good
│          celebration.png
│          Light.mat
│          Light.psd
│          missionClear.psd
│
├─3. Animation
│      BackGround.controller
│      Character.controller
│      Character_Idle.anim
│      Character_Walk.anim
│      KillAnimation.anim
│      Kill_Anim.controller
│      MissionUI.controller
│      Mission_Down.anim
│      Mission_Idle_Down.anim
│      Mission_Idle_Up.anim
│      Mission_Up.anim
│      Text.controller
│      Text_Success.anim
│      Trash_Shake.anim
│
├─4. Material
│      Blue.mat
│      Green.mat
│      Red.mat
│      Yellow.mat
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
</details>
<br>

## 참고

#### 사용한 도구
<div align="left"> <a href="#">
<img src="https://img.shields.io/badge/unity-%23000000.svg?style=for-the-badge&logo=unity&logoColor=white"><img src="https://img.shields.io/badge/Visual%20Studio%202022-5C2D91?style=for-the-badge&logo=Visual%20Studio&logoColor=white"><img src="https://img.shields.io/badge/GitHub-181717?style=for-the-badge&logo=GitHub&logoColor=white">
</a> </div>
<a href="#">
  <img src="https://img.shields.io/badge/Unity_Version-2021.3.8f1-blue?style=flat-square">
</a>
<br>

#### 기초반 수업 자료
<a href="#">
  <img alt="image" src="https://github.com/lIo0O0oIl/2022_2_AmongBearUs/assets/98943168/c69180f8-593c-492a-9c0e-4474ee2bf43a">
</a>
