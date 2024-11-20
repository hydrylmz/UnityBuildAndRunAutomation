# Unity Build And Run Automation Script
A very short but very effective script to automate your Build And Run process!

:uk:	
This project contains a script for automating the build and run processes for Unity projects. It allows you to perform multiple builds and execute the resulting application automatically without having to manually intervene. The script can be executed via the Unity Editor.

## Features:
- **Automated build and run process**: Easily trigger the build and run sequence from Unity Editor.
- **Multiple builds**: Perform multiple builds with a customizable number of iterations.
- **Customizable parameters**: Easily modify the build folder path and the number of builds through Unity’s Inspector.

## Setup and Usage:

### 1. Using the Unity Editor:
1. Open your Unity project.
2. Add the `BuildAutomation.cs` script to the `Assets/Editor` folder in your project. **[Your script should be in a folder named Editor]**
3. In Unity, Go to **Window > Build Automation** from the top menu. The Build Automation tab should be there if you did everything correctly.
4. In the **Build Automation Inspector**, modify the `buildFolderPath` and `numberOfBuilds` values as desired.
5. Click the **Start Build** menu item to begin the build process.

### 3. Customizable Parameters:
- **`buildFolderPath`**: The directory where the build outputs will be saved. This path can be easily changed via the **Inspector**.
- **`numberOfBuilds`**: The number of builds to run. This value can be adjusted in the **Inspector**.

## System Requirements:
- **Unity 2020 or later**
- **Windows**

## Contributing:
- Fork the repository and make changes.
- Submit a pull request with your contributions.

### VERY IMPORTANT NOTE
- **This script only works for windows builds because it builds and runs .exe file. You can check for target platform in the script.**





# Unity Build ve Run Otomasyonu Scripti

Çok kısa ama çok etkili bir script ile Build ve Run işlemlerinizi otomatikleştirin!

:tr:  
Bu proje, Unity projelerinizde build ve run işlemlerini otomatikleştiren bir script içerir. Birden fazla build işlemi gerçekleştirmenizi ve çıkan uygulamaları otomatik olarak çalıştırmanızı sağlar, böylece manuel müdahale yapmanıza gerek kalmaz. Script, Unity Editor üzerinden çalıştırılabilir.

## Özellikler:
- **Otomatik build ve run işlemi**: Unity Editor üzerinden build ve run sırasını kolayca başlatabilirsiniz.
- **Birden fazla build**: Belirlediğiniz sayıda build işlemi gerçekleştirebilirsiniz.
- **Özelleştirilebilir parametreler**: Build klasör yolu ve build sayısını Unity'nin **Inspector** penceresinden kolayca değiştirebilirsiniz.

## Kurulum ve Kullanım:

### 1. Unity Editor Kullanarak:
1. Unity projenizi açın.
2. `BuildAutomation.cs` script dosyasını projenizin `Assets/Editor` klasörüne ekleyin. **[Script'inizin bir "Editor" isimli klasörde olması gerekiyor]**
3. Unity'de ekranınızın üst kısmından **Window > Build Automation** kısmına gidin. Build Automation sekmesi her şeyi doğru yaptıysanız orda olmalı.
4. **Build Automation Inspector** penceresinde `buildFolderPath` ve `numberOfBuilds` değerlerini istediğiniz gibi değiştirin.
5. **Start Build** tuşuna tıklayarak build işlemini başlatın.


### 3. Özelleştirilebilir Parametreler:
- **`buildFolderPath`**: Build çıktı dosyalarının kaydedileceği dizin. Bu yolu **Inspector** üzerinden kolayca değiştirebilirsiniz.
- **`numberOfBuilds`**: Gerçekleştirilecek build sayısı. Bu değer **Inspector** üzerinden ayarlanabilir.

## Sistem Gereksinimleri:
- **Unity 2020 veya daha yeni sürümler**
- **Windows**

## Katkıda Bulunma:
- Depoyu fork’layın ve değişikliklerinizi yapın.
- Değişikliklerinizi bir pull request (PR) olarak gönderin.

### ÖNEMLİ NOT
- **Bu script sadece windows buildleri için çalışır çünkü .exe dosyası build ediyor ve çalıştırıyor. Hedef platformu script içerisinden kontrol edebilirsiniz.**

