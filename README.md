# Bot + Parser
 
Это самый стандартный телеграм - бот, который используется в связке с парсером.
У бота есть 3 команды:1
/start - начальное приветствие пользователя,
/top100 - парсинг с сайта первых 100 тайтлов аниме, а потом вывод пользователю,
/randomtitle - выбор рандомного тайтла из списка топ-100, после чего тоже выводит на экран.

Так же подключенная dll парсера, который основан на HtmlAgilityPack. В парсере есть два метода: для страниц {page} и для одной страницы. В зависимости от сайта, который вы парсите - нужно выбрать правильный метод и передать в конструктор диапазон парсинга, после чего бот будет работать.

На будущее, если дойдут руки, то буду парсить несколько сайта со списками, а потом делать среднее значения каждой позиции. 
