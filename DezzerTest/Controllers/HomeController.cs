using Microsoft.AspNetCore.Mvc;
using DezzerTest.Models;

namespace DezzerTest.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Test()
        {
            List<Question> questions = new List<Question>
            {
                new Question
{
    Text = "Какой кофе вы бы выбрали?",
    Answers = new List<Answer>
    {
        new Answer { Text = "Фраппучино", Character = "Милена / Иерархия" },
        new Answer { Text = "Не пью кофе", Character = "Хэс / Эремиция" },
        new Answer { Text = "Эспрессо", Character = "Ася / Катарсис" },
        new Answer { Text = "Карамельный латте", Character = "Мира / Effórt" },
        new Answer { Text = "Раф", Character = "Зуля / Zxeg" },
        new Answer { Text = "Латте с фисташкой", Character = "Динара / Diletant" }
    }
},

new Question
{
    Text = "В какой комнате вы бы жили?",
    Answers = new List<Answer>
    {
        new Answer { Text = "Уютная темная комната", Character = "Динара / Diletant" },
        new Answer { Text = "Библиотека с высокими стеллажами", Character = "Ася / Катарсис" },
        new Answer { Text = "Комната с гирляндами", Character = "Зуля / Zxeg" },
        new Answer { Text = "Комната с плотными шторами и тишиной", Character = "Милена / Иерархия" },
        new Answer { Text = "Комната рядом с лесом", Character = "Хэс / Эремиция" },
        new Answer { Text = "Комната с приглушённым светом и большой кроватью", Character = "Мира / Effórt" }
    }
},

new Question
{
    Text = "Что чаще всего играет у вас в наушниках?",
    Answers = new List<Answer>
    {
        new Answer { Text = "Спокойная иностранная музыка", Character = "Мира / Effórt" },
        new Answer { Text = "Поп", Character = "Зуля / Zxeg" },
        new Answer { Text = "Атмосферные песни", Character = "Динара / Diletant" },
        new Answer { Text = "Любая музыка, лишь бы не слышать людей", Character = "Милена / Иерархия" },
        new Answer { Text = "Классика или рэп", Character = "Ася / Катарсис" },
        new Answer { Text = "Зарубежные песни", Character = "Хэс / Эремиция" }
    }
},

new Question
{
    Text = "Какой предмет вы бы забрали из заброшенного замка?",
    Answers = new List<Answer>
    {
        new Answer { Text = "Зеркало из комнаты королевы", Character = "Хэс / Эремиция" },
        new Answer { Text = "Архивные записи", Character = "Мира / Effórt" },
        new Answer { Text = "Старую карту с непонятными отметками", Character = "Милена / Иерархия" },
        new Answer { Text = "Шкатулку с воспоминаниями", Character = "Ася / Катарсис" },
        new Answer { Text = "Старые письма", Character = "Динара / Diletant" },
        new Answer { Text = "Дневник", Character = "Зуля / Zxeg" }
    }
},

new Question
{
    Text = "Какая погода вам ближе?",
    Answers = new List<Answer>
    {
        new Answer { Text = "Туман в любое время суток", Character = "Ася / Катарсис" },
        new Answer { Text = "Жаркая", Character = "Динара / Diletant" },
        new Answer { Text = "Осенний дождь", Character = "Милена / Иерархия" },
        new Answer { Text = "Дождь и пасмурная погода", Character = "Хэс / Эремиция" },
        new Answer { Text = "Дождь", Character = "Мира / Effórt" },
        new Answer { Text = "Туманное утро", Character = "Зуля / Zxeg" }
    }
},

new Question
{
    Text = "Если бы вы были персонажем книги, то кем?",
    Answers = new List<Answer>
    {
        new Answer { Text = "Главным героем", Character = "Зуля / Zxeg" },
        new Answer { Text = "Помощником главного героя, который исчезнет", Character = "Мира / Effórt" },
        new Answer { Text = "Роберт Локамп, книга Ремарка «Три товарища»", Character = "Хэс / Эремиция" },
        new Answer { Text = "Одержимым второстепенным персонажем", Character = "Ася / Катарсис" },
        new Answer { Text = "Хранителем древних знаний", Character = "Милена / Иерархия" },
        new Answer { Text = "Хацуми из новержского леса, книга Харуки Мураками", Character = "Динара / Diletant" }
    }
},

new Question
{
    Text = "Какой цвет ассоциируется с вами сильнее всего?",
    Answers = new List<Answer>
    {
        new Answer { Text = "Чёрный", Character = "Динара / Diletant" },
        new Answer { Text = "Тёмно-фиолетовый", Character = "Мира / Effórt" },
        new Answer { Text = "Синий", Character = "Зуля / Zxeg" },
        new Answer { Text = "Тёмно-серый", Character = "Хэс / Эремиция" },
        new Answer { Text = "Зелёный или серый", Character = "Ася / Катарсис" },
        new Answer { Text = "Тёмно-синий", Character = "Милена / Иерархия" }
    }
},

new Question
{
    Text = "Что бы вы сделали, найдя машину времени?",
    Answers = new List<Answer>
    {
        new Answer { Text = "Спрятала бы её", Character = "Милена / Иерархия" },
        new Answer { Text = "Прошла бы мимо неё", Character = "Хэс / Эремиция" },
        new Answer { Text = "Узнала бы своё будущее", Character = "Мира / Effórt" },
        new Answer { Text = "Прыгнула бы в будущее", Character = "Динара / Diletant" },
        new Answer { Text = "Исправила бы одну ошибку", Character = "Зуля / Zxeg" },
        new Answer { Text = "Уничтожила бы её", Character = "Ася / Катарсис" }
    }
},

new Question
{

    Text = "Какой вайб чата вам ближе?",
    Answers = new List<Answer>
    {
        new Answer { Text = "Активное общение, а потом надолго пропасть", Character = "Мира / Effórt" },
        new Answer { Text = "Философские разговоры в 3 часа ночи", Character = "Зуля / Zxeg" },
        new Answer { Text = "Спокойное наблюдение", Character = "Хэс / Эремиция" },
        new Answer { Text = "Молчать и иногда писать одну точную мысль", Character = "Милена / Иерархия" },
        new Answer { Text = "Щитпостинг", Character = "Динара / Diletant" },
        new Answer { Text = "Гиперфиксы и странные разговоры", Character = "Ася / Катарсис" }
    }
},

new Question
{
    Text = "Вы заходите в книжный магазин. Куда идете первым делом?",
    Answers = new List<Answer>
    {
        new Answer { Text = "Книги Ремарка", Character = "Хэс / Эремиция" },
        new Answer { Text = "К самым старым и малоизвестным книгам", Character = "Милена / Иерархия" },
        new Answer { Text = "К психологии и художественной литературе", Character = "Мира / Effórt" },
        new Answer { Text = "К зарубежной классике", Character = "Ася / Катарсис" },
        new Answer { Text = "К классике", Character = "Зуля / Zxeg" },
        new Answer { Text = "В отдел Мураками", Character = "Динара / Diletant" }
    }
},

new Question
{
    Text = "Какой предмет лучше всего описывает ваш характер?",
    Answers = new List<Answer>
    {
        new Answer { Text = "Компас", Character = "Зуля / Zxeg" },
        new Answer { Text = "Перец на вид сочный, по вкусу острый", Character = "Динара / Diletant" },
        new Answer { Text = "Перо для письма", Character = "Ася / Катарсис" },
        new Answer { Text = "Карманные часы со сложным механизмом", Character = "Милена / Иерархия" },
        new Answer { Text = "Зеркало", Character = "Мира / Effórt" },
        new Answer { Text = "Плюшевый медведь", Character = "Хэс / Эремиция" }
    }
},

new Question
{
    Text = "Если бы ваша жизнь была фильмом, какой жанр это был бы?",
    Answers = new List<Answer>
    {
        new Answer { Text = "Фэнтези или драма", Character = "Динара / Diletant" },
        new Answer { Text = "Антиутопия", Character = "Ася / Катарсис" },
        new Answer { Text = "Психологический детектив", Character = "Милена / Иерархия" },
        new Answer { Text = "Комедийный детектив с элементами триллера", Character = "Мира / Effórt" },
        new Answer { Text = "Хоррор", Character = "Хэс / Эремиция" },
        new Answer { Text = "Детектив", Character = "Зуля / Zxeg" }
    }
}
            };

            return View(questions);
        }

        [HttpPost]
        public IActionResult Result(List<string> answers)
        {
            if (answers == null || answers.Count == 0)
            {
                return RedirectToAction("Test");
            }

            Dictionary<string, int> scores = new Dictionary<string, int>();

            foreach (string answer in answers)
            {
                if (!scores.ContainsKey(answer))
                {
                    scores[answer] = 0;
                }

                scores[answer]++;
            }

            string result = scores.OrderByDescending(x => x.Value).First().Key;

            string description = "";

            switch (result)
            {
                case "Милена / Иерархия":
                    description = @"Сочетает независимость мышления с сильным внутренним стержнем. 
Она не стремится привлекать внимание, предпочитая наблюдать, анализировать и принимать собственные решения. 
Ей близки свобода, развитие и искренность, а поверхностность быстро теряет для нее интерес. Если Милена выбирает цель, 
она идет к ней уверенно, сохраняя спокойствие и верность своим принципам. Она умеет видеть возможности там, 
где другие замечают лишь препятствия, и вдохновляет окружающих оставаться собой.";
                    break;

                case "Ася / Катарсис":
                    description = @"Самый настоящий стратег, который всегда думает на несколько шагов вперед. 
Она любит сложные идеи, необычные темы и легко превращает хаос в четкий план действий. 
Со стороны может показаться спокойной, но внутри постоянно работает поток мыслей, концепций и новых проектов. 
Она ценит знания, умеет видеть закономерности и редко оставляет что-либо на волю случая. 
Если за что-то берется она, можно быть уверенным: все будет продумано до мелочей.";
                    break;

                case "Зуля / Zxeg":
                    description = @"Сочетает в себе творческое мышление и любовь к поиску 
глубоких смыслов даже в самых обычных вещах. Она легко замечает красоту там, 
где другие проходят мимо, а еe решения чаще основаны на интуиции, чем на строгой логике. 
При этом она умеет признавать ошибки и стремится сделать окружающий мир хоть немного лучше. 
Ее идеи часто рождаются поздно ночью, когда начинаются самые интересные разговоры. 
Она человек, который помогает другим не потерять направление, оставаясь верным себе.";
                    break;

                case "Мира / Effórt":
                    description = @"Легко становится человеком, рядом с которым хочется остаться подольше. 
Она умеет поддержать разговор практически на любую тему, внимательно слушает людей и хорошо чувствует их настроение. 
При этом в ней есть легкая загадочность: иногда она неожиданно исчезает, словно ей необходимо время побыть наедине с собой. 
Она тонко понимает человеческие эмоции и умеет видеть в людях больше, чем они показывают окружающим. 
Благодаря этому общение с ней всегда остаётся теплым и запоминающимся.";
                    break;

                case "Хэс / Эремиция":
                    description = @"Кажется тихим и спокойным человеком, но именно такие люди чаще всего оказываются самыми надежными. 
Она не любит привлекать к себе внимание и предпочитает сначала внимательно изучить ситуацию, прежде чем действовать. 
В ней сочетаются мягкость, искренность и внутренняя стойкость, которая становится заметной только со временем. 
Она ценит глубокие связи, комфортную атмосферу и умеет сохранять самообладание даже тогда, когда вокруг становится шумно. 
Именно это делает ее человеком, которому легко доверять.";
                    break;

                case "Динара / Diletant":
                    description = @"Человек с живым воображением, которое постоянно подбрасывает новые идеи, сюжеты и неожиданные повороты. 
Ее тянет ко всему необычному, мрачному и эмоционально насыщенному, поэтому скучные истории точно не про нее. 
За любовью к черному юмору и безумию скрывается богатая фантазия и желание исследовать самые разные стороны человеческой природы. 
Она легко превращает обычную ситуацию в целую историю, которую будут обсуждать еще долго. 
Именно благодаря этой способности ее идеи всегда выделяются и редко кого оставляют равнодушным.";
                    break;
            }

            ViewBag.Result = result;
            ViewBag.Description = description;

            return View();
        }
    }
}