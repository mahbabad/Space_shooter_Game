<img width="1280" height="320" alt="Image" src="https://github.com/user-attachments/assets/7875def2-4f6f-4306-bae0-82594e7afd86" />

  # 🚀 SpaceShooter
 <p>Developers : Parsa jaladaty & Mahdi Bateni </p>
<h2>Student ID :</h2>
<p> Parsa Jaladaty : 404521228 , Mahdi Bateni : 404521111</p>

<h2>Basic information :</h2>
<p>This is a remastered 2D game designed and developed using object-oriented principles in C#. It features a small in-game shop—built using SQLite with basic database interaction—where players can purchase faster and more powerful spaceships using in-game coins.
</p>
<p>The images and assets used in the game's UI were created from scratch with care and creativity; additionally, WinForms was utilized to ensure the UI is dynamic, lightweight, and easily extensible.</p>


<p align = center>
  
![C#](https://img.shields.io/badge/C%23-%23239120.svg?style=for-the-badge&logo=csharp&logoColor=white)
![SQLite](https://img.shields.io/badge/sqlite-%2307405e.svg?style=for-the-badge&logo=sqlite&logoColor=white)
![WinForms](https://img.shields.io/badge/Framework-WinForms-512BD4?style=for-the-badge&logo=.net&logoColor=white)
</p>

<h2>ScreenShots and Environment :</h2>

<p align = center>
  
<img width="405" height="801" alt="Screenshot 2026-07-13 163620" src="https://github.com/user-attachments/assets/5d0910db-dace-491a-b8dd-fcd4642840f8" />

  
</p>

<p align = center>

<img width="401" height="792" alt="Screenshot 2026-07-13 164124" src="https://github.com/user-attachments/assets/04bb5a71-d95f-4bed-af25-19c5500ff87f" />


</p>

<p align = center >
  
<img width="399" height="811" alt="Screenshot (58)" src="https://github.com/user-attachments/assets/469feacb-d2f5-4043-89ba-43653c366d63" />


</p>


<h2> Implemented features : </h2>

### 🚀 Key Features 
- Implements a wave-based enemy formation system.

- Supports dynamic collision detection between projectiles, enemies, and the player.

-Separates responsibilities across entity, logic, data, and UI layers.

- Provides multi-directional shooting mechanics for both player and boss enemies.

- Integrates an SQLite-based shop system using the Repository pattern.

- Includes custom-designed visual elements and environments.

<h2>Architecture and Folder Structure :</h2>

```
📂 SpaceShooter

 ┣ 📂 Core
 
 ┃ ┣ 📜 GameEngine.cs
 ┃ ┣ 📜 GameSession.cs
 ┃ ┗ 📜 ...
 
 ┣ 📂 Data
 
 ┃ ┣ 📜 ShopItemRepository.cs
 ┃ ┗ 📜 ...
 
 ┣ 📂 Models
 
 ┃ ┣ 📜 BaseEntity.cs
 ┃ ┣ 📜 BaseEnemy.cs
 ┃ ┗ 📜 ...

 ┣ 📂 Views

 
 ┃ ┣ 📂 Forms
 ┃ ┃ ┣ 📜 GameForm.cs
 ┃ ┃ ┣ 📜 ShopForm.cs
 ┃ ┃ ┗ 📜 ...
 ┃ ┗ 📜 ...
 ┣ 📜 SpaceShooter.sln
 ┗ 📜 README.md
```
<p>Due to the project's simplicity, we did not employ specific architectures like MVC; however, we strove to keep the code flexible and extensible, utilizing a layered structure to separate responsibilities.</p>

<h2>🚀 Setup and Execution Guide :</h2>
To run the project on your system, follow the steps below:

- **First :**, clone the repository:

 **Clone the repository**
 
`
git clone https://github.com/mahbabad/Space_shooter_Game
`

 **Navigate to the directory**
 
 `
cd SpaceShooter
`


- **Open in Visual Studio :**

Open SpaceShooter.sln with Visual Studio 2026 or later.
Make sure you have the .NET Desktop Development workload installed.

-**Build & Run:**
```
Press F5 or click the Start button in Visual Studio.
The SQLite database will be created automatically on the first run (if not present).
```

## 🎓 Project Context
This project was developed as a university project with a focus on:
- Object-oriented design
- Layered code organization
- Basic database integration using SQLite
- Custom UI and gameplay implementation in WinForms



## 📄 License
This project is intended for educational purposes.





