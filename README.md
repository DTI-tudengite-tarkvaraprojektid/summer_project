# Maailmalõpukell
Tellijad: Triinu Jesmin, Jaagup Terasmaa<br>
Tarnijad: Andreas Malleus, Daniel Golubkov, Robin Rannavete, Martin Tšerdantsev<br>

Projekti eesmärk on  ELU projekti maailmalõpu lauamängule maailmalõpukella rakendus arendada. <br>
Rakenduses saab kella väärtust muuta, mängukaarte skaneerida ja tagastatud väärtuse järgi kaarte andmebaasist võtta. <br>
Andmebaasist võetud kaarte kuvatakse ekraanil ja nende väärtus lisatakse kellale juurde. <br>
Iga kord kui kella väärtus jagub 5-ga, võetakse vastav kaart andmebaasist. Kui kell liigub üles, võetakse positiivse mõjuga kaart, kui alla, negatiivse mõjuga kaart.<br>

Kasutatud tehnoloogiad:<br>
* Visual Studio 2019 Community Edition<br>
* Xamarin.Forms v4.0<br>
* NETStandard teek v2.0<br>
* Syncfusion.Xamarin Community Edition v17.1<br>
* SQLite-net v1.5<br>
* ZXing.Net.Mobile v2.4<br>
* Plugin.Permissions v3.0<br>

Projekti panustasid:<br>
1. Andreas Malleus - arendaja, tiimijuht, lõpuleviija <b> viide: https://github.com/Andreasmalleus </b><br>
2. Daniel Golubkov - arendaja, koodi disainer <b> viide: https://github.com/dangol9 </b><br>
3. Robin Rannavete - arendaja <b> viide: https://github.com/RobamaBinBombin </b><br>
4. Martin Tšerdantsev - arendaja, kliendiga suhtleja, testija <b> viide: https://github.com/iamcatcus </b><br>
* Jaanus Terasmaa - Loodus- ja terviseteaduste instituut - Ökoloogia keskuse juhataja, klient ja kontaktisik, tarnis mängukaartide infomratsiooni faili Google Sheets-is <b> viide: https://www.tlu.ee/inimesed/jaanus-terasmaa </b><br>

Arenduskeskkonna ülesseadmine: <br>
Paigaldada Visual Studio 2019 ja lisada laienduse "Mobile Development with .NET".<br>
Android SDK Manager-is allalaadida Android SDK-d projekti API tasemega (minimaalne API - 18; soovitatav - 28).<br> 
Seadistada Android Virtual Device Manager-is virtuaalne seade rakenduse silumiseks, või lubada USB kaudne silumine oma seadmel ning ühendada seda arvutiga ja panna debugger-i käima.<br>

Paigaldusjuhised (19.06.2019):<br>
Ühendada füüsiline seade arvutiga ülesseatud arenduskeskkonnaga. USB silumine peab olema seadmel lubatud.<br>
Käivitada rakendus arvutis ja oodata kuni seda lahkrivistatakse seadmele.<br>
