namespace SummaryOfAll
{
    public class DotaExample
    {
        
    }

    class Map
    {
        public Map(Radiant radiant, Dire dire)
        {
            // какой-то код
        }
    }

    class Radiant
    {
        // инициализировать новый экземпляр так:
        // new Radiant(new Magnus(), new Pudge(), new Sven(), new Windragner(), new Luna()) сработает
        public Radiant(Hero h1, Hero h2, Hero h3, Hero h4, Hero h5)
        {
            // какой-то код
        }  
    }

    class Dire
    {
        public Dire(Magnus m, Pudge p, Windranger w, Sven s, Luna l)
        {
            // какой-то код
        }
    }
    abstract class Hero{}
    // пероснажи
    class Magnus : Hero{}
    class Pudge : Hero{}
    class Windranger : Hero{}
    class Sven : Hero{}
    class Luna : Hero{}
    class Centaur : Hero{}
    class Antimage : Hero{}
    class Treant : Hero{}
    class Earthshaker : Hero{}
    class Lonedruid : Hero{}
}