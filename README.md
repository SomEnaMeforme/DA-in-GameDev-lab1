# АНАЛИЗ ДАННЫХ И ИСКУССТВЕННЫЙ ИНТЕЛЛЕКТ [in GameDev]
Отчет по лабораторной работе #4 выполнил(а):
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
Ознакомиться с основными операторами языка Python на примере реализации линейной регрессии.

## Задание 1
Ход работы: 
0. Добавить код с реализацией работы перцептрона в проект
1. Операция OR (логическое ИЛИ)
    - Параметры тестовых примеров (массив ts): 
 
    ![изображение](https://user-images.githubusercontent.com/98802409/204110173-c6d2e8af-6f25-46cd-b142-f0cc1ee8ad50.png)
    - Результаты обучения перцептрона при количестве эпох, равном 1:
    ![изображение](https://user-images.githubusercontent.com/98802409/204110147-b0626882-4900-4ea1-b8f0-779236973157.png)
    - Результаты обучения перцептрона при количестве эпох, равном 2:
    ![изображение](https://user-images.githubusercontent.com/98802409/204110251-cfc147ea-45fe-46f6-9d68-9f85d1b0cf42.png)
    - Результаты обучения перцептрона при количестве эпох, равном 3:
    ![изображение](https://user-images.githubusercontent.com/98802409/204110274-44a930d3-84e9-42df-9235-c4886d58ad55.png)

    - Результаты обучения перцептрона при количестве эпох, равном 4:
    ![изображение](https://user-images.githubusercontent.com/98802409/204110297-da152046-920e-4e5e-ad0f-62b55cbba24e.png)
    ![изображение](https://user-images.githubusercontent.com/98802409/204110315-192fc9c2-8e49-41a3-89a7-d742a1f0b550.png)
    - Дополнительный скрин (только суммы ошибок) за 9 итераций: 
    
    ![изображение](https://user-images.githubusercontent.com/98802409/204162387-3b606c59-873e-4787-a49d-8a93861b4244.png)

Комментарии о корректности работы: в течении нескольких перезапусков работы перцептрона при количестве эпох, равном 4, он выдавал верные результаты при использовании его в качестве элемента ИЛИ. При увеличении входных данных в четыре раза после обучения он также ни разу не ошибся, так что можно считать, что соответствующего числа эпох для обучения ему достаточно. (но как показало дальнейшее построение графиков, всё же иногда на 4 эпохи растёт сумма ошибок, так что правильнее будет заметить, что для обучения требуется 5 эпох)

2. Операция AND (логическое И)
    - Параметры тестовых примеров: 

    ![изображение](https://user-images.githubusercontent.com/98802409/204110517-8c2c09bd-b93b-4694-8b33-31f6f8d82867.png)
    - Результаты обучения перцептрона при количестве эпох, равном 1:
    ![изображение](https://user-images.githubusercontent.com/98802409/204144648-3a067015-32a4-4e11-833b-c5c8bc3b5087.png)

    - Результаты обучения перцептрона при количестве эпох, равном 2:
    ![изображение](https://user-images.githubusercontent.com/98802409/204110781-c23648f2-6b2e-413d-91bd-f1d78b295fb7.png)

    - Результаты обучения перцептрона при количестве эпох, равном 5 (totalError не равен нулю, но на тестовых данных уже наблюдается правильное поведение):
     ![изображение](https://user-images.githubusercontent.com/98802409/204151055-fc7c5c59-b43f-4724-93d4-978f3c1693b2.png)
    - Результаты обучения перцептрона при количестве эпох, равном 6:
    ![изображение](https://user-images.githubusercontent.com/98802409/204151124-f9e45db9-4907-44d6-869c-e3876a059331.png)
    ![изображение](https://user-images.githubusercontent.com/98802409/204151143-6787c69f-7379-46cb-b64f-46f43a1e58b1.png)
    - Количество эпох, равное 7(результат сохранялся на протяжении нескольких перезапусков):
    ![изображение](https://user-images.githubusercontent.com/98802409/204151249-30c10bac-68b2-44dd-ae43-dd0caa54a431.png)

  
Комментарии о корректности работы: перцептрон справляется с задачей реализации логической операции И, хоть и обучается этому несколько дольше, чем операции ИЛИ

3. Операция NAND (логическое И)
    - Параметры тестовых примеров: 

    ![изображение](https://user-images.githubusercontent.com/98802409/204156950-890aef5b-a14c-4a02-87c4-fbdcef346f83.png)


    - Результаты обучения перцептрона при количестве эпох, равном 1:
    ![изображение](https://user-images.githubusercontent.com/98802409/204156996-a9c4310f-2d7a-4234-8950-2875e939696f.png)


    - Результаты обучения перцептрона при количестве эпох, равном 2:
    ![изображение](https://user-images.githubusercontent.com/98802409/204157029-b4f6755e-08ac-4955-bb56-97c1fc69863a.png)

    - Результаты обучения перцептрона при количестве эпох, равном 5 (totalError не равен нулю, но на тестовых данных уже наблюдается правильное поведение):
     ![изображение](https://user-images.githubusercontent.com/98802409/204157225-f9f5d626-7a91-4be3-b6ba-e1d1170fac8b.png)

    - Результаты обучения перцептрона при количестве эпох, равном 6:
    ![изображение](https://user-images.githubusercontent.com/98802409/204157261-123dfd35-f4ff-43a3-80f7-ca542a4c96a3.png)
    ![изображение](https://user-images.githubusercontent.com/98802409/204157277-91211105-b2a2-40ca-a4cf-f9a116bbff6d.png)

    - Количество эпох, равное 9(результат сохранялся на протяжении нескольких перезапусков):
    ![изображение](https://user-images.githubusercontent.com/98802409/204157489-9f25c56f-4ed6-4d39-ba9a-8873ab1341a9.png)


  
Комментарии о корректности работы: перцептрон справляется с задачей реализации логической операции НЕ И, количество эпох, требуемых дл обучения снова возросло (но учитывая малое количество перезапусков и небольшое различие между общим кол-вом эпох, это может быть просто статистической неточностью). 

4. Операция XOR (исключающее ИЛИ)
    - Параметры тестовых примеров: 

     ![изображение](https://user-images.githubusercontent.com/98802409/204157888-e98b98a0-61ae-4b96-af5c-cf8af3d27854.png)  

    - Результаты обучения перцептрона при количестве эпох, равном 4(блоки с вводом входных данных закомментированы, чтобы лучше было видно результат):
    ![изображение](https://user-images.githubusercontent.com/98802409/204157907-5b8e1287-df02-402d-a61b-f4b8564212d7.png)

    - Результаты обучения перцептрона при количестве эпох, равном 10:
    ![изображение](https://user-images.githubusercontent.com/98802409/204157955-b51bb321-a08a-4317-8365-45e2d8ea632e.png)


    - Результаты обучения перцептрона при количестве эпох, равном 100:
    ![изображение](https://user-images.githubusercontent.com/98802409/204157972-a9f838ce-5fa1-4a2a-9f4c-fe55a2515dce.png)

 Комментарии о корректности работы: перцептрон не может корректно выполнить логическую операцию XOR из-за того, что он представляет из себя линейный фильтр (графически - прямая, которая делит плоскость на две области - параметры из одной области дают на выход 0, а из другой - 1). Подобрать веса, чтобы подобным образом разделить плоскость для задачи исключающего ИЛИ просто невозможно (скрин плоскости с подходящими точками и не подходящими ниже), поэтому перцептрон с данной задаче не справляется
![изображение](https://user-images.githubusercontent.com/98802409/204159028-990e4e23-6bfd-46bc-a651-dc7522e0fead.png)
  



## Задание 2
### Построить графики зависимости количества эпох от ошибки обучения. Указать, от чего зависит необходимое количество эпох обучения.
1. OR
Данные:

![изображение](https://user-images.githubusercontent.com/98802409/204162312-93444c3d-48f1-4429-9ac3-ca4f379e57e1.png)
График: 

![изображение](https://user-images.githubusercontent.com/98802409/204163340-b52ce8dd-105e-4c28-a6b8-c8383005a7ee.png)


2. AND
Данные:
![изображение](https://user-images.githubusercontent.com/98802409/204162526-97f80caf-de61-4887-aafe-42a4bf61109d.png)
График:
![изображение](https://user-images.githubusercontent.com/98802409/204163376-9809e059-c82f-43a8-8183-d6ad9a095d29.png)


3. NAND
Данные:
![изображение](https://user-images.githubusercontent.com/98802409/204162763-227eea6f-749f-4649-8697-d66e0f95833b.png)

График:
![изображение](https://user-images.githubusercontent.com/98802409/204163383-3e9dbdaf-207d-4888-9b52-408f5a422e5b.png)

4. XOR
Данные: взяты из первого задания, в независимости от количества эпох и рандомно подобрынных коэффициентов сумма ошибок не меняется.
График: 

![изображение](https://user-images.githubusercontent.com/98802409/204163354-9dd0df28-152e-47fb-87a9-976c469a87fe.png)

От чего зависит необходимое количество эпох обучения: 
1) От формулы, по которой высчитывается ошибка
2) Способ, с помощью котого обновляются веса (в данной реализации перцептрона первый пункт следует из второго, так как изменение веса у параметра зависит от ошибки)
3) Размера массива ts (чем больше данных для обучения будет в одну эпоху, тем меньшее количество эпох понадобится для того, чтобы обучить перцептрон)

## Задание 3
### Построить визуальную модель работы перцептрона на сцене Unity
Код реализации в прикреплённых файлах. 
Визуализация: 
1. AND
![изображение](https://github.com/SomEnaMeforme/DA-in-GameDev-lab1/blob/task_4/%D0%B4%D0%BB%D1%8F%20%D0%BB%D0%B0%D0%B1%D1%8B%20-AND.gif)
2. OR
![изображение](https://github.com/SomEnaMeforme/DA-in-GameDev-lab1/blob/task_4/%D0%B4%D0%BB%D1%8F%20%D0%BB%D0%B0%D0%B1%D1%8B%20-OR.gif)
3. NAND
![изображение](https://github.com/SomEnaMeforme/DA-in-GameDev-lab1/blob/task_4/%D0%B4%D0%BB%D1%8F%20%D0%BB%D0%B0%D0%B1%D1%8B%20-NAND.gif)


## Выводы

Абзац умных слов о том, что было сделано и что было узнано:



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
