1025. Демократия в опасности
Ограничение времени: 1.0 секунды
Ограничение памяти: 64 МБ

Вступление

В одном из островных государств Карибского бассейна все решения традиционно принимались простым большинством голосов на общем собрании граждан, которых, к счастью, было не очень много. Одна из местных партий, стремясь прийти к власти как можно более законным путем, смогла добиться некоторой реформы избирательной системы. Главным аргументом было то, что население острова в последнее время значительно возросло, и проведение общих собраний перестало быть легкой задачей.
Суть реформы состояла в следующем: с момента введения ее в действие все избиратели острова делились на K групп (необязательно равных по численности). Голосование по любому вопросу теперь следовало проводить отдельно в каждой группе, причем считалось, что группа высказывается «за», если «за» голосует более половины людей в этой группе, а в противном случае считалось, что группа высказывается «против». После проведения голосования в группах подсчитывалось количество групп, высказавшихся «за» и «против», и вопрос решался положительно в том и только том случае, когда групп, высказавшихся «за», оказывалось более половины общего количества групп.
Эта система вначале была с радостью принята жителями острова. Когда первые восторги рассеялись, очевидны стали, однако, некоторые недостатки новой системы. Оказалось, что сторонники партии, предложившей систему, смогли оказать некоторое влияние на формирование групп избирателей. Благодаря этому, они получили возможность проводить некоторые решения, не обладая при этом реальным большинством голосов!
Пусть, например, на острове были сформированы три группы избирателей, численностью в 5, 5 и 7 человек соответственно. Тогда партии достаточно иметь трех сторонников в каждой из первых двух групп, и она сможет провести решение всего шестью голосами «за», вместо девяти, необходимых при общем голосовании.

Задача

Вам надо написать программу, которая определяет по заданному разбиению избирателей на группы минимальное количество сторонников партии, достаточное, при некотором распределении их по группам, для принятия любого решения.

Исходные данные

В первой строке записано нечётное число K — количество групп избирателей (1 ≤ K ≤ 101). Во второй строке через пробел записаны K нечётных чисел, которые задают количество избирателей в группах. Население острова не превосходит 9999 человек.

Результат

Выведите минимальное количество сторонников партии, способное решить исход голосования.
