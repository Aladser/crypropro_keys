from winreg import *

aReg = ConnectRegistry(None,HKEY_LOCAL_MACHINE)
crypto_3_6 = r"SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Products\05480A45343B0B0429E4860F13549069\InstallProperties"
crypto_3_9 = r"SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Products\68A52D936E5ACF24C9F8FE4A1C830BC8\InstallProperties"
crypto_4 = r"SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Products\7AB5E7046046FB044ACD63458B5F481C\InstallProperties"
crypto_5 = r"SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Products\08F19F05793DC7340B8C2621D83E5BE5\InstallProperties"
regedit_keys = (crypto_3_6, crypto_3_9, crypto_4, crypto_5)

i=0
while True:
    try:
        if i == 4:
            print("КриптоПро не установлен")
            break
        aKey = OpenKey(aReg, regedit_keys[i])
        print()
        key = EnumValue(aKey, 7)
        print('КриптоПро', key[1])
        key = EnumValue(aKey, 2)
        print('Ключ = ', key[1])
        break
    except FileNotFoundError:
        i+=1
