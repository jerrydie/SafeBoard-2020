# SafeBoard-2020
## 2.12 Прикладная задача №6 / C#
Указан код на C# частично решающий задачу 2.12 с индивидуальной части хакатона SafeBoard 2020 года.

Условие:

Жили были три мушкетера-архитектора. И один разработчик, по имени Д'Артаньян - вы. Пришли как то мушкетеры к Д'Артаньяну и попросили его подружиться с сервисом, который шлет странные данные. А на вопрос Д'Артаньяна почему же так, мушкетеры в своем стиле хором ответили "се ля ви".

Для того чтобы их обрабатывать мушкетеры дали Д'Артаньяну enum:

>public enum DataType

>\{
>
>    None = 0,
>
>    First = 1,
>
>    Second = 2,
>
>    Third = 3,
>
>    Fourth = 4
>
>\}

Сервис этот шлет текстовые данные, разделенные запятыми. Например такие: First,Third,Second,Second,1.

И еще мушкетеры сказали, что слова обязательно должны быть case-sensitive, а цифры в таком же виде как в enum.

Всё бы ничего, но сервис иногда присылает не пойми что. Поэтому вы решаете что нужно обработать эти данные и предоставить информацию о них и об ошибках в виде отчета. Отчет должен выглядеть так:

>Input data types:
>
>None(0)-0
>
>First(1)-2
>
>Second(2)-2
>
>Third(3)-1
>
>Fourth(4)-0
>
>Errors:
>
>Not valid input strings: Ten,wfsdf

В скобках значение enum-a, через тире количество вхождений в предоставленный список, затем выводятся ошибки через запятую (если есть).

Если на вход ничего не подано вывести "No data".
