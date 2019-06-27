# ELU lauamängu maailmalõpukell
Tellijad: Triinu Jesmin, Jaanus Terasmaa<br>
Tarnijad: Andreas Malleus, Daniel Golubkov, Robin Rannavete, Martin Tšerdantsev<br>

Projekti eesmärk on  ELU projekti maailmalõpu lauamängule maailmalõpukella rakendus arendada. <br>
Rakenduses saab kella väärtust muuta, mängukaarte skanneerida ja tagastatud väärtuse järgi kaarte andmebaasist võtta. <br>
Andmebaasist võetud kaarte kuvatakse ekraanil ja nende väärtus lisatakse kellale juurde. <br>
Iga kord kui kella väärtus jagub 5-ga, võetakse vastav kaart andmebaasist. Kui kell liigub üles, võetakse positiivse mõjuga kaart, kui alla, negatiivse mõjuga kaart.<br>

* Rakendus on loodud <b>tarkvara praktika</b> ja <b>ELU-Lauamängu</b> projketi raames.

* Rakenduse pilt:<br>
![Screenshot](SavedImage.jpg)

Kasutatud tehnoloogiad:<br>
* Visual Studio 2019 Community Edition<br>
* Xamarin.Forms v4.0<br>
* NETStandard teek v2.0<br>
* Syncfusion.Xamarin Community Edition v17.1<br>
* SQLite-net v1.5<br>
* ZXing.Net.Mobile v2.4<br>
* Plugin.Permissions v3.0<br>

Projekti panustasid:<br>
1. Andreas Malleus - arendaja, tiimijuht, lõpuleviija <br>
2. Daniel Golubkov - arendaja, koodi disainer<br>
3. Robin Rannavete - arendaja, lõpuleviija<br>
4. Martin Tšerdantsev - arendaja, kliendiga suhtleja, testija<br>

Kliendid:<br>
* Jaanus Terasmaa - Loodus- ja terviseteaduste instituut - Ökoloogia keskuse juhataja, klient ja kontaktisik - tarnis mängukaartide infomratsiooni faili Google Sheets-is <br>
* Triinu Jesmin - Digitehnoloogiate instituut - andmeanalüüsi lektor, klient ja kontaktisik<br>

Telefonis installeerimine: <br>
Telefonis tuleb tõmmata alla antud repositooriumis APK fail, mis asub Install_juhend kaustas.<br>
Peale rakenduse alla tõmbamist, tuleb ka see installerida ning alles siis tekib rakenduse käivitamise võimalus <br>
Vajaminev õpetus on allpool dokumentide loetelus <br>


Arenduskeskkonna ülesseadmine: <br>
Paigaldada Visual Studio 2019 ja lisada laienduse "Mobile Development with .NET".<br>
Android SDK Manager-is allalaadida Android SDK-d projekti API tasemega (minimaalne API - 18; soovitatav - 28).<br> 
Seadistada Android Virtual Device Manager-is virtuaalne seade rakenduse silumiseks, või lubada USB kaudne silumine oma seadmel ning ühendada seda arvutiga ja panna debugger-i käima.<br>

Dokumendid (21.06.2019):<br>
<b> Viide paigaldusjuhisele APK failiga telefonis:
 https://github.com/dangol9/summer_project/blob/master/Install_Juhend/Installeerimise%20juhis%20APK%20failiga.pdf </b><br>
<b> Viide paigaldusjuhisele Visual Studios: https://github.com/dangol9/summer_project/blob/master/Install_Juhend/Installeerimise%20juhis%20visual%20studios.pdf </b><br>
<b> Viide testimisdokumentile: <b> https://github.com/dangol9/summer_project/blob/master/App_Testing/Testing.pdf </b><br>
<b> Viide dokumentatsioonile: <b> https://github.com/dangol9/summer_project/blob/master/Doc/documentation.pdf </b><br>
 
Teised failid:<br>
<b> Viide APK-le: https://github.com/dangol9/summer_project/blob/master/Install_Juhend/Elu_rakendus_install.apk </b><br>
[a link](https://github.com/dangol9/summer_project/blob/master/Install_Juhend/Elu_rakendus_install.apk)
