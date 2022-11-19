// встроенный объект
var WshShell = WScript.CreateObject("WScript.Shell");

// выводим сообщение
WshShell.Popup("Python 3 is not installed!", 0, "Error");

// завершаем работу с объектом
WScript.Quit();
