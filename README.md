# Credit Card Validity Check (Luhn Algorithm) ~ Kart Numarası Geçerliliği Kontrolü (Luhn Algoritması)
    #TR 🇹🇷
Kart Numarası Geçerliliği Kontrolü (Luhn Algoritması)

Bu proje, kredi kartı numaralarının geçerliliğini Luhn algoritması ile doğrulayan bir C# uygulamasıdır. Luhn algoritması, kredi kartı numaralarının doğru olup olmadığını kontrol etmek için yaygın olarak kullanılan bir yöntemdir. Algoritma, kart numarasının her basamağını belirli kurallara göre işleterek geçerliliğini kontrol eder.
Özellikler:

    Kullanıcıdan kart numarası alınır.
    Luhn algoritması kullanılarak kart numarasının geçerli olup olmadığı kontrol edilir.
    Eğer kart numarası geçerli ise "Kart Geçerli", geçersiz ise "Kart Geçersiz" mesajı görüntülenir.

Luhn Algoritması:

    Kart numarasının soldan başlayarak, her iki basamaktan birini ikiyle çarparız.
    Eğer iki katı 9'dan büyükse, basamağı ikiye ayırıp rakamlarını toplarız (örneğin, 12'nin rakamları 1 + 2).
    Tüm basamaklar toplandıktan sonra, toplamın 10'a tam bölünüp bölünmediği kontrol edilir.
    Eğer toplam 10'a tam bölünüyorsa, kart numarası geçerlidir. (Yani toplam sonucu 0 ile bitiyorsa)

Nasıl Kullanılır?

    GitHub reposunu klonlayın veya indirin.
    C# ile geliştirilmiş projeyi bir .NET destekli IDE (Visual Studio veya Visual Studio Code) üzerinde açın.
    Projeyi çalıştırın ve kullanıcıdan kart numarasını giriniz.
    Geçerlilik sonucu ekranda gösterilecektir.

Teknolojiler:

    C#
    .NET

Kullanıcı Girdisi:

    Kredi kartı numarası (Boşluklar dahil edilemez)
    
 
 <br>
    
    
    
    #ENG 🇬🇧

Credit Card Validity Check (Luhn Algorithm)

This project is a C# application that validates credit card numbers using the Luhn Algorithm. The Luhn algorithm is commonly used to check whether a credit card number is valid. The algorithm processes each digit of the card number according to specific rules to determine its validity.
Features:

    The user enters the credit card number.
    The Luhn algorithm is used to check whether the card number is valid.
    If the card number is valid, "Card Valid" is displayed; otherwise, "Card Invalid" is shown.

Luhn Algorithm:

    Starting from the left, every other digit is doubled.
    If the doubled value is greater than 9, split it and add the digits together (e.g., for 12, sum 1 + 2).
    After processing all digits, check if the total sum is divisible by 10.
    If the total sum is divisible by 10 (i.e., ends in 0), the card number is valid.

How to Use:

    Clone or download the GitHub repository.
    Open the project in a .NET-supported IDE (Visual Studio or Visual Studio Code).
    Run the project and input the credit card number when prompted.
    The validity result will be displayed on the screen.

Technologies:

    C#
    .NET

User Input:

    Credit card number (spaces are not allowed)
