# АНАЛИЗ ДАННЫХ И ИСКУССТВЕННЫЙ ИНТЕЛЛЕКТ [in GameDev]
Отчет по лабораторной работе #5 выполнил(а):
- Рушкова Ольга Игоревна
- РИ210940
Отметка о выполнении заданий (заполняется студентом):

| Задание | Выполнение | Баллы |
| ------ | ------ | ------ |
| Задание 1 | * | 60 |
| Задание 2 | * | 40 |

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
Ознакомиться с основными операторами языка Python на примере реализации линейной регрессии.

## Задание 1
### Измените параметры файла. yaml-агента и определить какие параметры и как влияют на обучение модели.
1 запуск с исходными параметрами

    1.1 Параметры yaml

    ![изображение](https://user-images.githubusercontent.com/98802409/204874411-f6b848e9-592b-4ee1-b5a1-797656ddf618.png)


    1.2 Получившиеся графики + результаты обучения

![изображение](https://user-images.githubusercontent.com/98802409/204845678-7cfea7d5-0614-4c3d-a8d8-062203f81025.png)

![изображение](https://user-images.githubusercontent.com/98802409/204847174-885a1615-8d15-4fa2-8c88-bec926967946.png)


2 запуск, увеличены параметр batch-size

    2.1 Параметры yaml

![изображение](https://user-images.githubusercontent.com/98802409/204893911-c0315f65-0068-471a-80a4-26653e6e0990.png)

    2.2 Получившиеся графики + результаты обучения
 
 ![изображение](https://user-images.githubusercontent.com/98802409/204894725-d9d075c5-b780-4061-ab24-012120332cbc.png)
 
 ![изображение](https://user-images.githubusercontent.com/98802409/204894875-62053987-b156-4fc5-8a99-41ead2fdd3f7.png)

 
3 запуск, увеличен параметр strength
    3.1 Параметры yaml

![изображение](https://user-images.githubusercontent.com/98802409/204864704-7f69cf24-f357-4bb6-9a30-968e5c14ced0.png)


    3.2 Получившиеся графики + результаты обучения
![изображение](https://user-images.githubusercontent.com/98802409/204864923-95ee900f-ec6b-47aa-b61f-da23f3eba0bd.png)

![изображение](https://user-images.githubusercontent.com/98802409/204864983-d078b7a8-0a38-4370-bb8b-e06a9d84fc42.png)


 4 запуск, уменьшен hidden_units 
 
    4.1 Параметры yaml
    
![изображение](https://user-images.githubusercontent.com/98802409/204892610-04674210-e8d8-493b-8efd-7ddbef3a5be4.png)



    4.2 Получившиеся графики + результаты обучения
    
![изображение](https://user-images.githubusercontent.com/98802409/204892478-4fdf4541-5017-45e6-8baa-06deea8a26f1.png)

![изображение](https://user-images.githubusercontent.com/98802409/204892553-234b68cc-c09d-4c79-b49a-e87e72ea721a.png)





5 запуск, увеличено количество эпох

    5.1 Параметры yaml

![изображение](https://user-images.githubusercontent.com/98802409/204870475-1d1a5c2c-11bb-43da-9383-b3a06df9fb12.png)



    5.2 Получившиеся графики + результаты обучения

![изображение](https://user-images.githubusercontent.com/98802409/204870408-ac59f693-a324-4004-a899-5a9e945c18f3.png)
![изображение](https://user-images.githubusercontent.com/98802409/204870798-780e1fb1-7f51-4f4b-9ef1-37461cda076c.png)


6 запуск(просто эксперимента ради), уменьшен параметр gamma до 0,5

    6.1 Параметры yaml
![изображение](https://user-images.githubusercontent.com/98802409/204874065-0b8a4b59-19bf-4a89-8ad9-09dbd5201506.png)

    6.2 Графики + результаты обучения
    
![изображение](https://user-images.githubusercontent.com/98802409/204873992-08172efc-321d-4c4d-9a2c-444f5a31b416.png)

![изображение](https://user-images.githubusercontent.com/98802409/204874029-6948b731-254b-4b0f-9369-88a8580a1429.png)
 
 
Выводы: 




## Задание 2
### Опишите результаты, выведенные в TensorBoard




## Выводы

Абзац умных слов о том, что было сделано и что было узнано:
В данной лабораторной работе я познакомилась с алгоритмом линейной регрессии: узнала принципы его работы и основные функции, которые использует данный алгоритм. Также установила необходимое программное обеспечение в виде Unity и создала свой первый проект, а такж ознакомилась с основными операторами языка Python и работой в google.colab


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
