# *Задача*
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. при решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

# *Описание решения*

Для решения задачи используем ввод элементов массива с клавиатуры, изначально запрашиваем у пользователя количество этих элементов.
Создаем массив и выводим его на печать в виде строкового массива.

Проверяем каждый элемент массива - количество символов в строке меньше или равно 3. Если условие выполняется, то записываем данный элемент исходного массива (строку) в новый массив.
Если условие не выполняется переходим к проверке следующего элемента.

Если после проверки всех элементов исходного массива не найдены строки меньше или равные 3 символам, то выводим соответствующее сообщение: *"Искомые элементы массива не найдены"*

Если же новый массив заполнен, то выводим найденные элементы массива.