# АНАЛИЗ ДАННЫХ И ИСКУССТВЕННЫЙ ИНТЕЛЛЕКТ [in GameDev]
Отчет по лабораторной работе #3 выполнил(а):
- Рушкова Ольга Игоревна
- РИ210940
Отметка о выполнении заданий (заполняется студентом):

| Задание | Выполнение | Баллы |
| ------ | ------ | ------ |
| Задание 1 | * | 60 |
| Задание 2 | * | 20 |
| Задание 3 | * | 20 |

знак "*" - задание выполнено; знак "#" - задание не выполнено;

Работу проверили:
- к.т.н., доцент Денисов Д.В.
- к.э.н., доцент Панов М.А.
- ст. преп., Фадеев В.О.

[![N|Solid](https://cldup.com/dTxpPi9lDf.thumb.png)](https://nodesource.com/products/nsolid)

[![Build Status](https://travis-ci.org/joemccann/dillinger.svg?branch=master)](https://travis-ci.org/joemccann/dillinger)

Структура отчета

- Данные о работе: название работы, фио, группа, выполненные задания.
- Цель работы.
- Задание 1.
- Код реализации выполнения задания. Визуализация результатов выполнения (если применимо).
- Задание 2.
- Код реализации выполнения задания. Визуализация результатов выполнения (если применимо).
- Задание 3.
- Код реализации выполнения задания. Визуализация результатов выполнения (если применимо).
- Выводы.
- ✨Magic ✨

## Цель работы
Познакомиться с программными средствами для создания системы машинного обучения и ее интеграции в Unity.

## Задание 1 - Реализовать систему машинного обучения в связке Python - Google-Sheets – Unity.

Реализация заданий представлена в виде скринов
1. Установить нужные библиотеки: скрины, к сожалению, после перезагрузки сделать не удалось, но реализация дальнейшей части работы подтверждает, что необходимые библиотеки были установлены (на скрине запуска работы агента в разделе  Version information:)

2. Создать на сцене плоскость, куб и сферу:
![изображение](https://user-images.githubusercontent.com/98802409/198323924-83a1c293-b916-40d3-acd4-0cbce74c96e4.png)
3. Добавить скрипт RollerAgent.cs и настроить компоненты для RollerAgent:
![изображение](https://user-images.githubusercontent.com/98802409/198324194-0e7426eb-57b9-47ff-9303-eafb0b554aff.png)
![изображение](https://user-images.githubusercontent.com/98802409/198324284-85fa6b84-d376-47fb-8ead-22d9e17fe687.png)

4. Запустить работу ml-агента
![изображение](https://user-images.githubusercontent.com/98802409/200939505-afdc5bec-c253-420d-9e6e-1da9f0126057.png)
5. Работа агента на 1 полигоне:
![изображение](https://github.com/SomEnaMeforme/DA-in-GameDev-lab1/blob/task_3/%D0%B4%D0%BB%D1%8F%20%D0%BB%D0%B0%D0%B1%D1%8B%20-1.gif)
9 полигонов:

![изображение](https://github.com/SomEnaMeforme/DA-in-GameDev-lab1/blob/task_3/%D0%B4%D0%BB%D1%8F%20%D0%BB%D0%B0%D0%B1%D1%8B%20-9.gif)
результат:
![изображение](https://user-images.githubusercontent.com/98802409/200949926-f23cad0a-cdb7-4590-85cd-010d4ae445ca.png)
28 полигонов:
![изображение](https://github.com/SomEnaMeforme/DA-in-GameDev-lab1/blob/task_3/%D0%B4%D0%BB%D1%8F%20%D0%BB%D0%B0%D0%B1%D1%8B%20-%2028.gif)
результат:
![изображение](https://user-images.githubusercontent.com/98802409/200953043-2dddfe57-19fa-4c0f-9a81-f85d13db73ed.png)
6. Работа агента после изменения модели: 
![изображение](https://github.com/SomEnaMeforme/DA-in-GameDev-lab1/blob/task_3/%D0%B4%D0%BB%D1%8F%20%D0%BB%D0%B0%D0%B1%D1%8B%20-1.2.gif)




## Задание 2
###Подробно опишите каждую строку файла конфигурации нейронной сети, доступного в папке с файлами проекта по ссылке. Самостоятельно найдите информацию о компонентах Decision Requester, Behavior Parameters, добавленных на сфере.

+ Decision Requester - отвечает за чередование решений при действии во время обучения: либо агент действует наугад, либо в связи с уже имеющиеся данными по состояниям и действиям в данном состоянии
+ Behavior Parameters - параметры поведения агента, от которых зависит то, чем он будет руководствоваться, совершая действия, определяет модель, которая отвечает за оптимальные действия в тех или иных состояниях, и является моделью нейронной сети
Параметры конфигурации нейронной сети: 
+ trainer_type: параметр для выбора алгоритма обучения нейросети 
hyperparameters:
+ batch_size: размер пакета, на которые мы делим тренировочный сет, или количество тренировочных объектов в одной итерации (я не увидела параметра iterations) градиентного спуска (функция для уменьшения значения функции затрат)
+ buffer_size: количество опытов, которые необходимо собрать перед обновлением модели (для указанного в конфиге ppo)
+ learning_rate: начальная скорость обучения для градиентного спуска 
+ beta: отвечает за энтропию (меру беспорядка) в системе, в зависимости от данного параметра агент совершает либо большее (когда beta увеличивается), либо меньшее количество случайных действий
+ epsilon: влияет на то, насколько быстро политика (механизм принятия решений, в данном случае - модель) может развиваться во время обучения. Соответствует допустимому порогу расхождения между старой и новой политикой
+ lambd: параметр регуляризации, используемый при расчёте обобщённой оценки функции преимущества 
+ num_epoch: количество проходов через буфер опыта при оптимизации градиентного спуска.
+ learning_rate_schedule: определяет, как скорость обучения изменяется с течением времени
network_settings:
+ normalize: true\false - говорит, применяется ли нормализация к входным данным векторного наблюдения (не совсем понимаю, что это)
+ hidden_units: количество блоков в скрытых слоях нейронной сети (слои, отвечающие за преобразования входных данных) 
+ num_layers: количество скрытых слоёв нейронной сети 
reward_signals:
extrinsic:
+ gamma: коэффициент дисконтирования для будущих вознаграждений (я так поняла, что он связан с тем, насколько в просчитывании действий агент опирается на возможные вознаграждения, а не на текущие)
+ strength: множитель для вознаграждения, полученного агентом
+ max_steps: общее количество шагов, которое нужно выполнить перед завершением обучения
+ time_horizon: количество шагов опыта(количество изменений механизма, отвечающего за решения агента), которые нужно собрать для каждого агента, прежде чем поместить его в буфер опыта.
+ summary_freq: количество опытов, которое необходимо собрать перед созданием и отображением статистики обучения.

 

## Задание 3
Обучение агента (16 площадок): 
![изображение](https://github.com/SomEnaMeforme/DA-in-GameDev-lab1/blob/task_3/%D0%B4%D0%BB%D1%8F%20%D0%BB%D0%B0%D0%B1%D1%8B%20-3.1.gif)
Промежуточные результаты обучения агента: 
![изображение](https://user-images.githubusercontent.com/98802409/204083759-70f1dfc1-1662-4658-a1cc-476ed740caa5.png)
Поведение агента после того, как была изменена модель: 
![изображение](https://github.com/SomEnaMeforme/DA-in-GameDev-lab1/blob/task_3/%D0%B4%D0%BB%D1%8F%20%D0%BB%D0%B0%D0%B1%D1%8B%20-3.2.gif)

Код выполнения можно найти в файлах в данной ветке


## Выводы

Абзац умных слов о том, что было сделано и что было узнано:
В данной лабораторной работе я познакомилась с программными средствами для создания системы машинного обучения и ее интеграции в Unity, проследила за тренировкой нейросети, выявила, что чем больше полигонов используется в тренировке, тем быстрее нейросеть научится достигать наилучшего результата, посмотрела на изменение в работе агента после того, как нейросеть была натренирована. И научилась гифки в README вставлять, что вообще очень круто.


| Plugin | README |
| ------ | ------ |
| Dropbox | [plugins/dropbox/README.md][PlDb] |
| GitHub | [plugins/github/README.md][PlGh] |
| Google Drive | [plugins/googledrive/README.md][PlGd] |
| OneDrive | [plugins/onedrive/README.md][PlOd] |
| Medium | [plugins/medium/README.md][PlMe] |
| Google Analytics | [plugins/googleanalytics/README.md][PlGa] |

## Powered by

**BigDigital Team: Denisov | Fadeev | Panov**
