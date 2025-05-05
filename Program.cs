using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    class Program

    {
        static bool gameOver = false;
        static int stepCount = 0;

        static void EndGame(string endingText)
        {
            Console.WriteLine($"\n--- Конец истории ---\n{endingText}");
            gameOver = true;
        }
    



        static void Main()
        {
            Console.WriteLine("Вы просыпаетесь в пустом поезде. За окном — густой туман. Вы не помните, как сюда попали...");

            while (!gameOver)
            {
                stepCount++;
                Console.WriteLine($"\nШаг {stepCount}. Что вы хотите сделать?");
                Console.WriteLine("1 - Выйти из вагона");
                Console.WriteLine("2 - Исследовать поезд");
                Console.WriteLine("3 - Остаться на месте");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ExitTrain();
                        break;
                    case "2":
                        ExploreTrain();
                        break;
                    case "3":
                        StayInTrain();
                        break;
                    default:
                        Console.WriteLine("Неверный выбор. Попробуйте снова.");
                        stepCount--;
                        break;
                }

                if (stepCount >= 20)
                {
                    EndGame("Вы слишком долго блуждали. Туман поглотил вас навсегда... (Плохая концовка)");
                }
            }
        }

        static void ExitTrain()
        {

            Console.WriteLine("\nВы выходите из поезда. Перед вами заброшенная станция: ржавая табличка, облупившиеся стены и три направления.");

            Console.WriteLine("Куда пойти?");
            Console.WriteLine("1 - В здание станции");
            Console.WriteLine("2 - В тёмный туннель");
            Console.WriteLine("3 - В лес позади платформы");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    StationBuilding();
                    break;
                case "2":
                    DarkTunnel();
                    break;
                case "3":
                    Forest();
                    break;
                default:
                    Console.WriteLine("Вы стоите в нерешительности...");
                    stepCount--; 
                    break;
            }

        }
        static void StationBuilding()
        {
            Console.WriteLine("\nВы входите в здание станции. Внутри — пыль, паутина и старые афиши. В углу мерцает слабый свет.");

            Console.WriteLine("Что делать?");
            Console.WriteLine("1 - Подойти к источнику света");
            Console.WriteLine("2 - Осмотреть кассу");
            Console.WriteLine("3 - Вернуться на улицу");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Вы подходите ближе и находите старый фонарь. Он работает! Это может пригодиться.");
                    break;
                case "2":
                    Console.WriteLine("Вы открываете ящик кассы и находите билет. На нём дата — завтрашняя. Странно...");
                    break;
                case "3":
                    Console.WriteLine("Вы выходите обратно на платформу.");
                    break;
                default:
                    Console.WriteLine("Вы теряетесь в полумраке...");
                    stepCount--;
                    break;
            }
        }
        static void DarkTunnel()
        {
            Console.WriteLine("\nВы входите в туннель. Темно, сыро и очень тихо. Эхо шагов кажется слишком громким.");

            Console.WriteLine("Что делать?");
            Console.WriteLine("1 - Идти глубже");
            Console.WriteLine("2 - Посветить телефоном");
            Console.WriteLine("3 - Вернуться");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Вы идёте дальше и вдруг слышите шаги позади. Кто-то здесь...");
                    break;
                case "2":
                    Console.WriteLine("Свет телефона выхватывает надпись на стене: «Ты уже был здесь».");
                    break;
                case "3":
                    Console.WriteLine("Вы решаете вернуться на станцию.");
                    break;
                default:
                    Console.WriteLine("Вы стоите в нерешительности, погружаясь во мрак...");
                    stepCount--;
                    break;
            }
        }
        static void Forest()
        {
            Console.WriteLine("\nВы идёте в лес. Всё вокруг кажется нереальным. Ветки будто тянутся к вам, воздух густой.");

            Console.WriteLine("Что делать?");
            Console.WriteLine("1 - Идти по тропинке");
            Console.WriteLine("2 - Свернуть в чащу");
            Console.WriteLine("3 - Вернуться");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Тропинка приводит к домику с потухшими окнами.");
                    break;
                case "2":
                    Console.WriteLine("Вы теряетесь в лесу... шум усиливается...");
                    break;
                case "3":
                    Console.WriteLine("Вы возвращаетесь к станции.");
                    break;
                default:
                    Console.WriteLine("Вы стоите среди деревьев, не решаясь выбрать путь...");
                    stepCount--;
                    break;
            }
        }
        static void ExploreTrain()
        {
            Console.WriteLine("\nВы держите странный билет. На обратной стороне — координаты. Где вы их видели?..");

            Console.WriteLine("Что делать?");
            Console.WriteLine("1 - Попробовать вспомнить");
            Console.WriteLine("2 - Пойти искать по координатам");
            Console.WriteLine("3 - Выбросить билет");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Вы вспоминаете: именно по этим координатам погиб ваш брат... Совпадение?");
                    break;
                case "2":
                    Console.WriteLine("Вы выходите из здания и начинаете поиски. Через час — вы находитесь у старого тоннеля, которого не было раньше.");
                    SecretTunnel(); 
                    break;
                case "3":
                    Console.WriteLine("Вы выбрасываете билет, и слышится далёкий шёпот: «Ты сделал это снова...»");
                    break;
                default:
                    Console.WriteLine("Вы стоите, глядя на билет.");
                    stepCount--;
                    break;
            }
        }
        static void SecretTunnel()
        {
            Console.WriteLine("\nСекретный тоннель скрыт за кустами. Он выглядит как древняя шахта. Воздух становится тяжёлым.");

            Console.WriteLine("Что делать?");
            Console.WriteLine("1 - Войти внутрь");
            Console.WriteLine("2 - Закрыть вход и уйти");
            Console.WriteLine("3 - Окликнуть кого-то");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Вы входите внутрь. Через несколько шагов дверь за вами захлопывается. Вы в ловушке.");
                    EndGame("Вы остались навсегда в ловушке. Никто не услышит ваш крик... (Плохая концовка)");
                    break;
                case "2":
                    Console.WriteLine("Вы задвигаете кусты и уходите. Внутри что-то шевелится...");
                    break;
                case "3":
                    Console.WriteLine("Голос в ответ: «Ты ведь сам сюда пришёл». Вы в ужасе бежите обратно.");
                    break;
                default:
                    Console.WriteLine("Вы стоите у входа.");
                    stepCount--;
                    break;
            }
        }
        static void ForestCabin()
        {
            Console.WriteLine("\nДомик старый, но дверь приоткрыта. Внутри — свет свечи и чей-то голос.");

            Console.WriteLine("Что делать?");
            Console.WriteLine("1 - Зайти внутрь");
            Console.WriteLine("2 - Подглядеть в окно");
            Console.WriteLine("3 - Уйти обратно");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Вы заходите... Старик поворачивается к вам и говорит: «Ты можешь уйти. Но только один раз.»");
                    EndGame("Вы выбрались. Вас долго считали пропавшим, но вы живы. (Хорошая концовка)");
                    break;
                case "2":
                    Console.WriteLine("Вы подглядываете. Внутри вы сами — но старше. Вы в ужасе убегаете.");
                    break;
                case "3":
                    Console.WriteLine("Вы уходите обратно, но лес будто стал другим. Вы потерялись.");
                    break;
                default:
                    Console.WriteLine("Вы стоите в нерешительности.");
                    stepCount--;
                    break;
            }
        }
        static void TunnelEcho()
        {
            Console.WriteLine("\nВы идёте по туннелю всё глубже. Шаги, капли воды, ощущение слежки...");

            Console.WriteLine("Что делать?");
            Console.WriteLine("1 - Кричать");
            Console.WriteLine("2 - Бежать");
            Console.WriteLine("3 - Повернуть обратно");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Ваш крик отражается эхом... и вдруг возвращается чужим голосом: «Ты звал меня?»");
                    break;
                case "2":
                    Console.WriteLine("Вы бежите вслепую, спотыкаясь... и вдруг оказываетесь снова у входа. Но солнце уже село.");
                    break;
                case "3":
                    Console.WriteLine("Вы разворачиваетесь и идёте назад. Но туннель не кончается...");
                    break;
                default:
                    Console.WriteLine("Вы колеблетесь.");
                    stepCount--;
                    break;
            }
        }
        static void StayInTrain()
        {
            Console.WriteLine("\nВы решаете остаться в поезде и ничего не делать. Вы сидите. Ждёте. Время не идёт.");

            Console.WriteLine("1 - Встать");
            Console.WriteLine("2 - Заснуть");
            Console.WriteLine("3 - Стукнуть в окно");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Вы встали — но поезд больше не существует. Только пустота за вами.");
                    break;
                case "2":
                    Console.WriteLine("Вы засыпаете... и просыпаетесь в том же месте. Снова. И снова.");
                    EndGame("Вечная петля. Вы не умерли — но и не живёте. (Нейтральная концовка)");
                    break;
                case "3":
                    Console.WriteLine("За окном кто-то стучит в ответ. Только вас никто не должен видеть...");
                    break;
                default:
                    Console.WriteLine("Время остановилось.");
                    stepCount--;
                    break;
            }
        }
        static void SecretCarriage()
        {
            Console.WriteLine("\nВы находите потайной вагон. Дверь открывается сама. Внутри зеркала... и вы, но в другом возрасте.");

            Console.WriteLine("1 - Зайти внутрь");
            Console.WriteLine("2 - Уйти, не глядя");
            Console.WriteLine("3 - Разбить зеркало");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Вы заходите. Зеркала смыкаются. Вы стали отражением...");
                    EndGame("Теперь вы — часть вагона. Кто-то другой увидит вас позже. (Мистическая концовка)");
                    break;
                case "2":
                    Console.WriteLine("Вы уходите. Зеркала гаснут. Вагон исчезает...");
                    break;
                case "3":
                    Console.WriteLine("Вы разбиваете зеркало. Оно шепчет: «Ты разрушил себя». Вы теряете сознание.");
                    break;
                default:
                    Console.WriteLine("Отражения замирают, глядя на вас.");
                    stepCount--;
                    break;
            }
        }
        static void LoopingPath()
        {
            Console.WriteLine("\nВы замечаете, что всё повторяется. Станция, тоннель, поезд. Всё как раньше.");

            Console.WriteLine("1 - Смириться");
            Console.WriteLine("2 - Искать выход");
            Console.WriteLine("3 - Сесть и ждать");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    EndGame("Вы стали частью этого места. Оно больше не чужое. (Философская концовка)");
                    break;
                case "2":
                    Console.WriteLine("Вы идёте и вдруг находите лифт, скрытый в земле...");
                    ElevatorEscape();
                    break;
                case "3":
                    Console.WriteLine("Вы сидите. И внезапно слышите — поезд приближается. Но его не видно...");
                    break;
                default:
                    Console.WriteLine("Петля не любит нерешительных.");
                    stepCount--;
                    break;
            }
        }
        static void ElevatorEscape()
        {
            Console.WriteLine("\nЛифт ржавый, но работает. Вы спускаетесь. Всё темнее и темнее.");

            Console.WriteLine("1 - Прервать спуск");
            Console.WriteLine("2 - Продолжать");
            Console.WriteLine("3 - Открыть дверь вручную");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Лифт замирает. Вас выкидывает в темноту...");
                    EndGame("Вы исчезли между мирами. Вас не найти. (Потерянная концовка)");
                    break;
                case "2":
                    Console.WriteLine("Вы доезжаете до дна. Свет. Город. Люди.");
                    EndGame("Вы вернулись в реальность. Но что-то навсегда осталось с вами. (Условно хорошая концовка)");
                    break;
                case "3":
                    Console.WriteLine("Вы открываете дверь... и видите только бесконечную шахту.");
                    EndGame("Вы шагнули вперёд. И падаете. Падаете. Падаете. (Бездна)");
                    break;
                default:
                    Console.WriteLine("Лифт скрипит.");
                    stepCount--;
                    break;
            }
        }
        static void SelfEncounter()
        {
            Console.WriteLine("\nВы сталкиваетесь с собой. Точно такой же, но испуганный. Он кричит: «Уходи! Это ловушка!»");

            Console.WriteLine("1 - Поговорить");
            Console.WriteLine("2 - Убежать");
            Console.WriteLine("3 - Дотронуться до него");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Он шепчет: «Ты уже был здесь. Только забудь...»");
                    EndGame("Вы просыпаетесь дома. Всё забыто. Но вам снится станция. (Сомнительная реальность)");
                    break;
                case "2":
                    Console.WriteLine("Вы бежите и больше его не видите.");
                    break;
                case "3":
                    Console.WriteLine("Как только вы касаетесь — всё исчезает.");
                    EndGame("Вы слились с собой. Теперь вы — охранник этого места. (Страж)");
                    break;
                default:
                    Console.WriteLine("Он смотрит на вас молча.");
                    stepCount--;
                    break;
            }
        }
        static void GuideAppearance()
        {
            Console.WriteLine("\nНа платформе появляется человек в форме. Он говорит: «Ты можешь уйти. Но заплатишь памятью.»");

            Console.WriteLine("1 - Согласиться");
            Console.WriteLine("2 - Отказаться");
            Console.WriteLine("3 - Напасть на него");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    EndGame("Вы выходите в город. Не помните ничего. Но чувствуете — вы вырвались. (Цена свободы)");
                    break;
                case "2":
                    Console.WriteLine("Проводник исчезает. Поезд гудит. Что-то упущено...");
                    break;
                case "3":
                    Console.WriteLine("Он исчезает. Но вы теперь на его месте.");
                    EndGame("Теперь вы встречаете других. Предлагаете выбор. (Переход)");
                    break;
                default:
                    Console.WriteLine("Он ждёт ответа.");
                    stepCount--;
                    break;
            }
        }
        static void FinalChoice()
        {
            Console.WriteLine("\nВам открываются все дороги. Поезд, станция, лес, туннель, зеркала, старик, проводник — всё рядом.");

            Console.WriteLine("1 - Войти в поезд");
            Console.WriteLine("2 - Пойти за светом");
            Console.WriteLine("3 - Остановиться");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    EndGame("Поезд уносит вас вдаль. Навсегда. Вы исчезаете из этого мира. (Путешественник между мирами)");
                    break;
                case "2":
                    EndGame("Вы идёте за светом и выходите к самому себе — живому, настоящему. (Возвращение)");
                    break;
                case "3":
                    EndGame("Вы стоите. Всё исчезает. Вы проснулись. Но с левой ладони — не сходит след билета. (Проснулся ли ты?)");
                    break;
                default:
                    Console.WriteLine("Все пути ждут...");
                    stepCount--;
                    break;
            }
        }



        
          
    }
   
}